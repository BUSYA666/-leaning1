using Cleaning;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Сleaning
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = "Data Source=Cleaning.db;Version=3;";
        private Point lastPoint;

        public LoginForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 27);
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Auth WHERE Login=@Login AND Pass=@Pass";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Login", LoginField.Text);
                    command.Parameters.AddWithValue("@Pass", passField.Text);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Авторизация прошла успешно");
                            // код для входа обычного пользователя
                            Form fAuthorization = new MainForm();
                            fAuthorization.Show();
                            fAuthorization.FormClosed += new FormClosedEventHandler(form_FormClosed);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Логин или пароль были неверны.");
                        }
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
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
