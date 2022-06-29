using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MS.Main
{
    public partial class frm_LayLaiMatKhau : Form
    {
        private int _Case;
        private AccountDTO _Account;
        public frm_LayLaiMatKhau(AccountDTO account,int Case)
        {
            InitializeComponent();
            _Account = account;
            _Case = Case;//0: hiện combobox 1: hiện label
            _loadAccount();
            if (_Case == 0)
                _Account = AccountBUS.GetAccount((int)cbxNhanVien.SelectedValue);
            
        }

        private void _loadAccount()
        {
            //load loại thức uống theo tên
            List<AccountDTO> listtype = AccountBUS.GetAllListAccount();
            cbxNhanVien.DataSource = listtype;
            cbxNhanVien.DisplayMember = "Name";
            cbxNhanVien.ValueMember = "ID";
        }

        private void frm_LayLaiMatKhau_Load(object sender, EventArgs e)
        {
            cbxNhanVien.ContextMenu = new ContextMenu();
            if(_Case == 1)
            {
                lblNhanVien.Visible = true;
                cbxNhanVien.Visible = false;
                lblNhanVien.Text = _Account.Name;
            }
            else
            {
                lblNhanVien.Visible = false;
                cbxNhanVien.Visible = true;
                cbxNhanVien.SelectedValue = _Account.ID;
            }
        }

        private void _clearField()
        {
            txtPassOld.Text = "";
            txtPasswwordNew.Text = "";
            txtRetypePass.Text = "";
            lblThongBao.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _clearField();
            Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try{
                if (_Case == 0)
                    _Account = AccountBUS.GetAccount((int)cbxNhanVien.SelectedValue);
                if (txtRetypePass.Text != "" || txtPasswwordNew.Text != "" || txtPassOld.Text != "")
                {
                    if (AccountBUS.IsLogin(_Account.ID, txtPassOld.Text))
                    {
                        if (string.Compare(txtPasswwordNew.Text, txtRetypePass.Text) == 0)
                        {
                            if (txtRetypePass.Text.Length >= 6 && txtPasswwordNew.Text.Length >= 6)
                            {
                                _Account.PassWord = txtPasswwordNew.Text;
                                if (AccountBUS.UpdateAccount(_Account))
                                {
                                    MessageBox.Show( "Thay đổi mật khẩu thành công!","Thông báo");
                                    Close();
                                }
                                _clearField();
                            }
                            else lblThongBao.Text = "Mật khẩu phải ít nhất 6 ký tự";
                        }
                        else
                            lblThongBao.Text = "Hai mật khẩu không khớp";
                    }
                    else
                        lblThongBao.Text = "Mật khẩu cũ không hợp lệ.";
                }
                else lblThongBao.Text = "Không được bỏ trống trường dữ liệu nào";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassOld_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 64 || (Convert.ToInt32(e.KeyChar) >= 35 && Convert.ToInt32(e.KeyChar) <= 38) || (Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57))
           {
               e.Handled = false;
           }
           else e.Handled = true;
        }

        private void cbxNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
