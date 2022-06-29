using BUS;
using System;
using System.Windows.Forms;

namespace MS.Main
{
    public partial class Frm_ThongTinChiTietSanPham : Form
    {
        
        private static int _idBill { get; set; }

        private static int _idProduct { get; set; }

        private static int _idTable { get; set; }
        

        public Frm_ThongTinChiTietSanPham(int idTable, int idBill,int idProduct,int k)
        {
            InitializeComponent();
            _idTable = idTable;
            _idBill = idBill;
            _idProduct = idProduct;
            int n = k - 1;
            if (n <= 50)
            {
                n = 50;
            }

            for (int i = 1; i <= n; i++)
            {
                cbQuantity.Items.Add(i);
            }
        }

        private void fDetailOneProductBill_Load(object sender, EventArgs e)
        {
            cbQuantity.ContextMenu = new ContextMenu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?","Thông báo",MessageBoxButtons.OKCancel);
            if (kq != DialogResult.Cancel)
            {
                DetailBillBUS.DeleteOneProduct(_idBill, _idProduct);
                // Xóa sản phẩm trong detail bill thông qua ma hóa đơn.
                // Nếu trong hóa đơn đó không còn sản phẩm thì xóa hóa đơn ===>> cập nhật lại trạng thái bàn.
                if (!BUS.DetailBillBUS.IsEmpty(_idBill))
                {
                    BUS.BillBUS.DeleteBill(_idBill);
                    TableBUS.UpdateStatusTable(0, _idTable);
                }
            }  
        }

        private void cbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qualityP = cbQuantity.SelectedItem;
            double price = 0;
            if(Double.TryParse(lblPrice.Text, out price))
            {
                lblTotal.Text = String.Format("{0:0,0}", (price * (int)qualityP));
            }
        }
    }
}
