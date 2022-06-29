using DTO;
using System;
using System.Windows.Forms;

namespace MS.Main
{
    public partial class Frm_ThongTinTaiKhoan : Form
    {
        private AccountDTO _Account;
        public Frm_ThongTinTaiKhoan(AccountDTO acc)
        {
            InitializeComponent();
            _Account = acc;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LayLaiMatKhau frm = new frm_LayLaiMatKhau(Program.sAccount, 0);
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            lblName.Text = _Account.Name;
            lblNoiSinh.Text = _Account.PlaceOfBirth;
            lblSDT.Text = _Account.Telephone;
            lblDiaChi.Text = _Account.Address;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDMK_Click(object sender, EventArgs e)
        {
            frm_LayLaiMatKhau frm = new frm_LayLaiMatKhau(_Account, 1);
            frm.ShowDialog();
        }
    }
}
