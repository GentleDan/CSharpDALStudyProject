namespace ReinforcedConcreteFactoryView
{
    partial class FormStoreHouses
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
            this.storehousesDataGridView = new System.Windows.Forms.DataGridView();
            this.addStoreHouseButton = new System.Windows.Forms.Button();
            this.changeStoreHouseButton = new System.Windows.Forms.Button();
            this.deleteStoreHouseButton = new System.Windows.Forms.Button();
            this.updateStoreHouseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storehousesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // storehousesDataGridView
            // 
            this.storehousesDataGridView.AllowUserToAddRows = false;
            this.storehousesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.storehousesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storehousesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.storehousesDataGridView.Name = "storehousesDataGridView";
            this.storehousesDataGridView.RowHeadersVisible = false;
            this.storehousesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storehousesDataGridView.Size = new System.Drawing.Size(378, 271);
            this.storehousesDataGridView.TabIndex = 0;
            // 
            // addStoreHouseButton
            // 
            this.addStoreHouseButton.Location = new System.Drawing.Point(439, 25);
            this.addStoreHouseButton.Name = "addStoreHouseButton";
            this.addStoreHouseButton.Size = new System.Drawing.Size(132, 43);
            this.addStoreHouseButton.TabIndex = 1;
            this.addStoreHouseButton.Text = "Добавить";
            this.addStoreHouseButton.UseVisualStyleBackColor = true;
            this.addStoreHouseButton.Click += new System.EventHandler(this.addStoreHouseButton_Click);
            // 
            // changeStoreHouseButton
            // 
            this.changeStoreHouseButton.Location = new System.Drawing.Point(439, 97);
            this.changeStoreHouseButton.Name = "changeStoreHouseButton";
            this.changeStoreHouseButton.Size = new System.Drawing.Size(132, 43);
            this.changeStoreHouseButton.TabIndex = 2;
            this.changeStoreHouseButton.Text = "Изменить";
            this.changeStoreHouseButton.UseVisualStyleBackColor = true;
            this.changeStoreHouseButton.Click += new System.EventHandler(this.changeStoreHouseButton_Click);
            // 
            // deleteStoreHouseButton
            // 
            this.deleteStoreHouseButton.Location = new System.Drawing.Point(439, 160);
            this.deleteStoreHouseButton.Name = "deleteStoreHouseButton";
            this.deleteStoreHouseButton.Size = new System.Drawing.Size(132, 43);
            this.deleteStoreHouseButton.TabIndex = 3;
            this.deleteStoreHouseButton.Text = "Удалить";
            this.deleteStoreHouseButton.UseVisualStyleBackColor = true;
            this.deleteStoreHouseButton.Click += new System.EventHandler(this.deleteStoreHouseButton_Click);
            // 
            // updateStoreHouseButton
            // 
            this.updateStoreHouseButton.Location = new System.Drawing.Point(439, 224);
            this.updateStoreHouseButton.Name = "updateStoreHouseButton";
            this.updateStoreHouseButton.Size = new System.Drawing.Size(132, 43);
            this.updateStoreHouseButton.TabIndex = 4;
            this.updateStoreHouseButton.Text = "Обновить";
            this.updateStoreHouseButton.UseVisualStyleBackColor = true;
            this.updateStoreHouseButton.Click += new System.EventHandler(this.updateStoreHouseButton_Click);
            // 
            // FormStoreHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 313);
            this.Controls.Add(this.updateStoreHouseButton);
            this.Controls.Add(this.deleteStoreHouseButton);
            this.Controls.Add(this.changeStoreHouseButton);
            this.Controls.Add(this.addStoreHouseButton);
            this.Controls.Add(this.storehousesDataGridView);
            this.Name = "FormStoreHouses";
            this.Text = "Склады";
            this.Load += new System.EventHandler(this.FormStoreHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storehousesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView storehousesDataGridView;
        private System.Windows.Forms.Button addStoreHouseButton;
        private System.Windows.Forms.Button changeStoreHouseButton;
        private System.Windows.Forms.Button deleteStoreHouseButton;
        private System.Windows.Forms.Button updateStoreHouseButton;
    }
}