namespace WinFormUI.Reports {
    partial class Reports {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.ProizvodVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NarudzbaVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogoviVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KorisnikVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DojamVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProizvodVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarudzbaVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoviVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikVMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DojamVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProizvodVMBindingSource
            // 
            this.ProizvodVMBindingSource.DataSource = typeof(WebAPI.ViewModels.ProizvodVM);
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsMetroDojmovi";
            reportDataSource1.Value = this.DojamVMBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportMetroDojmovi.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(494, 339);
            this.reportViewer.TabIndex = 0;
            // 
            // NarudzbaVMBindingSource
            // 
            this.NarudzbaVMBindingSource.DataSource = typeof(WebAPI.ViewModels.NarudzbaVM);
            // 
            // LogoviVMBindingSource
            // 
            this.LogoviVMBindingSource.DataSource = typeof(WebAPI.ViewModels.LogoviVM);
            // 
            // KorisnikVMBindingSource
            // 
            this.KorisnikVMBindingSource.DataSource = typeof(WebAPI.ViewModels.KorisnikVM);
            // 
            // DojamVMBindingSource
            // 
            this.DojamVMBindingSource.DataSource = typeof(WebAPI.ViewModels.DojamVM);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 339);
            this.Controls.Add(this.reportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Text = "BASis Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProizvodVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NarudzbaVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoviVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KorisnikVMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DojamVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource ProizvodVMBindingSource;
        private System.Windows.Forms.BindingSource NarudzbaVMBindingSource;
        private System.Windows.Forms.BindingSource LogoviVMBindingSource;
        private System.Windows.Forms.BindingSource KorisnikVMBindingSource;
        private System.Windows.Forms.BindingSource DojamVMBindingSource;
    }
}