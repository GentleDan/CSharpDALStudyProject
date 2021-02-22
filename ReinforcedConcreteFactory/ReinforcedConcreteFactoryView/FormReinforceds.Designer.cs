namespace ReinforcedConcreteFactoryView
{
    partial class FormReinforceds
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
            this.dataReinforcedsGridView = new System.Windows.Forms.DataGridView();
            this.addReinforcedsButton = new System.Windows.Forms.Button();
            this.updateReinforcedsButton = new System.Windows.Forms.Button();
            this.deleteReinforcedsButton = new System.Windows.Forms.Button();
            this.refreshReinforcedsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataReinforcedsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReinforcedsGridView
            // 
            this.dataReinforcedsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataReinforcedsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReinforcedsGridView.Location = new System.Drawing.Point(2, 5);
            this.dataReinforcedsGridView.Name = "dataReinforcedsGridView";
            this.dataReinforcedsGridView.RowHeadersVisible = false;
            this.dataReinforcedsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataReinforcedsGridView.Size = new System.Drawing.Size(305, 455);
            this.dataReinforcedsGridView.TabIndex = 0;
            // 
            // addReinforcedsButton
            // 
            this.addReinforcedsButton.Location = new System.Drawing.Point(335, 77);
            this.addReinforcedsButton.Name = "addReinforcedsButton";
            this.addReinforcedsButton.Size = new System.Drawing.Size(114, 39);
            this.addReinforcedsButton.TabIndex = 1;
            this.addReinforcedsButton.Text = "Добавить";
            this.addReinforcedsButton.UseVisualStyleBackColor = true;
            this.addReinforcedsButton.Click += new System.EventHandler(this.addReinforcedsButton_Click);
            // 
            // updateReinforcedsButton
            // 
            this.updateReinforcedsButton.Location = new System.Drawing.Point(335, 162);
            this.updateReinforcedsButton.Name = "updateReinforcedsButton";
            this.updateReinforcedsButton.Size = new System.Drawing.Size(114, 40);
            this.updateReinforcedsButton.TabIndex = 2;
            this.updateReinforcedsButton.Text = "Изменить";
            this.updateReinforcedsButton.UseVisualStyleBackColor = true;
            this.updateReinforcedsButton.Click += new System.EventHandler(this.updateReinforcedsButton_Click);
            // 
            // deleteReinforcedsButton
            // 
            this.deleteReinforcedsButton.Location = new System.Drawing.Point(335, 245);
            this.deleteReinforcedsButton.Name = "deleteReinforcedsButton";
            this.deleteReinforcedsButton.Size = new System.Drawing.Size(114, 41);
            this.deleteReinforcedsButton.TabIndex = 3;
            this.deleteReinforcedsButton.Text = "Удалить";
            this.deleteReinforcedsButton.UseVisualStyleBackColor = true;
            this.deleteReinforcedsButton.Click += new System.EventHandler(this.deleteReinforcedsButton_Click);
            // 
            // refreshReinforcedsButton
            // 
            this.refreshReinforcedsButton.Location = new System.Drawing.Point(335, 331);
            this.refreshReinforcedsButton.Name = "refreshReinforcedsButton";
            this.refreshReinforcedsButton.Size = new System.Drawing.Size(114, 40);
            this.refreshReinforcedsButton.TabIndex = 4;
            this.refreshReinforcedsButton.Text = "Обновить";
            this.refreshReinforcedsButton.UseVisualStyleBackColor = true;
            this.refreshReinforcedsButton.Click += new System.EventHandler(this.refreshReinforcedsButton_Click);
            // 
            // FormReinforceds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 474);
            this.Controls.Add(this.refreshReinforcedsButton);
            this.Controls.Add(this.deleteReinforcedsButton);
            this.Controls.Add(this.updateReinforcedsButton);
            this.Controls.Add(this.addReinforcedsButton);
            this.Controls.Add(this.dataReinforcedsGridView);
            this.Name = "FormReinforceds";
            this.Text = "Изделия";
            this.Load += new System.EventHandler(this.FormReinforceds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReinforcedsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataReinforcedsGridView;
        private System.Windows.Forms.Button addReinforcedsButton;
        private System.Windows.Forms.Button updateReinforcedsButton;
        private System.Windows.Forms.Button deleteReinforcedsButton;
        private System.Windows.Forms.Button refreshReinforcedsButton;
    }
}