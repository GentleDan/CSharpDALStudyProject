namespace ReinforcedConcreteFactoryView
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinforcedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOrderFactoryGridView = new System.Windows.Forms.DataGridView();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.submitExecutionButton = new System.Windows.Forms.Button();
            this.orderReadyButton = new System.Windows.Forms.Button();
            this.orderPaidButton = new System.Windows.Forms.Button();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderFactoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialsToolStripMenuItem,
            this.reinforcedToolStripMenuItem});
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.referencesToolStripMenuItem.Text = "Справочники";
            // 
            // materialsToolStripMenuItem
            // 
            this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            this.materialsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.materialsToolStripMenuItem.Text = "Материалы";
            this.materialsToolStripMenuItem.Click += new System.EventHandler(this.materialsToolStripMenuItem_Click);
            // 
            // reinforcedToolStripMenuItem
            // 
            this.reinforcedToolStripMenuItem.Name = "reinforcedToolStripMenuItem";
            this.reinforcedToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.reinforcedToolStripMenuItem.Text = "Изделия";
            this.reinforcedToolStripMenuItem.Click += new System.EventHandler(this.reinforcedToolStripMenuItem_Click);
            // 
            // dataOrderFactoryGridView
            // 
            this.dataOrderFactoryGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataOrderFactoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderFactoryGridView.Location = new System.Drawing.Point(0, 27);
            this.dataOrderFactoryGridView.Name = "dataOrderFactoryGridView";
            this.dataOrderFactoryGridView.RowHeadersVisible = false;
            this.dataOrderFactoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrderFactoryGridView.Size = new System.Drawing.Size(630, 424);
            this.dataOrderFactoryGridView.TabIndex = 1;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(653, 47);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(109, 44);
            this.createOrderButton.TabIndex = 2;
            this.createOrderButton.Text = "Создать заказ";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // submitExecutionButton
            // 
            this.submitExecutionButton.Location = new System.Drawing.Point(653, 119);
            this.submitExecutionButton.Name = "submitExecutionButton";
            this.submitExecutionButton.Size = new System.Drawing.Size(109, 44);
            this.submitExecutionButton.TabIndex = 3;
            this.submitExecutionButton.Text = "Отдать на выполнение";
            this.submitExecutionButton.UseVisualStyleBackColor = true;
            this.submitExecutionButton.Click += new System.EventHandler(this.submitExecutionButton_Click);
            // 
            // orderReadyButton
            // 
            this.orderReadyButton.Location = new System.Drawing.Point(653, 196);
            this.orderReadyButton.Name = "orderReadyButton";
            this.orderReadyButton.Size = new System.Drawing.Size(109, 48);
            this.orderReadyButton.TabIndex = 4;
            this.orderReadyButton.Text = "Заказ готов";
            this.orderReadyButton.UseVisualStyleBackColor = true;
            this.orderReadyButton.Click += new System.EventHandler(this.orderReadyButton_Click);
            // 
            // orderPaidButton
            // 
            this.orderPaidButton.Location = new System.Drawing.Point(655, 275);
            this.orderPaidButton.Name = "orderPaidButton";
            this.orderPaidButton.Size = new System.Drawing.Size(107, 47);
            this.orderPaidButton.TabIndex = 5;
            this.orderPaidButton.Text = "Заказ оплачен";
            this.orderPaidButton.UseVisualStyleBackColor = true;
            this.orderPaidButton.Click += new System.EventHandler(this.orderPaidButton_Click);
            // 
            // refreshListButton
            // 
            this.refreshListButton.Location = new System.Drawing.Point(653, 356);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(109, 44);
            this.refreshListButton.TabIndex = 6;
            this.refreshListButton.Text = "Обновить список";
            this.refreshListButton.UseVisualStyleBackColor = true;
            this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 465);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.orderPaidButton);
            this.Controls.Add(this.orderReadyButton);
            this.Controls.Add(this.submitExecutionButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.dataOrderFactoryGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "Завод ЖБИ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderFactoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reinforcedToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataOrderFactoryGridView;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button submitExecutionButton;
        private System.Windows.Forms.Button orderReadyButton;
        private System.Windows.Forms.Button orderPaidButton;
        private System.Windows.Forms.Button refreshListButton;
    }
}