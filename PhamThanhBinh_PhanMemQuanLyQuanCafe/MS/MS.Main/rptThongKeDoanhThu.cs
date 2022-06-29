using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MS.Main
{
    public partial class rptThongKeDoanhThu : Form
    {
        public rptThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void rptThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

        public void XuatThongKeTheoThang(List<RevenueDTO> lstRevenue, DateTime timeNow, string fromTime, string toTime, string NhanVien)
        {
            if (lstRevenue.Count > 0)
            {
                double totalRevenue = _tinhTongDoanhThu(lstRevenue);

                reportViewer1.LocalReport.ReportEmbeddedResource = "MS.Main.rptThongKeDoanhThu.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtThongKe", lstRevenue));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraThoiGian", timeNow.ToString(), false));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraThoiGianTu", fromTime, false));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraThoiGianDen", toTime, false));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraNV", NhanVien, false));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraTongTien", totalRevenue.ToString("0,0 VNĐ"), false));

                reportViewer1.RefreshReport();
            }
        }

        private double _tinhTongDoanhThu(List<RevenueDTO> lstRevenue)
        {
            double tong = 0;
            foreach (RevenueDTO rev in lstRevenue)
            {
                if (rev.Month != 0)
                {
                    tong += rev.TotalRevenue;
                }
            }
            return tong;
        }
    }
}
