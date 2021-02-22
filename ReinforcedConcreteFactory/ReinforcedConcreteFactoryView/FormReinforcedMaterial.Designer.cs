namespace ReinforcedConcreteFactoryView
{
    partial class FormReinforcedMaterial
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
            this.materialNameLabel = new System.Windows.Forms.Label();
            this.countMaterialLabel = new System.Windows.Forms.Label();
            this.materialNameComboBox = new System.Windows.Forms.ComboBox();
            this.countMaterialTextBox = new System.Windows.Forms.TextBox();
            this.saveReinforcedMaterialButton = new System.Windows.Forms.Button();
            this.cancelReinforcedMaterialButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialNameLabel
            // 
            this.materialNameLabel.AutoSize = true;
            this.materialNameLabel.Location = new System.Drawing.Point(81, 58);
            this.materialNameLabel.Name = "materialNameLabel";
            this.materialNameLabel.Size = new System.Drawing.Size(60, 13);
            this.materialNameLabel.TabIndex = 0;
            this.materialNameLabel.Text = "Материал:";
            // 
            // countMaterialLabel
            // 
            this.countMaterialLabel.AutoSize = true;
            this.countMaterialLabel.Location = new System.Drawing.Point(72, 110);
            this.countMaterialLabel.Name = "countMaterialLabel";
            this.countMaterialLabel.Size = new System.Drawing.Size(69, 13);
            this.countMaterialLabel.TabIndex = 1;
            this.countMaterialLabel.Text = "Количество:";
            // 
            // materialNameComboBox
            // 
            this.materialNameComboBox.FormattingEnabled = true;
            this.materialNameComboBox.Location = new System.Drawing.Point(171, 55);
            this.materialNameComboBox.Name = "materialNameComboBox";
            this.materialNameComboBox.Size = new System.Drawing.Size(195, 21);
            this.materialNameComboBox.TabIndex = 2;
            // 
            // countMaterialTextBox
            // 
            this.countMaterialTextBox.Location = new System.Drawing.Point(171, 107);
            this.countMaterialTextBox.Name = "countMaterialTextBox";
            this.countMaterialTextBox.Size = new System.Drawing.Size(195, 20);
            this.countMaterialTextBox.TabIndex = 3;
            // 
            // saveReinforcedMaterialButton
            // 
            this.saveReinforcedMaterialButton.Location = new System.Drawing.Point(188, 146);
            this.saveReinforcedMaterialButton.Name = "saveReinforcedMaterialButton";
            this.saveReinforcedMaterialButton.Size = new System.Drawing.Size(86, 37);
            this.saveReinforcedMaterialButton.TabIndex = 4;
            this.saveReinforcedMaterialButton.Text = "Сохранить";
            this.saveReinforcedMaterialButton.UseVisualStyleBackColor = true;
            this.saveReinforcedMaterialButton.Click += new System.EventHandler(this.saveReinforcedMaterialButton_Click);
            // 
            // cancelReinforcedMaterialButton
            // 
            this.cancelReinforcedMaterialButton.Location = new System.Drawing.Point(280, 146);
            this.cancelReinforcedMaterialButton.Name = "cancelReinforcedMaterialButton";
            this.cancelReinforcedMaterialButton.Size = new System.Drawing.Size(86, 37);
            this.cancelReinforcedMaterialButton.TabIndex = 5;
            this.cancelReinforcedMaterialButton.Text = "Отмена";
            this.cancelReinforcedMaterialButton.UseVisualStyleBackColor = true;
            this.cancelReinforcedMaterialButton.Click += new System.EventHandler(this.cancelReinforcedMaterialButton_Click);
            // 
            // FormReinforcedMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 219);
            this.Controls.Add(this.cancelReinforcedMaterialButton);
            this.Controls.Add(this.saveReinforcedMaterialButton);
            this.Controls.Add(this.countMaterialTextBox);
            this.Controls.Add(this.materialNameComboBox);
            this.Controls.Add(this.countMaterialLabel);
            this.Controls.Add(this.materialNameLabel);
            this.Name = "FormReinforcedMaterial";
            this.Text = "Материалы изделия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label materialNameLabel;
        private System.Windows.Forms.Label countMaterialLabel;
        private System.Windows.Forms.ComboBox materialNameComboBox;
        private System.Windows.Forms.TextBox countMaterialTextBox;
        private System.Windows.Forms.Button saveReinforcedMaterialButton;
        private System.Windows.Forms.Button cancelReinforcedMaterialButton;
    }
}