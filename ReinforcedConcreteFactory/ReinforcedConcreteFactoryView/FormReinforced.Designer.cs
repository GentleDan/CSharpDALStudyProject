namespace ReinforcedConcreteFactoryView
{
    partial class FormReinforced
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
            this.reinforcedNameLabel = new System.Windows.Forms.Label();
            this.reinforcedPriceLabel = new System.Windows.Forms.Label();
            this.reinforcedNameTextBox = new System.Windows.Forms.TextBox();
            this.reinforcedPriceTextBox = new System.Windows.Forms.TextBox();
            this.materialGroupBox = new System.Windows.Forms.GroupBox();
            this.updateMaterialsForReinforcedButton = new System.Windows.Forms.Button();
            this.deleteMaterialsForReinforcedButton = new System.Windows.Forms.Button();
            this.changeMaterialsForReinforcedButton = new System.Windows.Forms.Button();
            this.addMaterialsForReinforcedButton = new System.Windows.Forms.Button();
            this.dataMaterialGridView = new System.Windows.Forms.DataGridView();
            this.materialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveReinforcedButton = new System.Windows.Forms.Button();
            this.cancelReinforcedButton = new System.Windows.Forms.Button();
            this.materialGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterialGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // reinforcedNameLabel
            // 
            this.reinforcedNameLabel.AutoSize = true;
            this.reinforcedNameLabel.Location = new System.Drawing.Point(13, 13);
            this.reinforcedNameLabel.Name = "reinforcedNameLabel";
            this.reinforcedNameLabel.Size = new System.Drawing.Size(60, 13);
            this.reinforcedNameLabel.TabIndex = 0;
            this.reinforcedNameLabel.Text = "Название:";
            // 
            // reinforcedPriceLabel
            // 
            this.reinforcedPriceLabel.AutoSize = true;
            this.reinforcedPriceLabel.Location = new System.Drawing.Point(37, 47);
            this.reinforcedPriceLabel.Name = "reinforcedPriceLabel";
            this.reinforcedPriceLabel.Size = new System.Drawing.Size(36, 13);
            this.reinforcedPriceLabel.TabIndex = 1;
            this.reinforcedPriceLabel.Text = "Цена:";
            // 
            // reinforcedNameTextBox
            // 
            this.reinforcedNameTextBox.Location = new System.Drawing.Point(103, 13);
            this.reinforcedNameTextBox.Name = "reinforcedNameTextBox";
            this.reinforcedNameTextBox.Size = new System.Drawing.Size(143, 20);
            this.reinforcedNameTextBox.TabIndex = 2;
            // 
            // reinforcedPriceTextBox
            // 
            this.reinforcedPriceTextBox.Location = new System.Drawing.Point(103, 47);
            this.reinforcedPriceTextBox.Name = "reinforcedPriceTextBox";
            this.reinforcedPriceTextBox.Size = new System.Drawing.Size(52, 20);
            this.reinforcedPriceTextBox.TabIndex = 3;
            // 
            // materialGroupBox
            // 
            this.materialGroupBox.Controls.Add(this.updateMaterialsForReinforcedButton);
            this.materialGroupBox.Controls.Add(this.deleteMaterialsForReinforcedButton);
            this.materialGroupBox.Controls.Add(this.changeMaterialsForReinforcedButton);
            this.materialGroupBox.Controls.Add(this.addMaterialsForReinforcedButton);
            this.materialGroupBox.Controls.Add(this.dataMaterialGridView);
            this.materialGroupBox.Location = new System.Drawing.Point(16, 95);
            this.materialGroupBox.Name = "materialGroupBox";
            this.materialGroupBox.Size = new System.Drawing.Size(755, 292);
            this.materialGroupBox.TabIndex = 4;
            this.materialGroupBox.TabStop = false;
            this.materialGroupBox.Text = "Материалы";
            // 
            // updateMaterialsForReinforcedButton
            // 
            this.updateMaterialsForReinforcedButton.Location = new System.Drawing.Point(628, 231);
            this.updateMaterialsForReinforcedButton.Name = "updateMaterialsForReinforcedButton";
            this.updateMaterialsForReinforcedButton.Size = new System.Drawing.Size(85, 43);
            this.updateMaterialsForReinforcedButton.TabIndex = 4;
            this.updateMaterialsForReinforcedButton.Text = "Обновить";
            this.updateMaterialsForReinforcedButton.UseVisualStyleBackColor = true;
            this.updateMaterialsForReinforcedButton.Click += new System.EventHandler(this.updateMaterialsForReinforcedButton_Click);
            // 
            // deleteMaterialsForReinforcedButton
            // 
            this.deleteMaterialsForReinforcedButton.Location = new System.Drawing.Point(628, 157);
            this.deleteMaterialsForReinforcedButton.Name = "deleteMaterialsForReinforcedButton";
            this.deleteMaterialsForReinforcedButton.Size = new System.Drawing.Size(85, 47);
            this.deleteMaterialsForReinforcedButton.TabIndex = 3;
            this.deleteMaterialsForReinforcedButton.Text = "Удалить";
            this.deleteMaterialsForReinforcedButton.UseVisualStyleBackColor = true;
            this.deleteMaterialsForReinforcedButton.Click += new System.EventHandler(this.deleteMaterialsForReinforcedButton_Click);
            // 
            // changeMaterialsForReinforcedButton
            // 
            this.changeMaterialsForReinforcedButton.Location = new System.Drawing.Point(628, 91);
            this.changeMaterialsForReinforcedButton.Name = "changeMaterialsForReinforcedButton";
            this.changeMaterialsForReinforcedButton.Size = new System.Drawing.Size(85, 44);
            this.changeMaterialsForReinforcedButton.TabIndex = 2;
            this.changeMaterialsForReinforcedButton.Text = "Изменить";
            this.changeMaterialsForReinforcedButton.UseVisualStyleBackColor = true;
            this.changeMaterialsForReinforcedButton.Click += new System.EventHandler(this.changeMaterialsForReinforcedButton_Click);
            // 
            // addMaterialsForReinforcedButton
            // 
            this.addMaterialsForReinforcedButton.Location = new System.Drawing.Point(628, 19);
            this.addMaterialsForReinforcedButton.Name = "addMaterialsForReinforcedButton";
            this.addMaterialsForReinforcedButton.Size = new System.Drawing.Size(85, 43);
            this.addMaterialsForReinforcedButton.TabIndex = 1;
            this.addMaterialsForReinforcedButton.Text = "Добавить";
            this.addMaterialsForReinforcedButton.UseVisualStyleBackColor = true;
            this.addMaterialsForReinforcedButton.Click += new System.EventHandler(this.addMaterialsForReinforcedButton_Click);
            // 
            // dataMaterialGridView
            // 
            this.dataMaterialGridView.AllowUserToAddRows = false;
            this.dataMaterialGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataMaterialGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaterialGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialId,
            this.materialName,
            this.countMaterial});
            this.dataMaterialGridView.Location = new System.Drawing.Point(7, 19);
            this.dataMaterialGridView.Name = "dataMaterialGridView";
            this.dataMaterialGridView.RowHeadersVisible = false;
            this.dataMaterialGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMaterialGridView.Size = new System.Drawing.Size(530, 267);
            this.dataMaterialGridView.TabIndex = 0;
            // 
            // materialId
            // 
            this.materialId.FillWeight = 5F;
            this.materialId.HeaderText = "Id";
            this.materialId.Name = "materialId";
            this.materialId.Visible = false;
            this.materialId.Width = 5;
            // 
            // materialName
            // 
            this.materialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.materialName.FillWeight = 70F;
            this.materialName.HeaderText = "Материал";
            this.materialName.Name = "materialName";
            // 
            // countMaterial
            // 
            this.countMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countMaterial.FillWeight = 30F;
            this.countMaterial.HeaderText = "Количество";
            this.countMaterial.Name = "countMaterial";
            // 
            // saveReinforcedButton
            // 
            this.saveReinforcedButton.Location = new System.Drawing.Point(553, 395);
            this.saveReinforcedButton.Name = "saveReinforcedButton";
            this.saveReinforcedButton.Size = new System.Drawing.Size(85, 43);
            this.saveReinforcedButton.TabIndex = 5;
            this.saveReinforcedButton.Text = "Сохранить";
            this.saveReinforcedButton.UseVisualStyleBackColor = true;
            this.saveReinforcedButton.Click += new System.EventHandler(this.saveReinforcedButton_Click);
            // 
            // cancelReinforcedButton
            // 
            this.cancelReinforcedButton.Location = new System.Drawing.Point(644, 395);
            this.cancelReinforcedButton.Name = "cancelReinforcedButton";
            this.cancelReinforcedButton.Size = new System.Drawing.Size(85, 43);
            this.cancelReinforcedButton.TabIndex = 6;
            this.cancelReinforcedButton.Text = "Отмена";
            this.cancelReinforcedButton.UseVisualStyleBackColor = true;
            this.cancelReinforcedButton.Click += new System.EventHandler(this.cancelReinforcedButton_Click);
            // 
            // FormReinforced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelReinforcedButton);
            this.Controls.Add(this.saveReinforcedButton);
            this.Controls.Add(this.materialGroupBox);
            this.Controls.Add(this.reinforcedPriceTextBox);
            this.Controls.Add(this.reinforcedNameTextBox);
            this.Controls.Add(this.reinforcedPriceLabel);
            this.Controls.Add(this.reinforcedNameLabel);
            this.Name = "FormReinforced";
            this.Text = "Изделие";
            this.Load += new System.EventHandler(this.FormReinforced_Load);
            this.materialGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterialGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reinforcedNameLabel;
        private System.Windows.Forms.Label reinforcedPriceLabel;
        private System.Windows.Forms.TextBox reinforcedNameTextBox;
        private System.Windows.Forms.TextBox reinforcedPriceTextBox;
        private System.Windows.Forms.GroupBox materialGroupBox;
        private System.Windows.Forms.DataGridView dataMaterialGridView;
        private System.Windows.Forms.Button updateMaterialsForReinforcedButton;
        private System.Windows.Forms.Button deleteMaterialsForReinforcedButton;
        private System.Windows.Forms.Button changeMaterialsForReinforcedButton;
        private System.Windows.Forms.Button addMaterialsForReinforcedButton;
        private System.Windows.Forms.Button saveReinforcedButton;
        private System.Windows.Forms.Button cancelReinforcedButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn countMaterial;
    }
}