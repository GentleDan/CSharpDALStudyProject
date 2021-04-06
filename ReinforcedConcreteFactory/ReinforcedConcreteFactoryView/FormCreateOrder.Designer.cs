namespace ReinforcedConcreteFactoryView
{
    partial class FormCreateOrder
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
            this.orderReinforcedName = new System.Windows.Forms.Label();
            this.orderReinforcedCountLabel = new System.Windows.Forms.Label();
            this.orderSumLabel = new System.Windows.Forms.Label();
            this.orderReinforcedComboBox = new System.Windows.Forms.ComboBox();
            this.orderReinforcedCountTextBox = new System.Windows.Forms.TextBox();
            this.orderSumTextBox = new System.Windows.Forms.TextBox();
            this.saveOrderButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // orderReinforcedName
            // 
            this.orderReinforcedName.AutoSize = true;
            this.orderReinforcedName.Location = new System.Drawing.Point(33, 73);
            this.orderReinforcedName.Name = "orderReinforcedName";
            this.orderReinforcedName.Size = new System.Drawing.Size(54, 13);
            this.orderReinforcedName.TabIndex = 0;
            this.orderReinforcedName.Text = "Изделие:";
            // 
            // orderReinforcedCountLabel
            // 
            this.orderReinforcedCountLabel.AutoSize = true;
            this.orderReinforcedCountLabel.Location = new System.Drawing.Point(18, 110);
            this.orderReinforcedCountLabel.Name = "orderReinforcedCountLabel";
            this.orderReinforcedCountLabel.Size = new System.Drawing.Size(69, 13);
            this.orderReinforcedCountLabel.TabIndex = 1;
            this.orderReinforcedCountLabel.Text = "Количество:";
            // 
            // orderSumLabel
            // 
            this.orderSumLabel.AutoSize = true;
            this.orderSumLabel.Location = new System.Drawing.Point(43, 147);
            this.orderSumLabel.Name = "orderSumLabel";
            this.orderSumLabel.Size = new System.Drawing.Size(44, 13);
            this.orderSumLabel.TabIndex = 2;
            this.orderSumLabel.Text = "Сумма:";
            // 
            // orderReinforcedComboBox
            // 
            this.orderReinforcedComboBox.FormattingEnabled = true;
            this.orderReinforcedComboBox.Location = new System.Drawing.Point(112, 70);
            this.orderReinforcedComboBox.Name = "orderReinforcedComboBox";
            this.orderReinforcedComboBox.Size = new System.Drawing.Size(167, 21);
            this.orderReinforcedComboBox.TabIndex = 3;
            this.orderReinforcedComboBox.SelectedIndexChanged += new System.EventHandler(this.orderReinforcedComboBox_SelectedIndexChanged);
            // 
            // orderReinforcedCountTextBox
            // 
            this.orderReinforcedCountTextBox.Location = new System.Drawing.Point(112, 107);
            this.orderReinforcedCountTextBox.Name = "orderReinforcedCountTextBox";
            this.orderReinforcedCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderReinforcedCountTextBox.TabIndex = 4;
            this.orderReinforcedCountTextBox.TextChanged += new System.EventHandler(this.orderReinforcedCountTextBox_TextChanged);
            // 
            // orderSumTextBox
            // 
            this.orderSumTextBox.Location = new System.Drawing.Point(112, 144);
            this.orderSumTextBox.Name = "orderSumTextBox";
            this.orderSumTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderSumTextBox.TabIndex = 5;
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Location = new System.Drawing.Point(250, 184);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(75, 34);
            this.saveOrderButton.TabIndex = 6;
            this.saveOrderButton.Text = "Сохранить";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Location = new System.Drawing.Point(331, 184);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(75, 34);
            this.cancelOrderButton.TabIndex = 7;
            this.cancelOrderButton.Text = "Отмена";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(41, 38);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(46, 13);
            this.ClientLabel.TabIndex = 8;
            this.ClientLabel.Text = "Клиент:";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(112, 35);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(167, 21);
            this.comboBoxClient.TabIndex = 9;
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 230);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.orderSumTextBox);
            this.Controls.Add(this.orderReinforcedCountTextBox);
            this.Controls.Add(this.orderReinforcedComboBox);
            this.Controls.Add(this.orderSumLabel);
            this.Controls.Add(this.orderReinforcedCountLabel);
            this.Controls.Add(this.orderReinforcedName);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderReinforcedName;
        private System.Windows.Forms.Label orderReinforcedCountLabel;
        private System.Windows.Forms.Label orderSumLabel;
        private System.Windows.Forms.ComboBox orderReinforcedComboBox;
        private System.Windows.Forms.TextBox orderReinforcedCountTextBox;
        private System.Windows.Forms.TextBox orderSumTextBox;
        private System.Windows.Forms.Button saveOrderButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.ComboBox comboBoxClient;
    }
}