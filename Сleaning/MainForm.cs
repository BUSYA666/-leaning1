using Cleaning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сleaning
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Price priceForm = new Price();
            priceForm.ShowDialog(); 
            this.Close(); 
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order1 priceForm = new Order1();
            priceForm.ShowDialog();
            this.Close();
        }
    }
}
