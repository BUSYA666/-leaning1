namespace Сleaning
{
    partial class MainForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ServicesList = new System.Windows.Forms.ComboBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.PriceButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.Cyan;
            this.mainPanel.Controls.Add(this.ServicesList);
            this.mainPanel.Controls.Add(this.OrderButton);
            this.mainPanel.Controls.Add(this.PriceButton);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Location = new System.Drawing.Point(0, -1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(298, 326);
            this.mainPanel.TabIndex = 1;
            // 
            // ServicesList
            // 
            this.ServicesList.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ServicesList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ServicesList.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ServicesList.FormattingEnabled = true;
            this.ServicesList.Items.AddRange(new object[] {
            "Генеральная уборка",
            "Уборка после ремонта",
            "Уборка офисов",
            "Чистка ковров",
            "Мойка окон",
            "Уборка после праздников или мероприятий",
            "Уход за мебелью и обивкой",
            "Сезонная уборка"});
            this.ServicesList.Location = new System.Drawing.Point(59, 103);
            this.ServicesList.Name = "ServicesList";
            this.ServicesList.Size = new System.Drawing.Size(154, 31);
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
            this.OrderButton.Location = new System.Drawing.Point(60, 251);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(154, 43);
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
            this.PriceButton.Location = new System.Drawing.Point(60, 159);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(154, 63);
            this.PriceButton.TabIndex = 7;
            this.PriceButton.Text = "Рассчитать стоимость услуги";
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
            this.panel2.Size = new System.Drawing.Size(295, 80);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(274, 3);
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
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главный экран";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 323);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.ComboBox ServicesList;
        private System.Windows.Forms.Button OrderButton;
    }
}