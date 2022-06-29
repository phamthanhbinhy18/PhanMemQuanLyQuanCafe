using DTO;
using System;
using System.Windows.Forms;

namespace MS.Main
{
    public partial class Frm_XacNhan : Form
    {
        public Frm_XacNhan(string thongbao,AccountDTO accou)
        {
            InitializeComponent();
            lblThongBao.Text = thongbao;
        }

        private void frm_XacNhan_Load(object sender, EventArgs e)
        {

        }

        private void txtXacNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 64 || (Convert.ToInt32(e.KeyChar) >= 35 && Convert.ToInt32(e.KeyChar) <= 38) || (Convert.ToInt32(e.KeyChar) >= 65 && Convert.ToInt32(e.KeyChar) <= 90) || (Convert.ToInt32(e.KeyChar) >= 97 && Convert.ToInt32(e.KeyChar) <= 122) || (Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
