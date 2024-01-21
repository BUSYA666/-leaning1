using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Сleaning
{
    public partial class Order1 : Form
    {
        private string connectionString = "Data Source=Cleaning.db;Version=3;";
        private List<KeyValuePair<string, string>> services;

        public Order1()
        {
            InitializeComponent();
            LoadDataIntoTableOrder();
            SetTextBoxPlaceholders();


            SquareBox.ForeColor = Color.Gray;

            this.PraceField.AutoSize = false;
            this.PraceField.Size = new Size(this.PraceField.Size.Width, 27);

            services = new List<KeyValuePair<string, string>>();
            services.Add(new KeyValuePair<string, string>("Генеральная уборка", "1000"));
            services.Add(new KeyValuePair<string, string>("Уборка после ремонта", "800"));
            services.Add(new KeyValuePair<string, string>("Уборка офисов", "500"));
            services.Add(new KeyValuePair<string, string>("Чистка ковров", "300"));
            services.Add(new KeyValuePair<string, string>("Мойка окон", "400"));
            services.Add(new KeyValuePair<string, string>("Уборка после праздников или мероприятий", "1200"));
            services.Add(new KeyValuePair<string, string>("Уход за мебелью и обивкой", "600"));
            services.Add(new KeyValuePair<string, string>("Сезонная уборка", "900"));

            foreach (var service in services)
            {
                ServicesList.Items.Add(service.Key);
            }

            if (ServicesList.Items.Count > 0)
            {
                ServicesList.SelectedIndex = 0;
            }
        }

        private void SetTextBoxPlaceholders()
        {
            SquareBox.Text = "Введите площадь";
            SquareBox.ForeColor = Color.Gray;

            FullNameBox.Text = "Введите ФИО";
            FullNameBox.ForeColor = Color.Gray;

            AddressBox.Text = "Введите адрес";
            AddressBox.ForeColor = Color.Gray;

            TotalPriceField.Text = "Итоговая цена";
            TotalPriceField.ForeColor = Color.Black;

        }

        private void LoadDataIntoTableOrder()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Cleaning (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, Name TEXT, Prace TEXT, FullName TEXT, Address TEXT)";
                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                string selectDataQuery = "SELECT * FROM Cleaning";
                using (SQLiteCommand selectDataCommand = new SQLiteCommand(selectDataQuery, connection))
                {
                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectDataCommand))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        OrderTable.DataSource = dataTable;
                        OrderTable.Columns["Id"].Visible = false;
                    }
                }

                connection.Close();
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ServicesList.Text) || string.IsNullOrWhiteSpace(TotalPriceField.Text) ||
                string.IsNullOrWhiteSpace(FullNameBox.Text) || string.IsNullOrWhiteSpace(AddressBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertDataQuery = "INSERT INTO Cleaning (Name, Prace, FullName, Address) VALUES (@Name, @Prace, @FullName, @Address)";
                using (SQLiteCommand insertDataCommand = new SQLiteCommand(insertDataQuery, connection))
                {
                    insertDataCommand.Parameters.AddWithValue("@Name", ServicesList.Text);
                    insertDataCommand.Parameters.AddWithValue("@Prace", TotalPriceField.Text);
                    insertDataCommand.Parameters.AddWithValue("@FullName", FullNameBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@Address", AddressBox.Text);

                    const int maxRetries = 5;
                    int retries = 0;
                    bool success = false;

                    while (retries < maxRetries)
                    {
                        try
                        {
                            insertDataCommand.ExecuteNonQuery();
                            success = true;
                            break;
                        }
                        catch (SQLiteException ex)
                        {
                            if (ex.ErrorCode == (int)SQLiteErrorCode.Locked)
                            {
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message);
                                success = false;
                                break;
                            }
                        }

                        retries++;
                    }

                    if (success)
                    {
                        LoadDataIntoTableOrder();

                        ServicesList.Text = "";
                        TotalPriceField.Text = "";
                        FullNameBox.Text = "";
                        AddressBox.Text = "";
                        PraceField.Text = ""; // Очищаем поле PraceField

                        SetTextBoxPlaceholders();

                        MessageBox.Show("Данные сохранены!");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось сохранить данные. Попробуйте еще раз позже.");
                    }
                }

                connection.Close();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedService = ServicesList.SelectedItem.ToString();

            KeyValuePair<string, string> service = services.Find(item => item.Key == selectedService);

            PraceField.Text = service.Value + " руб";
            if (double.TryParse(service.Value, out double price) && double.TryParse(SquareBox.Text, out double square))
            {
                double totalPrice = price * square;
                TotalPriceField.Text = totalPrice.ToString() + " руб";
            }
        }

        private void SquareBox_Enter(object sender, EventArgs e)
        {
            if (SquareBox.Text == "Введите площадь")
            {
                SquareBox.Text = "";
                SquareBox.ForeColor = Color.Black;
            }
        }

        private void SquareBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SquareBox.Text))
            {
                SquareBox.Text = "Введите площадь";
                SquareBox.ForeColor = Color.Gray;
            }
        }

        private void FullNameBox_Enter(object sender, EventArgs e)
        {
            if (FullNameBox.Text == "Введите ФИО")
            {
                FullNameBox.Text = "";
                FullNameBox.ForeColor = Color.Black;
            }
        }

        private void FullNameBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameBox.Text))
            {
                FullNameBox.Text = "Введите ФИО";
                FullNameBox.ForeColor = Color.Gray;
            }
        }


        private void AddressBox_Enter(object sender, EventArgs e)
        {
            if (AddressBox.Text == "Введите адрес")
            {
                AddressBox.Text = "";
                AddressBox.ForeColor = Color.Black;
            }
        }

        private void AddressBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddressBox.Text))
            {
                AddressBox.Text = "Введите адрес";
                AddressBox.ForeColor = Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OrderTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedId = Convert.ToInt32(OrderTable.SelectedRows[0].Cells["Id"].Value);
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string deleteDataQuery = "DELETE FROM Cleaning WHERE Id = @Id";
                    using (SQLiteCommand deleteDataCommand = new SQLiteCommand(deleteDataQuery, connection))
                    {
                        deleteDataCommand.Parameters.AddWithValue("@Id", selectedId);
                        deleteDataCommand.ExecuteNonQuery();

                        LoadDataIntoTableOrder();

                        MessageBox.Show("Запись успешно удалена!");
                    }

                    connection.Close();
                }
            }
        }
    }
}


