namespace ReinforcedConcreteFactoryView
{
    partial class FormReportOrders
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
            this.reportPanel = new System.Windows.Forms.Panel();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.createReportButton = new System.Windows.Forms.Button();
            this.createReportPDFButton = new System.Windows.Forms.Button();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.reportViewerOrders = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.createReportPDFButton);
            this.reportPanel.Controls.Add(this.createReportButton);
            this.reportPanel.Controls.Add(this.dateTimePickerTo);
            this.reportPanel.Controls.Add(this.labelTo);
            this.reportPanel.Controls.Add(this.dateTimePickerFrom);
            this.reportPanel.Controls.Add(this.labelFrom);
            this.reportPanel.Location = new System.Drawing.Point(0, 1);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(800, 38);
            this.reportPanel.TabIndex = 0;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(3, 17);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(14, 13);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "С";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(23, 11);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(169, 17);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 13);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "по";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(194, 11);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(149, 20);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(486, 7);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(112, 23);
            this.createReportButton.TabIndex = 4;
            this.createReportButton.Text = "Сформировать";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // createReportPDFButton
            // 
            this.createReportPDFButton.Location = new System.Drawing.Point(625, 7);
            this.createReportPDFButton.Name = "createReportPDFButton";
            this.createReportPDFButton.Size = new System.Drawing.Size(100, 23);
            this.createReportPDFButton.TabIndex = 5;
            this.createReportPDFButton.Text = "В PDF";
            this.createReportPDFButton.UseVisualStyleBackColor = true;
            this.createReportPDFButton.Click += new System.EventHandler(this.createReportPDFButton_Click);
            // 
            // reportViewerOrders
            // 
            this.reportViewerOrders.LocalReport.ReportEmbeddedResource = "ReinforcedConcreteFactoryView.ReportOrders.rdlc";
            this.reportViewerOrders.Location = new System.Drawing.Point(0, 46);
            this.reportViewerOrders.Name = "reportViewerOrders";
            this.reportViewerOrders.ServerReport.BearerToken = null;
            this.reportViewerOrders.Size = new System.Drawing.Size(800, 404);
            this.reportViewerOrders.TabIndex = 1;
            // 
            // FormReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerOrders);
            this.Controls.Add(this.reportPanel);
            this.Name = "FormReportOrders";
            this.Text = "Заказы клиентов";
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Button createReportPDFButton;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerOrders;
    }
}