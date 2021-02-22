namespace ReinforcedConcreteFactoryView
{
    partial class FormMaterials
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
            this.dataMaterialsGridView = new System.Windows.Forms.DataGridView();
            this.addMaterialsButton = new System.Windows.Forms.Button();
            this.updateMaterialsButton = new System.Windows.Forms.Button();
            this.deleteMaterialsButton = new System.Windows.Forms.Button();
            this.refreshMaterialsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterialsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMaterialsGridView
            // 
            this.dataMaterialsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataMaterialsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMaterialsGridView.Location = new System.Drawing.Point(2, 2);
            this.dataMaterialsGridView.Name = "dataMaterialsGridView";
            this.dataMaterialsGridView.RowHeadersVisible = false;
            this.dataMaterialsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMaterialsGridView.Size = new System.Drawing.Size(373, 434);
            this.dataMaterialsGridView.TabIndex = 0;
            // 
            // addMaterialsButton
            // 
            this.addMaterialsButton.Location = new System.Drawing.Point(410, 58);
            this.addMaterialsButton.Name = "addMaterialsButton";
            this.addMaterialsButton.Size = new System.Drawing.Size(109, 45);
            this.addMaterialsButton.TabIndex = 1;
            this.addMaterialsButton.Text = "Добавить";
            this.addMaterialsButton.UseVisualStyleBackColor = true;
            this.addMaterialsButton.Click += new System.EventHandler(this.addMaterialsButton_Click);
            // 
            // updateMaterialsButton
            // 
            this.updateMaterialsButton.Location = new System.Drawing.Point(410, 134);
            this.updateMaterialsButton.Name = "updateMaterialsButton";
            this.updateMaterialsButton.Size = new System.Drawing.Size(109, 45);
            this.updateMaterialsButton.TabIndex = 2;
            this.updateMaterialsButton.Text = "Изменить";
            this.updateMaterialsButton.UseVisualStyleBackColor = true;
            this.updateMaterialsButton.Click += new System.EventHandler(this.updateMaterialsButton_Click);
            // 
            // deleteMaterialsButton
            // 
            this.deleteMaterialsButton.Location = new System.Drawing.Point(410, 212);
            this.deleteMaterialsButton.Name = "deleteMaterialsButton";
            this.deleteMaterialsButton.Size = new System.Drawing.Size(109, 45);
            this.deleteMaterialsButton.TabIndex = 3;
            this.deleteMaterialsButton.Text = "Удалить";
            this.deleteMaterialsButton.UseVisualStyleBackColor = true;
            this.deleteMaterialsButton.Click += new System.EventHandler(this.deleteMaterialsButton_Click);
            // 
            // refreshMaterialsButton
            // 
            this.refreshMaterialsButton.Location = new System.Drawing.Point(410, 294);
            this.refreshMaterialsButton.Name = "refreshMaterialsButton";
            this.refreshMaterialsButton.Size = new System.Drawing.Size(109, 46);
            this.refreshMaterialsButton.TabIndex = 4;
            this.refreshMaterialsButton.Text = "Обновить";
            this.refreshMaterialsButton.UseVisualStyleBackColor = true;
            this.refreshMaterialsButton.Click += new System.EventHandler(this.refreshMaterialsButton_Click);
            // 
            // FormMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 445);
            this.Controls.Add(this.refreshMaterialsButton);
            this.Controls.Add(this.deleteMaterialsButton);
            this.Controls.Add(this.updateMaterialsButton);
            this.Controls.Add(this.addMaterialsButton);
            this.Controls.Add(this.dataMaterialsGridView);
            this.Name = "FormMaterials";
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.FormMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMaterialsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMaterialsGridView;
        private System.Windows.Forms.Button addMaterialsButton;
        private System.Windows.Forms.Button updateMaterialsButton;
        private System.Windows.Forms.Button deleteMaterialsButton;
        private System.Windows.Forms.Button refreshMaterialsButton;
    }
}