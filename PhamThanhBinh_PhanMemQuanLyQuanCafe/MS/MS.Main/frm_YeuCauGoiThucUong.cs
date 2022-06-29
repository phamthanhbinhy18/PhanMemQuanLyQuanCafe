using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace MS.Main
{
    public partial class frm_YeuCauGoiThucUong : Form
    {
        private object objTable; // Đối tượng bàn
        public frm_YeuCauGoiThucUong()
        {
            InitializeComponent();
            LoadTable();
            _loadTypeProduct();
            tssNhanVien.Text = "Nhân viên đang đăng nhập: " + Program.sAccount.Name;
        }

        public void Order_Load(object sender, EventArgs e)
        {
            _loadProductListByTypeProductID(ProductBUS.GetListProductByIDTypeProduct(0, 1));
            
            cbLoaiThucUong.ContextMenu = new ContextMenu();
            timer1.Enabled = true;
            btnThanhToan.Enabled = false;
            btnTamTinh.Enabled = false;
        }

        private void _loadTypeProduct()
        {
            //load loại thức uống theo tên
            List<TypeProductDTO> listtype = TypeProductBUS.GetListTypeProductWithStatusOne(1);
            cbLoaiThucUong.DataSource = listtype;
            cbLoaiThucUong.DisplayMember = "NameType";
        }
        
        private void _loadProductListByTypeProductID(List<ProductDTO> listProduct) // Lấy dữ liệu sản phẩm từ csdl
        {
            lstSanPham.Items.Clear();
            for (int i = 0; i < listProduct.Count; i++)
            {
                ListViewItem item = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                item.SubItems.Add(listProduct[i].NameProducts);
                if (listProduct[i].SalePrice==0)
                    item.SubItems.Add("Miễn phí");
                else
                    item.SubItems.Add(listProduct[i].SalePrice.ToString("0,0 VNĐ"));
                item.Tag = listProduct[i];
                lstSanPham.Items.Add(item);
            }
        }

        public void LoadTable()
        {
            flbTable.Controls.Clear();
            //load bàn lên trên panel
            List<TableDTO> tablelist = TableBUS.GetAllListTable();

            foreach (TableDTO item in tablelist)
            {
                Button button = new Button
                {
                    Width = TableBUS.TabWidth,
                    Height = TableBUS.TabHeight,

                    Text = item.NameTable + Environment.NewLine + "Có",
                    Name = "B" + item.ID
                };
                button.Click += Button_Click;
                button.Tag = null;
                button.Tag = item;
                if (BUS.TableBUS.GetStatusByIDTable(item.ID) == 0)
                {
                    button.BackColor = Color.Aqua;
                    button.Text = item.NameTable + Environment.NewLine + "Trống";
                }
                else
                    button.BackColor = Color.LightPink;

                flbTable.Controls.Add(button);
            }
        }
        public void ShowBill(int id)
        {
            //load bill lên theo theo mã bàn
            lstBill.Items.Clear();

            List<MenuDTO> menulist = MenuBUS.GetListMenuByIDTable(id);
            double totalPrice = 0;
            for (int i = 0; i < menulist.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = menulist[i].NameProduct.ToString()
                };
                listitem.SubItems.Add(menulist[i].Quantity.ToString());
                if (menulist[i].PriceBasic == 0)
                    listitem.SubItems.Add("Miễn phí");
                else
                    listitem.SubItems.Add(String.Format("{0:0,0}", menulist[i].PriceBasic) + " VNĐ");
                if (menulist[i].TotalPrice == 0)
                    listitem.SubItems.Add("Miễn phí");
                else 
                    listitem.SubItems.Add(String.Format("{0:0,0}", menulist[i].TotalPrice) + " VNĐ");
                totalPrice += menulist[i].TotalPrice;
                listitem.Tag = menulist[i];
                listitem.SubItems.Add("#"+(i + 1).ToString());
                lstBill.Items.Add(listitem);
            }
            if (totalPrice > 0)
            txttotalPrice.Text = String.Format("{0:0,0}", totalPrice);
        }

        private void hoverClickButton(object sender)
        {
            Button btnTableLast = (Button)sender;
            if (objTable != null)
            {
                Button btnTablePresent = (Button)objTable;
                int sttTable = TableBUS.GetStatusByIDTable((btnTablePresent.Tag as TableDTO).ID);
                if (sttTable == 1)
                {
                    btnTablePresent.BackColor = Color.LightPink;
                }
                else btnTablePresent.BackColor = Color.Aqua;
                btnTablePresent.ForeColor = Color.Black;
            }
            btnTableLast.BackColor = Color.LightBlue;
            btnTableLast.ForeColor = Color.White; // Mau chu
            objTable = sender;
        }
        object choseTable;
        public void Button_Click(object sender, EventArgs e)
        {
            hoverClickButton(sender);
            choseTable = sender;
            txtHD.Text = "";
            txtBan.Text = "";
            
            // Viết hàm lấy thông tin bàn bằng mã
            Button btnTable = (Button)sender;
            lstBill.Tag = btnTable.Tag;
            // Kiểm tra trạng thai ở
            int idTable = (btnTable.Tag as TableDTO).ID;
            txtBan.Text = (btnTable.Tag as TableDTO).NameTable + "";
            btnThanhToan.Enabled = false;
            btnTamTinh.Enabled = false;
            cbLoaiThucUong.Enabled = true;
            lstSanPham.Enabled = true;
            txttotalPrice.Text = "0";
            if (TableBUS.GetStatusByIDTable(idTable) == 1)
            {
                txtHD.Text = "HD00" + (string)BillBUS.GetIDBillNoPaymentByIDTable((int)idTable).ToString();
                btnThanhToan.Enabled = true;
                btnTamTinh.Enabled = true;
                if (lstBill.Tag != null)
                {
                    ShowBill(idTable);
                }
            }
            else
            {
                lstBill.Items.Clear();
            }
        }

        private void cbLoaiThucUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLoaiThucUong.SelectedIndex >= 0)
            {
                //khi load loại loại thức uống thì sẽ gán loại theo cái thức uống.
                int id = 0;
                if (cbLoaiThucUong.SelectedItem == null)
                    return;
                TypeProductDTO typeProduct = cbLoaiThucUong.SelectedItem as TypeProductDTO;
                id = typeProduct.ID;
                _loadProductListByTypeProductID(ProductBUS.GetListProductByIDTypeProduct(id, 1));
            }
        }
      
        private TableDTO _createAddBillByIDTable(ProductDTO Product)
        {
            TableDTO table = lstBill.Tag as TableDTO;


            int idBill = BillBUS.GetIDBillNoPaymentByIDTable(table.ID);//lấy lên cái mã id của hóa đơn 

            // int idProduct = (cbProduct. SelectedItem as ProductDTO).ID;//thêm vào 1 gridview để hiển thị
            int idProduct = Product.ID;
            int quantity = 1;
            //kiểm tra hóa đơn có chưa hay
            if (idBill == -1)//nếu chưa thì tạo 1 hóa đơn mới với mã hóa đơn
            {
                quantity = DetailBillBUS.GetQuantityProduct(idBill, idProduct);
                // sau khi tạo xong 1 hóa đơn mới thì thêm vào bảng chi tiết hóa đơn với các trường tương ứng
                DetailBillBUS.InsertDetailBill(BillBUS.GetIDBillMax(), idProduct, quantity + 1);
            }
            else//nếu đã có thì thêm nó vào cái cá bảng chi tiêt hóa đơn với các trường là mã hóa đơn, mã thức uống và số lượng
            {
                quantity = DetailBillBUS.GetQuantityProduct(idBill, idProduct);
                DetailBillBUS.InsertDetailBill(idBill, idProduct, quantity + 1);
            }
            return table;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                TableDTO table = lstBill.Tag as TableDTO;
                int idBill = BillBUS.GetIDBillNoPaymentByIDTable(table.ID);
                Frm_ThanhToan frm_ThanhToan = new Frm_ThanhToan("HÓA ĐƠN THANH TOÁN", table, idBill, txttotalPrice.Text);
                //Hide();
                frm_ThanhToan.ShowDialog();
                if (frm_ThanhToan._KetQua)
                {
                    ShowBill(table.ID);

                    LoadTable();
                    _loadTypeProduct();
                    btnThanhToan.Enabled = false;
                    btnTamTinh.Enabled = false;
                    cbLoaiThucUong.Enabled = false;
                    lstSanPham.Enabled = false;
                    txttotalPrice.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstBill_MouseClick(object sender, MouseEventArgs e)
        {
            TableDTO table = ((Button)objTable).Tag as TableDTO;
         
            int idBill = BillBUS.GetIDBillNoPaymentByIDTable(table.ID);
            
            if (lstBill.SelectedItems.Count > 0)
            {
                MenuDTO order = (MenuDTO)lstBill.SelectedItems[0].Tag as MenuDTO;

                Frm_ThongTinChiTietSanPham de = new Frm_ThongTinChiTietSanPham(table.ID,idBill, order.IdProduct, Convert.ToInt32(order.Quantity) + 1);
                de.lblProductName.Text = order.NameProduct;
                if (order.PriceBasic == 0)
                    de.lblPrice.Text = "Miễn phí";
                else
                    de.lblPrice.Text = String.Format("{0:0,0}", order.PriceBasic);
                de.cbQuantity.SelectedIndex = Convert.ToInt32(order.Quantity) - 1;
                if (order.TotalPrice == 0)
                    de.lblTotal.Text = "Miễn phí";
                else
                    de.lblTotal.Text = String.Format("{0:0,0}", order.TotalPrice);
                DialogResult kq = de.ShowDialog();
                if (kq == DialogResult.OK)
                {
                    DetailBillBUS.InsertDetailBill(idBill, order.ID, de.cbQuantity.SelectedIndex + 1);
                    ShowBill(table.ID);
                }
                else if (kq == DialogResult.Yes)
                {
                    ShowBill(table.ID);
                    Button btnTable = ((Button)objTable);
                    btnTable.Text = table.NameTable + Environment.NewLine + "Trống";
                    if (!BUS.DetailBillBUS.IsEmpty(idBill))
                    {
                        btnTamTinh.Enabled = false;
                        btnThanhToan.Enabled = false;
                        txttotalPrice.Text = "";
                        txtHD.Text = "";
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHD.Text = "";
            lstBill.Items.Clear();
            txtBan.Text = "";
            txttotalPrice.Text = "0";
            objTable = null;
            choseTable = null;
            btnThanhToan.Enabled = false;
            btnTamTinh.Enabled = false;
            _loadTypeProduct();
            txtTuKhoa.Text = "";
            LoadTable();
            
        }

        private void btnTachBan_Click(object sender, EventArgs e)
        {
            frm_ThaoTacBan t = new frm_ThaoTacBan();
            Hide();
            t.ShowDialog();
            LoadTable();
            lstBill.Items.Clear();
            Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgayHienTai.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            _loadProductListByTypeProductID(ProductBUS.GeProductByName(txtTuKhoa.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TableDTO table = lstBill.Tag as TableDTO;
                int idBill = BillBUS.GetIDBillNoPaymentByIDTable(table.ID);

                RptThanhToan frm_TToan = new RptThanhToan();
                DateTime Time = DateTime.Now;
                frm_TToan.XuatHoaDon(idBill, "HÓA ĐƠN TẠM TÍNH", table.NameTable, Program.sAccount.Name, Time, string.Format("{0:0,0}", txttotalPrice.Text), "0", "0","0", "0",true);
                //
                frm_TToan.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbLoaiThucUong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedItems.Count > 0)
            {
                ProductDTO Product = lstSanPham.SelectedItems[0].Tag as ProductDTO;
                try
                {
                    if (choseTable != null)
                    {
                        if ((objTable as Button).Tag != null)
                        {
                            Button btnTable = (objTable as Button);
                            //tag cái bàn đang chọn vào
                            TableDTO table = (objTable as Button).Tag as TableDTO;
                            int idTable = table.ID;
                            if (TableBUS.GetStatusByIDTable(idTable) == 0)
                            {
                                DialogResult kq = MessageBox.Show("Bạn đang chọn bàn mới.\n Bạn có muốn tạo hóa đơn mới cho bàn này chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (kq == DialogResult.OK)
                                {
                                    btnThanhToan.Enabled = true;
                                    btnTamTinh.Enabled = true;
                                    lstBill.Tag = (choseTable as Button).Tag;

                                    TableBUS.UpdateStatusTable(1, idTable);

                                    BillBUS.InsertBill(DateTime.Now, 0, Program.sAccount.ID, idTable);
                                    txtHD.Text = "HD00" + (string)BillBUS.GetIDBillNoPaymentByIDTable((int)idTable).ToString();
                                    btnTable.Text = table.NameTable + Environment.NewLine + "Có";
                                }
                                else
                                {
                                    lstBill.Items.Clear();
                                    btnThanhToan.Enabled = false;
                                    btnTamTinh.Enabled = false;
                                    cbLoaiThucUong.Enabled = false;
                                    txtHD.Text = "";
                                }
                            }
                            table = _createAddBillByIDTable(Product);
                            ShowBill(table.ID);
                        }
                    }
                    else MessageBox.Show("Bạn chưa chọn bàn để thêm thức uống. Vui lòng chọn bàn để tiếp tục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void lstBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
