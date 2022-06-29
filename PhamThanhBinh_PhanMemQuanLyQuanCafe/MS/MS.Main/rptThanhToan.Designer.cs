namespace MS.Main
{
    partial class RptThanhToan
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
            this.rptXuatHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptXuatHD
            // 
            this.rptXuatHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptXuatHD.LocalReport.ReportEmbeddedResource = "MS.Main.rptThanhToan.rdlc";
            this.rptXuatHD.Location = new System.Drawing.Point(0, 0);
            this.rptXuatHD.Name = "rptXuatHD";
            this.rptXuatHD.ServerReport.BearerToken = null;
            this.rptXuatHD.Size = new System.Drawing.Size(379, 549);
            this.rptXuatHD.TabIndex = 0;
            // 
            // RptThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 549);
            this.Controls.Add(this.rptXuatHD);
            this.Name = "RptThanhToan";
            this.Load += new System.EventHandler(this.reportThanhToan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptXuatHD;
    }
}