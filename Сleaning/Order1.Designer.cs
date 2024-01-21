namespace Сleaning
{
    partial class Order1
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
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.PraceField = new System.Windows.Forms.Label();
            this.SquareBox = new System.Windows.Forms.TextBox();
            this.TotalPriceField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ServicesList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderTable
            // 
            this.OrderTable.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Location = new System.Drawing.Point(47, 86);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.Size = new System.Drawing.Size(445, 289);
            this.OrderTable.TabIndex = 14;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.Cyan;
            this.mainPanel.Controls.Add(this.button3);
            this.mainPanel.Controls.Add(this.FullNameBox);
            this.mainPanel.Controls.Add(this.AddressBox);
            this.mainPanel.Controls.Add(this.PraceField);
            this.mainPanel.Controls.Add(this.SquareBox);
            this.mainPanel.Controls.Add(this.TotalPriceField);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.ServicesList);
            this.mainPanel.Controls.Add(this.OrderTable);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.totalPriceLabel);
            this.mainPanel.Controls.Add(this.OrderButton);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(805, 492);
            this.mainPanel.TabIndex = 3;
            // 
            // PraceField
            // 
            this.PraceField.AutoSize = true;
            this.PraceField.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PraceField.Location = new System.Drawing.Point(717, 90);
            this.PraceField.Name = "PraceField";
            this.PraceField.Size = new System.Drawing.Size(73, 23);
            this.PraceField.TabIndex = 21;
            this.PraceField.Text = "         ";
            // 
            // SquareBox
            // 
            this.SquareBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SquareBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.SquareBox.ForeColor = System.Drawing.Color.Gray;
            this.SquareBox.Location = new System.Drawing.Point(517, 277);
            this.SquareBox.Multiline = true;
            this.SquareBox.Name = "SquareBox";
            this.SquareBox.Size = new System.Drawing.Size(187, 29);
            this.SquareBox.TabIndex = 20;
            this.SquareBox.Enter += new System.EventHandler(this.SquareBox_Enter);
            this.SquareBox.Leave += new System.EventHandler(this.SquareBox_Leave);
            // 
            // TotalPriceField
            // 
            this.TotalPriceField.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TotalPriceField.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TotalPriceField.Location = new System.Drawing.Point(517, 342);
            this.TotalPriceField.Multiline = true;
            this.TotalPriceField.Name = "TotalPriceField";
            this.TotalPriceField.Size = new System.Drawing.Size(187, 29);
            this.TotalPriceField.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(31, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 60);
            this.button2.TabIndex = 18;
            this.button2.Text = "Рассчитать стоимоть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ServicesList
            // 
            this.ServicesList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ServicesList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ServicesList.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ServicesList.FormattingEnabled = true;
            this.ServicesList.Location = new System.Drawing.Point(517, 86);
            this.ServicesList.Name = "ServicesList";
            this.ServicesList.Size = new System.Drawing.Size(187, 31);
            this.ServicesList.TabIndex = 17;
            this.ServicesList.Text = "Услуги";
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
            this.button1.Location = new System.Drawing.Point(419, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.totalPriceLabel.Location = new System.Drawing.Point(300, 109);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(0, 23);
            this.totalPriceLabel.TabIndex = 12;
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
            this.OrderButton.Location = new System.Drawing.Point(617, 403);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(154, 60);
            this.OrderButton.TabIndex = 8;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 80);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(787, 0);
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
            this.label1.Location = new System.Drawing.Point(337, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказ";
            // 
            // FullNameBox
            // 
            this.FullNameBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FullNameBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.FullNameBox.Location = new System.Drawing.Point(517, 142);
            this.FullNameBox.Multiline = true;
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(187, 29);
            this.FullNameBox.TabIndex = 23;
            this.FullNameBox.Enter += new System.EventHandler(this.FullNameBox_Enter);
            this.FullNameBox.Leave += new System.EventHandler(this.FullNameBox_Leave);
            // 
            // AddressBox
            // 
            this.AddressBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddressBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.AddressBox.Location = new System.Drawing.Point(517, 207);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(187, 29);
            this.AddressBox.TabIndex = 22;
            this.AddressBox.Enter += new System.EventHandler(this.AddressBox_Enter);
            this.AddressBox.Leave += new System.EventHandler(this.AddressBox_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(216, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 60);
            this.button3.TabIndex = 24;
            this.button3.Text = "Удалить заказ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Order1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 492);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order1";
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServicesList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SquareBox;
        private System.Windows.Forms.TextBox TotalPriceField;
        private System.Windows.Forms.Label PraceField;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Button button3;
    }
}