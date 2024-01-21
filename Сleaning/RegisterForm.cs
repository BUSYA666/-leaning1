using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Сleaning;

namespace Cleaning
{
    public partial class RegisterForm : Form
    {
        private Point lastPoint;
        private readonly string connectionString = "Data Source=Cleaning.db;Version=3;";

        public RegisterForm()
        {
            InitializeComponent();

            Name.Text = "Введите имя";
            Name.ForeColor = Color.Red;

            Surname.Text = "Введите фамилию";
            Surname.ForeColor = Color.Red;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Cyan;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (Name.Text == "")
            {
                Name.Text = "Введите имя";
                Name.ForeColor = Color.Red;
            }
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (Name.Text == "Введите имя")
            {
                Name.Text = "";
                Name.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Введите фамилию";
                Surname.ForeColor = Color.Red;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Введите фамилию")
            {
                Surname.Text = "";
                Surname.ForeColor = Color.Black;
            }
        }

        private void buttonRegis_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Pass.Text;

            // Проверка, если поля логина и пароля пусты
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            // Проверка, если такой пользователь уже существует
            string checkUserSql = "SELECT COUNT(*) FROM Auth WHERE Login=@Login";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand checkUserCommand = new SQLiteCommand(checkUserSql, connection))
                {
                    checkUserCommand.Parameters.AddWithValue("@Login", login);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());
                    if (userCount > 0)
                    {
                        MessageBox.Show("Такой пользователь уже существует.");
                        return;
                    }
                }
            }

            // Регистрация нового пользователя
            string insertUserSql = "INSERT INTO Auth (Login, Pass) VALUES (@Login, @Pass)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand insertUserCommand = new SQLiteCommand(insertUserSql, connection))
                {
                    insertUserCommand.Parameters.AddWithValue("@Login", login);
                    insertUserCommand.Parameters.AddWithValue("@Pass", password);
                    int rowsAffected = insertUserCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Регистрация прошла успешно.");

                        // Добавление нового пользователя
                        string name = Name.Text;
                        string surname = Surname.Text;

                        string insertUserDetailsSql = "INSERT INTO Auth (Login, Pass, Name, Surname) VALUES (@Login, @Pass, @Name, @Surname)";
                        using (SQLiteCommand insertUserDetailsCommand = new SQLiteCommand(insertUserDetailsSql, connection))
                        {
                            insertUserDetailsCommand.Parameters.AddWithValue("@Name", name);
                            insertUserDetailsCommand.Parameters.AddWithValue("@Surname", surname);
                            insertUserDetailsCommand.Parameters.AddWithValue("@Login", login);
                            insertUserDetailsCommand.Parameters.AddWithValue("@Pass", password);

                            try
                            {
                                rowsAffected = insertUserDetailsCommand.ExecuteNonQuery();
                                MessageBox.Show("Новый пользователь успешно добавлен.");
                                // Код для входа обычного пользователя
                                MainForm fAuthorization = new MainForm();
                                fAuthorization.Show();
                                fAuthorization.FormClosed += new FormClosedEventHandler(form_FormClosed);
                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при добавлении нового пользователя: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при регистрации пользователя.");
                    }
                }
            }
        }

        private void form_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm registerForm = new LoginForm();
            registerForm.Show();


        }
    }
}