using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace MS.Main
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void XoaTruongDangNhap()
        {
            txtMatKhau.Text = "";
            lblNotification.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int username = (int)cbxNhanVien.SelectedValue;
            string password = txtMatKhau.Text;
            if(_login(username,password))
            {
                Program.sAccount = AccountBUS.GetAccount(username);
                if (Program.sAccount.Status == 1)
                {
                    Program.sAccount = AccountBUS.GetAccount(username);
                    if (Program.sAccount.Right == 0)
                    {
                        XoaTruongDangNhap();

                        Frm_TrangChu n = new Frm_TrangChu();
                        Hide();
                        n.ShowDialog();
                        Show();
                        
                        _loadAccount();
                    }
                    else if (Program.sAccount.Right == 1)
                    {
                        XoaTruongDangNhap();
                        frm_YeuCauGoiThucUong y = new frm_YeuCauGoiThucUong();
                        Hide();
                        y.ShowDialog();
                        Show();
                        _loadAccount();
                    }
                    else
                        Close();
                }
                else
                {
                    Program.sAccount = null;
                    lblNotification.Text = "Tài khoản của bạn đã bị khóa bởi người quản trị.";
                }
            }
            else
                lblNotification.Text = "Bạn nhập sai tài khoản hoặc mật khẩu. Vui lòng nhập lại!";
        }

        private bool _login(int username, string password)
        {
            return AccountBUS.IsLogin(username, password);
        }

        private void chkHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHidePass.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            _loadAccount();
            cbxNhanVien.ContextMenu = new ContextMenu();
        }

        private void _loadAccount()
        {
            List<AccountDTO> listtype = AccountBUS.GetListAccountOnStatus(1);
            cbxNhanVien.DataSource = listtype;
            cbxNhanVien.DisplayMember = "Name";
            cbxNhanVien.ValueMember = "ID";
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 64 || (Convert.ToInt32(e.KeyChar) >= 35 && Convert.ToInt32(e.KeyChar) <= 38) || (Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThongTinTaiKhoan frm_ThongTin = new Frm_ThongTinTaiKhoan(AccountBUS.GetAccount((int)cbxNhanVien.SelectedValue));
            frm_ThongTin.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng đến với Quản Lý Cafe.");
        }
    }
}
