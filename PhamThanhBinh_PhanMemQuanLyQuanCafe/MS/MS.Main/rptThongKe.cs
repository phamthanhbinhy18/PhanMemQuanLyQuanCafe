using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MS.Main
{
    public partial class rptThongKe : Form
    {
        public rptThongKe()
        {
            InitializeComponent();
        }

        private void rptThongKe_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

        public void XuatThongKeTheoThang(List<BillUpDTO> lstBill, DateTime ThoiGianTu, DateTime ThoiGianDen, DateTime ThoiGianLap, string NhanVien)
        {
            if (lstBill.Count > 0)
            {
                double TongDoanhThuThang = _tinhTongDoanhThu(lstBill);

                reportViewer1.LocalReport.ReportEmbeddedResource = "MS.Main.rptThongKe.rdlc";
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dtThongKe", lstBill));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraThoiGian", ThoiGianLap.ToString(), false));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraThoiGianTu", ThoiGianTu.ToString("dd/MM/yyyy"), false));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraThoiGianDen", ThoiGianDen.ToString("dd/MM/yyyy"), false));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraNV", NhanVien, false));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("paraTongTien", TongDoanhThuThang.ToString("0,0 VNĐ"), false));

                reportViewer1.RefreshReport();
            }

        }

        private double _tinhTongDoanhThu(List<BillUpDTO> lstBill)
        {
            double Tong = 0;
            foreach (BillUpDTO bill in lstBill)
            {
                Tong += bill.Revenue;
            }
            return Tong;
        }
    }
}
