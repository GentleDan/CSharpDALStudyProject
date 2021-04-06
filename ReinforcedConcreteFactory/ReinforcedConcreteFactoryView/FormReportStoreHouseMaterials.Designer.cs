namespace ReinforcedConcreteFactoryView
{
    partial class FormReportStoreHouseMaterials
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
            this.saveExcelButton = new System.Windows.Forms.Button();
            this.storeHouseMaterialsDataGridView = new System.Windows.Forms.DataGridView();
            this.StoreHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseMaterialsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveExcelButton
            // 
            this.saveExcelButton.Location = new System.Drawing.Point(13, 13);
            this.saveExcelButton.Name = "saveExcelButton";
            this.saveExcelButton.Size = new System.Drawing.Size(109, 33);
            this.saveExcelButton.TabIndex = 0;
            this.saveExcelButton.Text = "Сохранить в Excel";
            this.saveExcelButton.UseVisualStyleBackColor = true;
            this.saveExcelButton.Click += new System.EventHandler(this.saveExcelButton_Click);
            // 
            // storeHouseMaterialsDataGridView
            // 
            this.storeHouseMaterialsDataGridView.AllowUserToAddRows = false;
            this.storeHouseMaterialsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.storeHouseMaterialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeHouseMaterialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreHouse,
            this.Material,
            this.Count});
            this.storeHouseMaterialsDataGridView.Location = new System.Drawing.Point(13, 64);
            this.storeHouseMaterialsDataGridView.Name = "storeHouseMaterialsDataGridView";
            this.storeHouseMaterialsDataGridView.RowHeadersVisible = false;
            this.storeHouseMaterialsDataGridView.Size = new System.Drawing.Size(470, 418);
            this.storeHouseMaterialsDataGridView.TabIndex = 1;
            // 
            // StoreHouse
            // 
            this.StoreHouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StoreHouse.HeaderText = "Склад";
            this.StoreHouse.Name = "StoreHouse";
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.HeaderText = "Материал";
            this.Material.Name = "Material";
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // FormReportStoreHouseMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 494);
            this.Controls.Add(this.storeHouseMaterialsDataGridView);
            this.Controls.Add(this.saveExcelButton);
            this.Name = "FormReportStoreHouseMaterials";
            this.Text = "Материалы по складам";
            this.Load += new System.EventHandler(this.FormReportStoreHouseMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeHouseMaterialsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveExcelButton;
        private System.Windows.Forms.DataGridView storeHouseMaterialsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}