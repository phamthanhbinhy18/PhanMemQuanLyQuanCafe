using System;
using System.Windows.Forms;

namespace MS.Main
{
    public partial class Frm_TrangChu : Form
    {
        public Frm_TrangChu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (Program.sAccount.Right == 0)
            {
                Frm_QuanLyHeThong n = new Frm_QuanLyHeThong();
                Hide();
                n.ShowDialog();
                if (Program.sAccount.Right == 1)
                {
                    btnAdmin.Visible = false;
                    MessageBox.Show("Tài khoản của bạn thuộc loại tài khoản nhân viên, bạn vui lòng đăng nhập lại!");
                    Close();

                }
                if (Program.sAccount.Status == 0)
                {
                    btnAdmin.Visible = false;
                    btnOrder.Visible = false;
                    MessageBox.Show("Tài khoản của bạn đã bị khóa nên không thể sử dụng các chức năng của hệ thống!");
                    Close();
                }
                Show();
            }
            else MessageBox.Show("Tài khoản của bạn không có quyền sử dụng chức năng này!"); 

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frm_YeuCauGoiThucUong frm_Order = new frm_YeuCauGoiThucUong();
            Hide();
            frm_Order.ShowDialog();
            if (Program.sAccount.Right == 1)
            {
                btnAdmin.Visible = false;

            }
            if (Program.sAccount.Status == 0)
            {
                btnAdmin.Visible = false;
                btnOrder.Visible = false;
                MessageBox.Show("Tài khoản của bạn đã bị khóa vui lòng đăng xuất khỏi hệ thống!"); 
            }
            Show();
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            Frm_ThongTinTaiKhoan frm_ThongTin = new Frm_ThongTinTaiKhoan(Program.sAccount);
            frm_ThongTin.ShowDialog();
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void fTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            //Close();
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq != DialogResult.Cancel)
            {
                Program.sAccount = null;
                Close();
                Frm_DangNhap frm = new Frm_DangNhap();
                frm.XoaTruongDangNhap();
            }
        }
    }
}
