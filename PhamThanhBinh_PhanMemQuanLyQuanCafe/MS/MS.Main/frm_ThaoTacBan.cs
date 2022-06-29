using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace MS.Main
{
    public partial class frm_ThaoTacBan : Form
    {
        private bool checkChange = false;
        public frm_ThaoTacBan()
        {
            InitializeComponent();
            try
            {
                _loadTableOfTable(TableBUS.GetListTableHaveStatusOne(), cbxTableFrom, "NameTable", "ID");
                _loadTableOfTable(TableBUS.GetListTableHaveStatusOne(), cbxTableTo, "NameTable", "ID");
                _loadBillInTextBox(txtBillFrom, (int)cbxTableFrom.SelectedValue);
                _loadBillInTextBox(txtBillTo, (int)cbxTableTo.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _loadBillInTextBox(TextBox txtHD,int idTable)
        {
            int idBill = BUS.BillBUS.GetIDBillNoPaymentByIDTable(idTable);
            if (idBill != -1)
            {
                txtHD.Text = "HD00" + (string)(idBill).ToString();
            }
            else txtHD.Text = "";
        }

        private void _loadTableOfTable(List<TableDTO> data, ComboBox cbx, string Display, string Value)
        {
            cbxTableFrom.DataSource = data;
            cbxTableFrom.ValueMember = Value;
            cbxTableFrom.DisplayMember = Display;
            if (cbxTableFrom.SelectedIndex == 0)
            {
                _selectIDTableOther(cbxTableTo, "NameTable", "ID", (int)cbxTableFrom.SelectedValue);
                _displayProductOnListView(lstTableFrom, (int)cbxTableFrom.SelectedValue);
            }
        }

        private void cbxIDFromTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if (cbxTableFrom.SelectedItem != null)
            {
                TableDTO tabledto = cbxTableFrom.SelectedItem as TableDTO;
                id = tabledto.ID;
                _displayProductOnListView(lstTableFrom, id);
                _selectIDTableOther(cbxTableTo, "NameTable", "ID", id);
                _loadBillInTextBox(txtBillFrom, id);
            }
            return;
        }

        private void _displayProductOnListView(ListView lstFrom, int id)
        {
            List<MenuDTO> listdetail = MenuBUS.GetListMenuByIDTable(id);
            lstFrom.Items.Clear();
            for (int i = 0; i < listdetail.Count; i++)
            {
                ListViewItem lst = new ListViewItem
                {
                    Text = listdetail[i].NameProduct
                };
                lst.SubItems.Add(listdetail[i].Quantity.ToString());
                if (listdetail[i].PriceBasic == 0)
                    lst.SubItems.Add("Miễn phí");
                else
                    lst.SubItems.Add(listdetail[i].PriceBasic.ToString("0,0 VNĐ"));
                if (listdetail[i].TotalPrice == 0)
                    lst.SubItems.Add("Miễn phí");
                else
                    lst.SubItems.Add(listdetail[i].TotalPrice.ToString("0,0 VNĐ"));
                lst.SubItems.Add("#" + (i + 1).ToString());
                lst.Tag = listdetail[i];
                lstFrom.Items.Add(lst);
            }
        }

        private void cbxIDNextTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            if (cbxTableTo.SelectedItem != null)
            {
                TableDTO table = cbxTableTo.SelectedItem as TableDTO;
                id = table.ID;
                _displayProductOnListView(lstTableTo, id);
                _loadBillInTextBox(txtBillTo, id);
            }
            return;
        }
        private void _selectIDTableOther(ComboBox cbx, string Displaymember, string ValuesMember, int id)
        {
            List<TableDTO> lsttable = TableBUS.GetListTableDifferentID(id);
            cbx.DataSource = lsttable;
            cbx.DisplayMember = Displaymember;
            cbx.ValueMember = ValuesMember;
        }

        private void frm_ThaoTacBan_Load(object sender, EventArgs e)
        {
            cbxTableFrom.ContextMenu = new ContextMenu();
            cbxTableTo.ContextMenu = new ContextMenu();
        }

        private void btnPreviousOne_Click(object sender, EventArgs e)
        {
            if (lstTableTo.SelectedItems.Count > 0)
            {
                _xuLyChuyenThucUong(cbxTableFrom, lstTableFrom, cbxTableTo, lstTableTo);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn để thực hiện chức năng này.");
            }
            
        }

        private void _xuLyChuyenThucUong(ComboBox cbxTableFrom, ListView lstFrom, ComboBox cbxTableTo, ListView lstTableTo, int soluong = 0)
        {
            try
            {
                // Hiển thị thức uống 

                // Theo tác thực hiện chuyển
                checkChangeInformationDeteilBill(false);
                int idTableFrom = (int)cbxTableFrom.SelectedValue;
                int idBillFrom = BUS.BillBUS.GetIDBillNoPaymentByIDTable(idTableFrom);

                int idTableTo = (int)cbxTableTo.SelectedValue;
                int idBillTo = BUS.BillBUS.GetIDBillNoPaymentByIDTable(idTableTo);
                bool kt = false;
                // Kiểm tra trạng thái của bàn ( chưa được tạo hóa đơn)
                int n = lstTableTo.SelectedItems.Count;
                if (soluong == 1)
                {
                    n = lstTableTo.Items.Count;
                }

                //List
                for (int i = 0; i < n; i++)
                {
                    MenuDTO menu = null;
                    if (soluong == 1)
                        menu = (lstTableTo.Items[i].Tag as MenuDTO);
                    else menu = (lstTableTo.SelectedItems[i].Tag as MenuDTO);
                    // Xử lý đã có hóa đơn trong csdl
                    //kiểm tra id sản phẩm đã có
                    // Nếu không có sản phẩm nào tồn tại trong list
                    if (BUS.DetailBillBUS.IsExistProductByIDBillAndIDProduct(idBillFrom, menu.ID))
                    {
                        // Thêm mới hóa đơn vào
                        // Cập nhật trạng thái bàn
                        //
                        BUS.DetailBillBUS.InsertDetailBill(idBillFrom, menu.ID, BUS.DetailBillBUS.GetQuantityProduct(idBillFrom, menu.ID) + menu.Quantity); // Thêm mới thức uống vào chi tiết hóa đơn
                        // Xóa sản phẩm đã chuyển
                    }
                    else BUS.DetailBillBUS.InsertDetailBill(idBillFrom, menu.ID, menu.Quantity);

                    BUS.DetailBillBUS.DeleteOneProduct(idBillTo, menu.ID);
                    // 

                    // Kiểm tra số lượng thức uống tồn trong bill
                    // Nếu như nó không còn thì xóa bill

                    // Cập nhật bàn

                    kt = true;
                }
                if (kt)
                {
                    _displayProductOnListView(lstTableFrom, idTableFrom);
                    _displayProductOnListView(lstTableTo, idTableTo);

                    MessageBox.Show("Thực hiện thao tác thành công.", "Thông báo");
                }
                if (lstTableTo.Items.Count == 0)
                {
                    // Xóa bill
                    BUS.BillBUS.DeleteBill(idBillTo);
                    BUS.TableBUS.UpdateStatusTable(0, idTableTo);
                    _displayProductOnListView(lstTableFrom, idTableFrom);
                    //DisplayProductOnListView(lstTableTo, idTableTo);
                    _loadTableOfTable(TableBUS.GetListTableHaveStatusOne(), cbxTableFrom, "NameTable", "ID");
                    _loadTableOfTable(TableBUS.GetListTableHaveStatusOne(), cbxTableTo, "NameTable", "ID");
                }
            }
            catch (Exception ex) {
                 MessageBox.Show(ex.Message);
            }
        }

        private void _moveImformationDetailBill(object menuItem)
        {
            MenuDTO menu = (menuItem as MenuDTO);
            //lstTableNext.Items.Clear();
            ListViewItem lst = new ListViewItem
            {
                Text = menu.NameProduct
            };
            lst.SubItems.Add(menu.Quantity.ToString());
            lst.SubItems.Add(menu.PriceBasic.ToString());
            lst.SubItems.Add(menu.TotalPrice.ToString());
            lst.Tag = menu;
            lstTableFrom.Items.Add(lst);
            lstTableTo.Items.Remove(lstTableTo.SelectedItems[0]);
            checkChangeInformationDeteilBill(true);
        }

        private void _createListViewItemNew(MenuDTO menu, int soluong)
        {
            ListViewItem lst = new ListViewItem
            {
                Text = menu.NameProduct
            };
            lst.SubItems.Add((menu.Quantity + soluong).ToString());
            lst.SubItems.Add((menu.PriceBasic).ToString());
            lst.SubItems.Add(menu.TotalPrice.ToString());
            //lst.Tag = menu;
            lstTableTo.Items.Add(lst);
            lstTableFrom.Items.Remove(lstTableFrom.SelectedItems[0]);
        }

        private void btnNextOne_Click(object sender, EventArgs e)
        {
            if (lstTableFrom.SelectedItems.Count > 0)
            {
                _xuLyChuyenToiThucUong(cbxTableFrom, lstTableFrom, cbxTableTo, lstTableTo);
            }
            else
            {
                MessageBox.Show("Bạn vui lòng chọn sản phẩm để thực hiện chức năng này.");
            }
        }

        private void _xuLyChuyenToiThucUong(ComboBox cbxTableFrom, ListView lstFrom, ComboBox cbxTableTo, ListView lstTableTo, int soluong = 0)
        {
            try
            {
                bool kt = false;
                // Hiển thị thức uống -
                // Theo tác thực hiện chuyển
                checkChangeInformationDeteilBill(false);
                int idTableFrom = (int)cbxTableFrom.SelectedValue;
                int idBillFrom = BUS.BillBUS.GetIDBillNoPaymentByIDTable(idTableFrom);

                int idTableTo = (int)cbxTableTo.SelectedValue;
               int n = lstTableFrom.SelectedItems.Count;
                if (soluong == 1)
                {
                    n = lstTableFrom.Items.Count;
                }
                for (int i = 0; i < n; i++)
                {
                    MenuDTO menu = null;
                    if (soluong == 1)
                        menu = (lstTableFrom.Items[i].Tag as MenuDTO);
                    else menu = (lstTableFrom.SelectedItems[i].Tag as MenuDTO);

                    int idBillTo = BUS.BillBUS.GetIDBillNoPaymentByIDTable(idTableTo); // hóa đơn

                    // Kiểm tra trạng thái của bàn ( chưa được tạo hóa đơn)
                    if (idBillTo == -1) // Chưa có hóa đơn
                    {
                        DialogResult kq = MessageBox.Show("Bàn hiện tại đang trống. Bạn có muốn tạo hóa đơn mới cho bàn này hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (kq == DialogResult.OK)
                        {
                            BUS.BillBUS.InsertBill(DateTime.Now,0,Program.sAccount.ID,idTableTo);  // Thêm hóa đơn
                            // Cập nhật trạng thái bàn thành đã tồn tại hóa đơn
                            BUS.TableBUS.UpdateStatusTable(1, idTableTo); 
                            //
                            int idBill = BUS.BillBUS.GetIDBillNoPaymentByIDTable(idTableTo); // Lấy hóa đơn theo bàn
                            int idProduct = menu.ID;
                            BUS.DetailBillBUS.InsertDetailBill(idBill, idProduct, menu.Quantity); // Thêm mới thức uống vào chi tiết hóa đơn
                            // Xóa sản phẩm đã chuyển
                            BUS.DetailBillBUS.DeleteOneProduct(BUS.BillBUS.GetIDBillNoPaymentByIDTable((int)cbxTableFrom.SelectedValue), idProduct);
                            // 
                            kt = true;
                        }
                        else return;
                    }
                    else// Xử lý đã có hóa đơn
                    {
                        // Xử lý đã có hóa đơn trong csdl
                        //kiểm tra id sản phẩm đã có
                        // Nếu không có sản phẩm nào tồn tại trong list
                        if (BUS.DetailBillBUS.IsExistProductByIDBillAndIDProduct(idBillTo, menu.ID))
                        {
                            BUS.DetailBillBUS.InsertDetailBill(idBillTo, menu.ID, BUS.DetailBillBUS.GetQuantityProduct(idBillTo, menu.ID) + menu.Quantity); // Thêm mới thức uống vào chi tiết hóa đơn
                            // Xóa sản phẩm đã chuyển
                        }
                        else BUS.DetailBillBUS.InsertDetailBill(idBillTo, menu.ID, menu.Quantity);

                        BUS.DetailBillBUS.DeleteOneProduct(idBillFrom, menu.ID);
                        //
                        kt = true;
                    }
                }
                if (kt)
                {
                    
                    _displayProductOnListView(lstTableFrom, (int)cbxTableFrom.SelectedValue);
                    _displayProductOnListView(lstTableTo, (int)cbxTableTo.SelectedValue);
                    MessageBox.Show("Thực hiện thao tác thành công.", "Thông báo");
                }
                if (lstTableFrom.Items.Count == 0)
                {
                    // Xóa bill
                    BUS.BillBUS.DeleteBill(idBillFrom);
                    BUS.TableBUS.UpdateStatusTable(0, idTableFrom);
                    _loadTableOfTable(TableBUS.GetListTableHaveStatusOne(), cbxTableFrom, "NameTable", "ID");
                    _loadTableOfTable(TableBUS.GetListTableHaveStatusOne(), cbxTableTo, "NameTable", "ID");
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void checkChangeInformationDeteilBill(bool xxx)
        {
            checkChange = xxx;
            cbxTableFrom.Enabled = !xxx;
            cbxTableTo.Enabled = !xxx;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstTableFrom.Items.Count > 0 || lstTableTo.Items.Count > 0)
            {

            }
            else
                MessageBox.Show("Bạn chưa chọn bàn để thực hiện thao tác.");
        }

        private void frm_ThaoTacBan_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void _btnPreviousAll_Click(object sender, EventArgs e)
        {
            if (lstTableTo.Items.Count > 0)
            {
                _xuLyChuyenThucUong(cbxTableFrom, lstTableFrom, cbxTableTo, lstTableTo,1);
            }
            else
                MessageBox.Show("Bạn vui lòng chọn sản phẩm để thực hiện chức năng này.");
        }

        private void _btnNextAll_Click(object sender, EventArgs e)
        {
            if (lstTableFrom.Items.Count > 0)
            {
                _xuLyChuyenToiThucUong(cbxTableFrom, lstTableFrom, cbxTableTo, lstTableTo, 1);
            }
            else
                MessageBox.Show("Bạn vui lòng chọn sản phẩm để thực hiện chức năng này.");
        }

        private void _button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void _lstTableTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _cbxTableFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
