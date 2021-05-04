namespace ReinforcedConcreteFactoryView
{
    partial class FormReportOrdersForAllDates
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
            this.components = new System.ComponentModel.Container();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.saveToPdfButton = new System.Windows.Forms.Button();
            this.createOrdersListButton = new System.Windows.Forms.Button();
            this.OrdersReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportOrdersForAllDatesViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportOrdersForAllDatesViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.saveToPdfButton);
            this.reportPanel.Controls.Add(this.createOrdersListButton);
            this.reportPanel.Location = new System.Drawing.Point(12, 13);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(740, 45);
            this.reportPanel.TabIndex = 0;
            // 
            // saveToPdfButton
            // 
            this.saveToPdfButton.Location = new System.Drawing.Point(574, 4);
            this.saveToPdfButton.Name = "saveToPdfButton";
            this.saveToPdfButton.Size = new System.Drawing.Size(163, 38);
            this.saveToPdfButton.TabIndex = 1;
            this.saveToPdfButton.Text = "Сохранить в PDF";
            this.saveToPdfButton.UseVisualStyleBackColor = true;
            this.saveToPdfButton.Click += new System.EventHandler(this.saveToPdfButton_Click);
            // 
            // createOrdersListButton
            // 
            this.createOrdersListButton.Location = new System.Drawing.Point(4, 4);
            this.createOrdersListButton.Name = "createOrdersListButton";
            this.createOrdersListButton.Size = new System.Drawing.Size(130, 38);
            this.createOrdersListButton.TabIndex = 0;
            this.createOrdersListButton.Text = "Сформировать";
            this.createOrdersListButton.UseVisualStyleBackColor = true;
            this.createOrdersListButton.Click += new System.EventHandler(this.createOrdersListButton_Click);
            // 
            // OrdersReportViewer
            // 
            this.OrdersReportViewer.LocalReport.ReportEmbeddedResource = "ReinforcedConcreteFactoryView.ReportOrdersForAllDates.rdlc";
            this.OrdersReportViewer.Location = new System.Drawing.Point(16, 65);
            this.OrdersReportViewer.Name = "OrdersReportViewer";
            this.OrdersReportViewer.ServerReport.BearerToken = null;
            this.OrdersReportViewer.Size = new System.Drawing.Size(736, 360);
            this.OrdersReportViewer.TabIndex = 1;
            // 
            // ReportOrdersForAllDatesViewModelBindingSource
            // 
            this.ReportOrdersForAllDatesViewModelBindingSource.DataMember = "ReportOrdersForAllDatesViewModel";
            // 
            // FormReportOrdersForAllDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 437);
            this.Controls.Add(this.OrdersReportViewer);
            this.Controls.Add(this.reportPanel);
            this.Name = "FormReportOrdersForAllDates";
            this.Text = "Заказы за период";
            this.reportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportOrdersForAllDatesViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Button saveToPdfButton;
        private System.Windows.Forms.Button createOrdersListButton;
        private Microsoft.Reporting.WinForms.ReportViewer OrdersReportViewer;
        private System.Windows.Forms.BindingSource ReportOrdersForAllDatesViewModelBindingSource;
    }
}