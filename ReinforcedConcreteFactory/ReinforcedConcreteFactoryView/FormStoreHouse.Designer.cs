namespace ReinforcedConcreteFactoryView
{
    partial class FormStoreHouse
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
            this.materialsGroupBox = new System.Windows.Forms.GroupBox();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfStoreHouseLabel = new System.Windows.Forms.Label();
            this.nameOfResponsibleLabel = new System.Windows.Forms.Label();
            this.nameOfResponsibleTextBox = new System.Windows.Forms.TextBox();
            this.nameOfStoreHouseTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.materialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialsGroupBox
            // 
            this.materialsGroupBox.Controls.Add(this.materialsDataGridView);
            this.materialsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.materialsGroupBox.Name = "materialsGroupBox";
            this.materialsGroupBox.Size = new System.Drawing.Size(222, 293);
            this.materialsGroupBox.TabIndex = 0;
            this.materialsGroupBox.TabStop = false;
            this.materialsGroupBox.Text = "Материалы";
            // 
            // materialsDataGridView
            // 
            this.materialsDataGridView.AllowUserToAddRows = false;
            this.materialsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.materialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.material,
            this.count});
            this.materialsDataGridView.Location = new System.Drawing.Point(0, 19);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowHeadersVisible = false;
            this.materialsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialsDataGridView.Size = new System.Drawing.Size(211, 265);
            this.materialsDataGridView.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // material
            // 
            this.material.HeaderText = "Материал";
            this.material.Name = "material";
            // 
            // count
            // 
            this.count.HeaderText = "Количество";
            this.count.Name = "count";
            // 
            // nameOfStoreHouseLabel
            // 
            this.nameOfStoreHouseLabel.AutoSize = true;
            this.nameOfStoreHouseLabel.Location = new System.Drawing.Point(250, 120);
            this.nameOfStoreHouseLabel.Name = "nameOfStoreHouseLabel";
            this.nameOfStoreHouseLabel.Size = new System.Drawing.Size(99, 13);
            this.nameOfStoreHouseLabel.TabIndex = 2;
            this.nameOfStoreHouseLabel.Text = "Название склада:";
            // 
            // nameOfResponsibleLabel
            // 
            this.nameOfResponsibleLabel.AutoSize = true;
            this.nameOfResponsibleLabel.Location = new System.Drawing.Point(250, 53);
            this.nameOfResponsibleLabel.Name = "nameOfResponsibleLabel";
            this.nameOfResponsibleLabel.Size = new System.Drawing.Size(120, 13);
            this.nameOfResponsibleLabel.TabIndex = 1;
            this.nameOfResponsibleLabel.Text = "ФИО ответственного:";
            // 
            // nameOfResponsibleTextBox
            // 
            this.nameOfResponsibleTextBox.Location = new System.Drawing.Point(253, 85);
            this.nameOfResponsibleTextBox.Name = "nameOfResponsibleTextBox";
            this.nameOfResponsibleTextBox.Size = new System.Drawing.Size(127, 20);
            this.nameOfResponsibleTextBox.TabIndex = 3;
            // 
            // nameOfStoreHouseTextBox
            // 
            this.nameOfStoreHouseTextBox.Location = new System.Drawing.Point(253, 150);
            this.nameOfStoreHouseTextBox.Name = "nameOfStoreHouseTextBox";
            this.nameOfStoreHouseTextBox.Size = new System.Drawing.Size(127, 20);
            this.nameOfStoreHouseTextBox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(253, 196);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 37);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(253, 259);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(127, 37);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FormStoreHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 326);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.materialsGroupBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameOfResponsibleLabel);
            this.Controls.Add(this.nameOfStoreHouseLabel);
            this.Controls.Add(this.nameOfStoreHouseTextBox);
            this.Controls.Add(this.nameOfResponsibleTextBox);
            this.Name = "FormStoreHouse";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormStoreHouse_Load);
            this.materialsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox materialsGroupBox;
        private System.Windows.Forms.DataGridView materialsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Label nameOfResponsibleLabel;
        private System.Windows.Forms.Label nameOfStoreHouseLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nameOfStoreHouseTextBox;
        private System.Windows.Forms.TextBox nameOfResponsibleTextBox;
    }
}