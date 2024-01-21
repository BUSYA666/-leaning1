using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Сleaning;

namespace Cleaning
{
    public partial class Price : Form
    {
        private List<KeyValuePair<string, string>> services;

        public Price()
        {
            InitializeComponent();

            SquareBox.Text = "Введите площадь";
            SquareBox.ForeColor = Color.Black;

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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PriceButton_Click(object sender, EventArgs e)
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
        private void OrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order1 priceForm = new Order1();
            priceForm.ShowDialog();
            this.Close();
        }

        private void SquareBox_Leave(object sender, EventArgs e)
        {
            if (SquareBox.Text == "")
            {
                SquareBox.Text = "Введите площадь";
                SquareBox.ForeColor = Color.Black;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
