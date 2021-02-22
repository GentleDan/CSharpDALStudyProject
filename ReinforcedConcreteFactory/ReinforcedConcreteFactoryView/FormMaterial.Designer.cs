namespace ReinforcedConcreteFactoryView
{
    partial class FormMaterial
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
            this.materialName = new System.Windows.Forms.Label();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.saveMaterialButton = new System.Windows.Forms.Button();
            this.cancelMaterialButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialName
            // 
            this.materialName.AutoSize = true;
            this.materialName.Location = new System.Drawing.Point(37, 55);
            this.materialName.Name = "materialName";
            this.materialName.Size = new System.Drawing.Size(60, 13);
            this.materialName.TabIndex = 0;
            this.materialName.Text = "Название:";
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(103, 52);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(345, 20);
            this.materialTextBox.TabIndex = 1;
            // 
            // saveMaterialButton
            // 
            this.saveMaterialButton.Location = new System.Drawing.Point(267, 90);
            this.saveMaterialButton.Name = "saveMaterialButton";
            this.saveMaterialButton.Size = new System.Drawing.Size(90, 34);
            this.saveMaterialButton.TabIndex = 2;
            this.saveMaterialButton.Text = "Сохранить";
            this.saveMaterialButton.UseVisualStyleBackColor = true;
            this.saveMaterialButton.Click += new System.EventHandler(this.saveMaterialButton_Click);
            // 
            // cancelMaterialButton
            // 
            this.cancelMaterialButton.Location = new System.Drawing.Point(363, 90);
            this.cancelMaterialButton.Name = "cancelMaterialButton";
            this.cancelMaterialButton.Size = new System.Drawing.Size(85, 34);
            this.cancelMaterialButton.TabIndex = 3;
            this.cancelMaterialButton.Text = "Отмена";
            this.cancelMaterialButton.UseVisualStyleBackColor = true;
            this.cancelMaterialButton.Click += new System.EventHandler(this.cancelMaterialButton_Click);
            // 
            // FormMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 136);
            this.Controls.Add(this.cancelMaterialButton);
            this.Controls.Add(this.saveMaterialButton);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.materialName);
            this.Name = "FormMaterial";
            this.Text = "Материал";
            this.Load += new System.EventHandler(this.FormMaterial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label materialName;
        private System.Windows.Forms.TextBox materialTextBox;
        private System.Windows.Forms.Button saveMaterialButton;
        private System.Windows.Forms.Button cancelMaterialButton;
    }
}