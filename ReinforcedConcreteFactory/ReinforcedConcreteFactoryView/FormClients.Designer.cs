namespace ReinforcedConcreteFactoryView
{
    partial class FormClients
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
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AllowUserToAddRows = false;
            this.ClientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGridView.Location = new System.Drawing.Point(3, 2);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.RowHeadersVisible = false;
            this.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsDataGridView.Size = new System.Drawing.Size(380, 454);
            this.ClientsDataGridView.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(409, 210);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 63);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 478);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ClientsDataGridView);
            this.Name = "FormClients";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.FormClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.Button deleteButton;
    }
}