using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MS.Main
{
    public partial class RptThanhToan : Form
    {
        public RptThanhToan()
        {
            InitializeComponent();
        }

        private void reportThanhToan_Load(object sender, EventArgs e)
        {
            rptXuatHD.RefreshReport();
        }

        public void XuatHoaDon(int MaHD,string TenHD, string Ban, string nhanvien, DateTime thoigian, string tongtien,string khuyenmai, string tienkhachhang, string tienton,string thanhtien,bool xemlaihoadon)
        {
             List<MenuDTO> lstProduct = BUS.MenuBUS.GetListMenuByIDBill(MaHD);
            if (!xemlaihoadon)
            {
                lstProduct = BUS.MenuBUS.GetReviewBill(MaHD);
            }

            rptXuatHD.LocalReport.ReportEmbeddedResource = "MS.Main.rptThanhToan.rdlc";
            if (tienton != "0")
            {
                tienton = string.Format("{0:0,0}", Convert.ToDouble(tienton).ToString("0,0"));
            }

            if (tienkhachhang != "0")
            {
                tienkhachhang = string.Format("{0:0,0}", "" + Convert.ToDouble(tienkhachhang).ToString("0,0") + "");
            }

            if (tongtien != "0")
            {
                tongtien = string.Format("{0:0,0}", Convert.ToDouble(tongtien).ToString("0,0"));
            }

            if (khuyenmai != "0")
            {
                khuyenmai = string.Format("{0:0,0}", Convert.ToDouble(khuyenmai).ToString("0,0"));
            }

            if (thanhtien != "0")
            {
                thanhtien = string.Format("{0:0,0}", Convert.ToDouble(thanhtien).ToString("0,0"));
            }

            rptXuatHD.LocalReport.DataSources.Add(new ReportDataSource("dtThanhToan", lstProduct));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraHD", "HD00" + MaHD.ToString(), false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraNV", nhanvien,false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraThoiGian", thoigian.ToString(), false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraTongTien",tongtien , false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraKhuyenMai", khuyenmai, false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("parasTienKhachTra", tienkhachhang, false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraTienTon",tienton, false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraThanhTien", thanhtien, false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraNameBill", TenHD, false));
            rptXuatHD.LocalReport.SetParameters(new ReportParameter("paraBan", Ban, false));



            rptXuatHD.RefreshReport();
        }
    }
}
