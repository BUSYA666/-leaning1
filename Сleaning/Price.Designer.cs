namespace Cleaning
{
    partial class Price
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Square = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SquareBox = new System.Windows.Forms.TextBox();
            this.PraceField = new System.Windows.Forms.Label();
            this.TotalPriceField = new System.Windows.Forms.TextBox();
            this.ServicesList = new System.Windows.Forms.ComboBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.PriceButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Square.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.BackColor = System.Drawing.Color.Cyan;
            this.Square.Controls.Add(this.button1);
            this.Square.Controls.Add(this.SquareBox);
            this.Square.Controls.Add(this.PraceField);
            this.Square.Controls.Add(this.TotalPriceField);
            this.Square.Controls.Add(this.ServicesList);
            this.Square.Controls.Add(this.OrderButton);
            this.Square.Controls.Add(this.PriceButton);
            this.Square.Controls.Add(this.panel2);
            this.Square.Location = new System.Drawing.Point(1, 3);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(538, 326);
            this.Square.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(202, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SquareBox
            // 
            this.SquareBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SquareBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.SquareBox.Location = new System.Drawing.Point(337, 97);
            this.SquareBox.Multiline = true;
            this.SquareBox.Name = "SquareBox";
            this.SquareBox.Size = new System.Drawing.Size(154, 31);
            this.SquareBox.TabIndex = 14;
            this.SquareBox.Enter += new System.EventHandler(this.SquareBox_Enter);
            this.SquareBox.Leave += new System.EventHandler(this.SquareBox_Leave);
            // 
            // PraceField
            // 
            this.PraceField.AutoSize = true;
            this.PraceField.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PraceField.Location = new System.Drawing.Point(213, 100);
            this.PraceField.Name = "PraceField";
            this.PraceField.Size = new System.Drawing.Size(59, 23);
            this.PraceField.TabIndex = 13;
            this.PraceField.Text = "       ";
            // 
            // TotalPriceField
            // 
            this.TotalPriceField.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TotalPriceField.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TotalPriceField.Location = new System.Drawing.Point(337, 172);
            this.TotalPriceField.Multiline = true;
            this.TotalPriceField.Name = "TotalPriceField";
            this.TotalPriceField.Size = new System.Drawing.Size(154, 31);
            this.TotalPriceField.TabIndex = 12;
            // 
            // ServicesList
            // 
            this.ServicesList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ServicesList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ServicesList.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ServicesList.FormattingEnabled = true;
            this.ServicesList.Location = new System.Drawing.Point(20, 97);
            this.ServicesList.Name = "ServicesList";
            this.ServicesList.Size = new System.Drawing.Size(187, 31);
            this.ServicesList.TabIndex = 9;
            this.ServicesList.Text = "Услуги";
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.OrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.OrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(20, 247);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(164, 43);
            this.OrderButton.TabIndex = 8;
            this.OrderButton.Text = "Заказ";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // PriceButton
            // 
            this.PriceButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PriceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PriceButton.FlatAppearance.BorderSize = 0;
            this.PriceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.PriceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.PriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriceButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceButton.Location = new System.Drawing.Point(337, 239);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(154, 58);
            this.PriceButton.TabIndex = 7;
            this.PriceButton.Text = "Рассчитать стоимость ";
            this.PriceButton.UseVisualStyleBackColor = false;
            this.PriceButton.Click += new System.EventHandler(this.PriceButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 80);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(520, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 19);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(187, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рассчет";
            // 
            // Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 327);
            this.Controls.Add(this.Square);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price";
            this.Square.ResumeLayout(false);
            this.Square.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Square;
        private System.Windows.Forms.ComboBox ServicesList;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalPriceField;
        private System.Windows.Forms.Label PraceField;
        private System.Windows.Forms.TextBox SquareBox;
        private System.Windows.Forms.Button button1;
    }
}