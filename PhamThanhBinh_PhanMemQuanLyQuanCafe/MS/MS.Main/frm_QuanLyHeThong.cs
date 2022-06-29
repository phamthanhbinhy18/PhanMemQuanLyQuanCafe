using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace MS.Main
{
    public partial class Frm_QuanLyHeThong : Form
    {
        private const string PASSWORD_DEFAULT = "1234567";

        public Frm_QuanLyHeThong()
        {
            InitializeComponent();
            tssNhanvien.Text = "Nhân viên đang đăng nhập: " + Program.sAccount.Name;
            tssThoiGian.Text = " - Ngày hiện tại: " + DateTime.Now.ToString("dd/MM/yyyy");

            ShowProduct();
            _importChucVu();
            _showTable();
            _loadTypeProduct(cbLocLoaiSP);
            _loadTypeProduct(cbTypeProduct);
            _showAccount();
            _showTypeProduct();
            _showTable();

            _loadMonth();
            _loadMonthDoanhThu();

            _loadListEmployeeToCombobox();
            _loadListInventory();
            _loadRevenue();

            int year = (cbxThang.SelectedItem as DimTime).Year;
            int month = (cbxThang.SelectedItem as DimTime).Month;
            _loadListEmployeeSalaried(month, year);

            btnEditTypeProduct.Visible = false;
            btnEditProduct.Visible = false;
            btnDeleteAccount.Enabled = false;
            btnAddAccount.Visible = true;
            btnEditAccount.Visible = false;
        }

        private void _importChucVu()
        {
            cbxChucVu.Items.AddRange(
                new object[]{
                new ChucVu(){ ID = 0, Name = Position.GetName(0) },
                new ChucVu(){ ID = 1, Name = Position.GetName(1) },
                new ChucVu(){ ID = 2, Name = Position.GetName(2) },
                new ChucVu(){ ID = 3, Name = Position.GetName(3) }
            });;

            cbxChucVu.DisplayMember = "Name";
            cbxChucVu.ValueMember = "ID";
            cbxChucVu.SelectedIndex = 0;
        }

        private void _setAutoSizeCollumn()
        {
            lstLuongNhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstLuongNhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lstNguyenLieu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstNguyenLieu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lstRevenue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstRevenue.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lstAccount.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstAccount.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lstProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstProduct.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lstDoanhThu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstDoanhThu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void ShowProduct()
        {
            lstProduct.Items.Clear();
            List<ProductDTO> menulist = ProductBUS.GetAllListProduct();
            _createListProduct(menulist);
        }

        private void _createListProduct(List<ProductDTO> menulist)
        {
            for (int i = 0; i < menulist.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add(menulist[i].NameProducts);
                if (menulist[i].PriceBasic == 0)
                {
                    listitem.SubItems.Add("Miễn phí");
                }
                else listitem.SubItems.Add(menulist[i].PriceBasic.ToString("0,000"));

                if (menulist[i].SalePrice == menulist[i].PriceBasic)
                    listitem.SubItems.Add("Không có chương trình khuyến mãi");
                else
                {
                    int phantram = (int)((menulist[i].SalePrice * 100) / menulist[i].PriceBasic);
                    listitem.SubItems.Add("Đang giảm " + phantram + "%");
                }
                if (menulist[i].Status == 1)
                {
                    listitem.SubItems.Add("Đang họat động");
                }
                else
                {
                    listitem.SubItems.Add("Ngưng bán");
                }
                listitem.SubItems.Add("SP00" + menulist[i].ID);
                listitem.Tag = menulist[i];
                lstProduct.Items.Add(listitem);
            }
        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" || txtPriceProduct.Text == "")
                {
                    MessageBox.Show("Bạn không thể thêm nếu như để trống một trường dữ liệu nào.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    ProductDTO sp = new ProductDTO
                    {
                        NameProducts = txtProductName.Text,
                        PriceBasic = Convert.ToDouble(txtPriceProduct.Text)
                    };
                    sp.SalePrice = sp.PriceBasic;
                    if (radAn.Checked)
                    {
                        sp.Status = 0;
                    }
                    else
                        sp.Status = 1;
                    sp.SalePrice = sp.PriceBasic;
                    // Chọn loại sản phẩm
                    TypeProductDTO typeProduct = cbTypeProduct.SelectedItem as TypeProductDTO;
                    sp.IDTypeProduct = typeProduct.ID;

                    if (ProductBUS.InsertProduct(sp) == true)
                    {
                        MessageBox.Show("Thêm mới thành công.", "Thông báo", MessageBoxButtons.OK);
                        ShowProduct();
                        _deleteTextProduct();
                    }
                    else
                        MessageBox.Show("Thêm mới sản phẩm thất bại, vui lòng kiểm tra dữ liệu nhập vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void _loadTypeProduct(ComboBox cmb)
        {
            List<TypeProductDTO> listtype = TypeProductBUS.GetListTypeProductWithStatusOne(1);
            cmb.DataSource = listtype;
            cmb.ValueMember = "ID";
            cmb.DisplayMember = "NameType";
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstProduct.SelectedItems.Count > 0)
                {
                    if (txtProductName.Text == "" || txtPriceProduct.Text == "")
                    {
                        MessageBox.Show("Bạn không thể cập nhật nếu như để trống một trường dữ liệu nào.", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        ProductDTO sp = lstProduct.SelectedItems[0].Tag as ProductDTO;
                        sp.NameProducts = txtProductName.Text;
                        sp.PriceBasic = Convert.ToDouble(txtPriceProduct.Text);
                        // Dành cho phát triển thêm chức năng quản lý khuyến mãi
                        sp.SalePrice = sp.PriceBasic;

                        if (radAn.Checked)
                        {
                            sp.Status = 0;
                        }
                        else
                            sp.Status = 1;

                        TypeProductDTO typeProduct = cbTypeProduct.SelectedItem as TypeProductDTO;
                        sp.IDTypeProduct = typeProduct.ID;

                        if (ProductBUS.UpdateProduct(sp))
                        {
                            ShowProduct();
                            MessageBox.Show("Bạn đã cập nhật sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK);
                            _deleteTextProduct();
                            btnAddProduct.Visible = true;
                            btnEditProduct.Visible = false;
                            btnDeProduct.Enabled = false;
                        }
                        else
                            MessageBox.Show("Hiện tại bạn đã cập nhật thông tin sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn vui lòng chọn sản phẩm trước khi thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItems.Count > 0)
            {
                btnDeProduct.Enabled = true;
                btnAddProduct.Visible = false;
                btnEditProduct.Visible = true;
                ListViewItem lvw = lstProduct.SelectedItems[0];
                ProductDTO sp = (ProductDTO)lvw.Tag;
                txtIDProduct.Text = "SP00" + sp.ID.ToString();
                txtProductName.Text = sp.NameProducts;
                txtPriceProduct.Text = sp.PriceBasic.ToString();
                cbTypeProduct.SelectedValue = sp.IDTypeProduct;
                if (sp.Status == 1)
                {
                    radHien.Checked = true;

                }
                else
                    radAn.Checked = true;
            }
        }

        private void btnWatchProduct_Click(object sender, EventArgs e)
        {
            _deleteTextProduct();
        }

        private void _deleteTextProduct()
        {
            btnDeProduct.Enabled = false;
            btnAddProduct.Visible = true;
            btnEditProduct.Visible = false;
            txtProductName.Text = "";
            txtPriceProduct.Text = "";
            txtIDProduct.Text = "";
            radHien.Checked = true;
            ShowProduct();
            _loadListTypeProduct(cbLocLoaiSP);
            _loadListTypeProduct(cbTypeProduct);
        }

        private void btnDeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstProduct.SelectedItems != null)
                {
                    ListViewItem lvw = lstProduct.SelectedItems[0];
                    ProductDTO sp = (ProductDTO)lvw.Tag;
                    Frm_XacNhan frm_XN = new Frm_XacNhan("Xóa một sản phẩm rất quan trọng. Bạn vui lòng nhập mật khẩu để xác nhận thao tác này!", Program.sAccount);
                    if (frm_XN.ShowDialog() == DialogResult.OK)
                    {
                        if (AccountBUS.IsLogin(Program.sAccount.ID, frm_XN.txtXacNhap.Text))
                        {
                            if (DetailBillBUS.IsExistProduct(sp.ID) == -1)
                            {
                                if (lstProduct.SelectedItems.Count > 0)
                                {
                                    if (ProductBUS.DeleteProduct(sp) == true)
                                    {
                                        MessageBox.Show("Bạn đã xóa thành công sản phẩm SP00" + sp.ID + " khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK);
                                        ShowProduct();
                                        _deleteTextProduct();
                                        btnEditProduct.Visible = false;
                                        btnAddProduct.Visible = true;
                                    }
                                    else
                                        MessageBox.Show("Xóa sản phẩm thất bại, vui lòng thử lại sau!", "Thông báo", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("Chưa chọn thức uống", "Thông báo", MessageBoxButtons.OK);
                                }
                            }
                            else
                                MessageBox.Show("Thức uống này đã được người dùng chọn hoặc mua trong thời gian trước đó, bạn không thể xóa sản phẩm này!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else MessageBox.Show("Bạn nhập sai mật khẩu, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else MessageBox.Show("Bạn vui lòng chọn sản phẩm trước khi thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void _showTypeProduct()
        {
            lstTypeProduct.Items.Clear();
            List<TypeProductDTO> menulist = TypeProductBUS.GetAllListTypeProduct();
            for (int i = 0; i < menulist.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add(menulist[i].Nametype.ToString());
                if (menulist[i].Status == 1)
                {
                    listitem.SubItems.Add("Đang họat động");
                }
                else
                    listitem.SubItems.Add("Khóa");
                listitem.SubItems.Add("LSP00" + menulist[i].ID.ToString());
                listitem.Tag = menulist[i];
                lstTypeProduct.Items.Add(listitem);
            }

        }

        private void btnAddTypeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTypeProductName.Text == "")
                {
                    MessageBox.Show("Bạn không thể cập nhật nếu như để trống một trường dữ liệu nào.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    TypeProductDTO sp = new TypeProductDTO
                    {
                        Nametype = txtTypeProductName.Text
                    };

                    if (radAnType.Checked)
                    {
                        sp.Status = 0;
                    }
                    else
                        sp.Status = 1;

                    if (TypeProductBUS.InsertTypeProduct(sp) == true)
                    {
                        MessageBox.Show("Đã thêm mới loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                        _showTypeProduct();
                        _loadTypeProduct(cbTypeProduct);
                        _loadTypeProduct(cbLocLoaiSP);
                        _deleteTextType();
                    }
                    else
                        MessageBox.Show("Bạn đã thêm loại sản phẩm thất bại, vui lòng kiểm tra thông tin nhập vào!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void lstTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTypeProduct.SelectedItems.Count > 0)
            {
                btnEditTypeProduct.Visible = true;
                btnAddTypeProduct.Visible = false;
                btnDeTypeProduct.Enabled = true;
                ListViewItem lvw = lstTypeProduct.SelectedItems[0];
                TypeProductDTO sp = (TypeProductDTO)lvw.Tag;
                txtIDTypeProduct.Text = "LSP00" + sp.ID.ToString();
                txtTypeProductName.Text = sp.Nametype;
                if (sp.Status == 1)
                {
                    radHienType.Checked = true;
                }
                else
                    radAnType.Checked = true;
            }
        }

        private void btnEditTypeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTypeProduct.SelectedItems.Count > 0)
                {
                    if (txtTypeProductName.Text == "")
                    {
                        MessageBox.Show("Bạn không thể cập nhật nếu như để trống một trường dữ liệu nào.", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        TypeProductDTO sp = lstTypeProduct.SelectedItems[0].Tag as TypeProductDTO;
                        sp.Nametype = txtTypeProductName.Text;
                        if (radAnType.Checked)
                        {
                            sp.Status = 0;
                        }
                        else
                            sp.Status = 1;

                        if (TypeProductBUS.UpdateTypeProduct(sp))
                        {
                            _showTypeProduct();
                            MessageBox.Show("Đã cập nhật loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK);
                            _deleteTextType();
                            _loadTypeProduct(cbLocLoaiSP);
                            _loadTypeProduct(cbTypeProduct);
                        }
                        else
                            MessageBox.Show("Bạn đã cập nhật loại sản phẩm thất bại, vui lòng kiểm tra thông tin nhập vào!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn vui lòng chọn sản phẩm trước khi thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeTypeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTypeProduct.SelectedItems.Count > 0)
                {
                    TypeProductDTO sp = lstTypeProduct.SelectedItems[0].Tag as TypeProductDTO;
                    Frm_XacNhan frm_XN = new Frm_XacNhan("Vui lòng nhập mật khẩu để xác nhận thao tác này!", Program.sAccount);
                    if (frm_XN.ShowDialog() == DialogResult.OK)
                    {
                        if (AccountBUS.IsLogin(Program.sAccount.ID, frm_XN.txtXacNhap.Text))
                        {
                            if ((ProductBUS.GetIDTypeProductByIDProduct(sp.ID)) == -1)
                            {
                                if (TypeProductBUS.DeleteTypeProduct(sp))
                                {
                                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                                    _showTypeProduct();
                                    _deleteTextType();
                                    _loadTypeProduct(cbLocLoaiSP);
                                    _loadTypeProduct(cbTypeProduct);
                                }
                                else
                                    MessageBox.Show("Thực hiện xóa thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK);
                            }
                            else { MessageBox.Show("Bạn vui lòng xóa tất cả sản phẩm đang thuộc loại sản phẩm này, trước khi thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK); }
                        }
                        else MessageBox.Show("Bạn nhập sai mật khẩu, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("Bạn chưa chọn loại sản phẩm nào!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnNewType_Click(object sender, EventArgs e)
        {
            _deleteTextType();
        }

        private void _deleteTextType()
        {
            btnDeTypeProduct.Enabled = false;
            btnAddTypeProduct.Visible = true;
            btnEditTypeProduct.Visible = false;
            txtTypeProductName.Text = "";
            txtIDTypeProduct.Text = "";
            radHienType.Checked = true;
            _showTypeProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoatType_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteTable.Enabled = true;
            if (lstTable.SelectedItems.Count > 0)
            {
                ListViewItem lvw = lstTable.SelectedItems[0];
                TableDTO sp = (TableDTO)lvw.Tag;
                txtTableName.Text = sp.NameTable;
                txtIDTable.Text = "B00" + sp.ID;
            }
        }

        private void _showTable()
        {
            lstTable.Items.Clear();
            List<TableDTO> menulist = TableBUS.GetAllListTable();
            for (int i = 0; i < menulist.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add(menulist[i].NameTable.ToString());
                listitem.SubItems.Add("B00" + menulist[i].ID.ToString());
                if (menulist[i].Status == 0)
                    listitem.SubItems.Add("Bàn trống");
                else listitem.SubItems.Add("Bàn đang có khách");
                listitem.Tag = menulist[i];
                lstTable.Items.Add(listitem);
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTableName.Text == "")
                {
                    MessageBox.Show("Bạn không thể thêm nếu như để trống một trường dữ liệu nào.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    TableDTO sp = new TableDTO
                    {
                        NameTable = txtTableName.Text,
                        Status = 0
                    };
                    if (TableBUS.InsertTable(sp))
                    {
                        _showTable();
                        _deleteTextTable();
                        MessageBox.Show("Bạn đã thêm mới thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Bạn thêm mới thất bại, thử lại.", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTable.SelectedItems.Count > 0)
                {
                    TableDTO sp = lstTable.SelectedItems[0].Tag as TableDTO;
                    Frm_XacNhan frm_XN = new Frm_XacNhan("Vui lòng nhập mật khẩu để xác nhận thao tác này!", Program.sAccount);
                    if (frm_XN.ShowDialog() == DialogResult.OK)
                    {
                        if (AccountBUS.IsLogin(Program.sAccount.ID, frm_XN.txtXacNhap.Text))
                        {
                            if (sp.Status == 0)
                            {
                                if (TableBUS.DeleteTable(sp) == true)
                                {
                                    btnDeleteTable.Enabled = false;
                                    MessageBox.Show("Bàn bạn chọn đã được xóa khỏi hệ thống", "Thông báo", MessageBoxButtons.OK);
                                    _showTable();
                                }
                                else
                                    MessageBox.Show("Xóa bàn thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK);
                            }
                            else MessageBox.Show("Bàn " + sp.ID + " hiện chưa được thanh toán không thể xóa khỏi hệ thống!", "Thông báo", MessageBoxButtons.OK);
                        }
                        else MessageBox.Show("Bạn nhập sai mật khẩu vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn bàn để thực hiện!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            _deleteTextTable();
        }

        private void _deleteTextTable()
        {
            txtTableName.Text = "";
            txtIDTable.Text = "";
            btnDeleteTable.Enabled = false;
        }

        private void btnOutTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _showAccount()
        {
            lstAccount.Items.Clear();
            List<AccountDTO> menulist = AccountBUS.GetAllListAccount();
            for (int i = 0; i < menulist.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add("03060" + menulist[i].ID.ToString());
                listitem.SubItems.Add(menulist[i].Name);
                listitem.SubItems.Add(menulist[i].PlaceOfBirth);
                listitem.SubItems.Add(menulist[i].Telephone);
                listitem.SubItems.Add(menulist[i].Address);
                listitem.SubItems.Add(Position.GetName(menulist[i].Right));
                listitem.SubItems.Add(menulist[i].SalaryByCa.ToString("###,### VNĐ"));
                if (menulist[i].Status == 0)
                {
                    listitem.SubItems.Add("Bị khóa");
                }
                else
                    listitem.SubItems.Add("Đã được mở khóa");
                listitem.SubItems.Add(menulist[i].PassPort);
                listitem.Tag = menulist[i];
                lstAccount.Items.Add(listitem);
            }
        }
        //
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text == "" || txtTelephone.Text == "" ||
                    txtAddress.Text == "" ||
                    txtCMND.Text == "")
                {
                    MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin nhé!\n gồm: Họ tên, Số điện thoại, địa chỉ, số CMND và Lương", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    double salary = string.IsNullOrEmpty(txtSalary.Text) ? 0 : Convert.ToDouble(txtSalary.Text);
                    if (salary > 0)
                    {
                        if (txtCMND.Text.Length >= 9 && txtCMND.Text.Length <= 15)
                        {
                            if (txtTelephone.Text.Length == 10 || txtTelephone.Text.Length == 11)
                            {
                                AccountDTO sp = new AccountDTO
                                {
                                    PassWord = PASSWORD_DEFAULT,//
                                    Name = txtHoTen.Text,//
                                    PassPort = txtCMND.Text,
                                    PlaceOfBirth = txtNoiSinh.Text,
                                    Telephone = txtTelephone.Text,//
                                    Address = txtAddress.Text,//
                                    SalaryByCa = Convert.ToDouble(txtSalary.Text)
                                };
                                var chucVu = cbxChucVu.SelectedItem as ChucVu;
                                sp.Right = chucVu.ID;
                                if (radHienAccount.Checked) // 0 không hoạt động 1: hoạt động//
                                {
                                    sp.Status = 1;
                                }
                                else
                                    sp.Status = 0;
                                if (AccountBUS.InsertAccount(sp))
                                {
                                    _deleteTextAccount();
                                    _showAccount();
                                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK);
                                    txtNameAcount.ReadOnly = false;
                                }
                                else
                                    MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK);
                            }
                            else MessageBox.Show("Số điện thoại phải có 10 hoặc 11 số"); // Tiếp tục làm nhé;
                        }
                        else
                        {
                            MessageBox.Show("Số chứng minh nhân dân nằm trong khoảng 9 - 15 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lương nhân viên phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoTen.Text == "" || txtTelephone.Text == "" ||
                    txtAddress.Text == "" ||
                    txtCMND.Text == "" || txtSalary.Text == "")
                {
                    MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin nhé!\n gồm: Họ tên, Số điện thoại, địa chỉ, số CMND và Lương", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    double salary = string.IsNullOrEmpty(txtSalary.Text) ? 0 : Convert.ToDouble(txtSalary.Text);
                    if (salary > 0)
                    {
                        if (txtCMND.Text.Length >= 9 && txtCMND.Text.Length <= 15)
                        {
                            if (txtTelephone.Text.Length >= 10 && txtTelephone.Text.Length <= 11)
                            {
                                if (lstAccount.SelectedItems.Count > 0)
                                {
                                    AccountDTO sp = lstAccount.SelectedItems[0].Tag as AccountDTO;
                                    sp.PassWord = PASSWORD_DEFAULT;
                                    sp.Name = txtHoTen.Text;
                                    sp.PlaceOfBirth = txtNoiSinh.Text;
                                    sp.Telephone = txtTelephone.Text;
                                    sp.Address = txtAddress.Text;
                                    sp.PassPort = txtCMND.Text;
                                    sp.SalaryByCa = Convert.ToDouble(txtSalary.Text);

                                    var chucVu = cbxChucVu.SelectedItem as ChucVu;
                                    sp.Right = chucVu.ID;

                                    if (radHienAccount.Checked)
                                    {
                                        sp.Status = 1;
                                    }
                                    else
                                        sp.Status = 0;
                                    if (sp.ID == Program.sAccount.ID && sp.Status == 0)
                                    {
                                        MessageBox.Show("Bạn không thể khóa chính bạn.", "Thông báo", MessageBoxButtons.OK);
                                    }
                                    else
                                    {
                                        if (AccountBUS.UpdateAccount(sp))
                                        {
                                            _showAccount();
                                            MessageBox.Show("Bạn đã cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                            _deleteTextAccount();
                                            txtNameAcount.ReadOnly = false;
                                            btnEditAccount.Visible = false;
                                            btnAddAccount.Visible = true;
                                            btnDeleteAccount.Enabled = false;
                                            if (sp.ID == Program.sAccount.ID && sp.Right == 1)
                                            {
                                                Program.sAccount = sp;
                                                Close();
                                            }
                                        }
                                        else
                                            MessageBox.Show("Chưa cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Chưa chọn tài khoản", "Thông báo", MessageBoxButtons.OK);
                                }
                            }
                            else MessageBox.Show("Số điện thoại phải có 10 hoặc 11 số"); // Tiếp tục làm nhé;
                        }
                        else
                        {
                            MessageBox.Show("Số chứng minh nhân dân nằm trong khoảng 9 - 15 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lương nhân viên phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void lstAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNameAcount.ReadOnly = true;
            if (lstAccount.SelectedItems.Count > 0)
            {
                btnKhoiPhuc.Enabled = true;
                btnDeleteAccount.Enabled = true;
                txtPassword.ReadOnly = true;
                btnEditAccount.Visible = true;
                btnAddAccount.Visible = false;
                ListViewItem lvw = lstAccount.SelectedItems[0];
                AccountDTO sp = (AccountDTO)lvw.Tag;
                txtNameAcount.Text = "03060" + sp.ID.ToString();
                txtPassword.Text = sp.PassWord;
                txtHoTen.Text = sp.Name;
                txtCMND.Text = sp.PassPort;
                txtNoiSinh.Text = sp.PlaceOfBirth;
                txtTelephone.Text = sp.Telephone;
                txtAddress.Text = sp.Address;
                txtSalary.Text = sp.SalaryByCa.ToString();
                cbxChucVu.SelectedIndex = sp.Right;

                if (sp.Status == 0)
                {
                    radAnAccount.Checked = true;
                }
                else
                {
                    radHienAccount.Checked = true;
                }
            }
        }

        private void _deleteTextAccount()
        {
            btnDeleteAccount.Enabled = false;
            txtPassword.Enabled = false;
            btnEditAccount.Visible = false;
            btnAddAccount.Visible = true;
            txtNameAcount.ReadOnly = false;
            txtNameAcount.Text = "";
            txtPassword.Text = "";
            txtHoTen.Text = "";
            txtTelephone.Text = "";
            txtCMND.Text = "";
            txtAddress.Text = "";
            
            radHienAccount.Checked = true;
            radAnAccount.Checked = false;
            txtNoiSinh.Text = "";
            btnDeleteAccount.Enabled = false;
            txtSalary.Text = "0";

            btnKhoiPhuc.Enabled = false;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAccount.SelectedItems.Count > 0)
                {
                    ListViewItem lvw = lstAccount.SelectedItems[0];
                    AccountDTO sp = (AccountDTO)lvw.Tag;
                    if (sp.ID.CompareTo(Program.sAccount.ID) == 0)
                    {
                        MessageBox.Show("Bạn không thể sử dụng chức năng này với chính bạn.", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Frm_XacNhan frm_XN = new Frm_XacNhan("Bạn vui lòng nhập mật khẩu để xác nhận thao tác này!", Program.sAccount);
                        if (frm_XN.ShowDialog() == DialogResult.OK)
                        {
                            if (AccountBUS.IsLogin(Program.sAccount.ID, frm_XN.txtXacNhap.Text))
                            {
                                if (!BillBUS.IsExistAccountInBill(sp.ID))
                                {
                                    if (AccountBUS.DeleteAccount(sp) == true)
                                    {
                                        MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                                        _showAccount();
                                        _deleteTextAccount();
                                        txtNameAcount.ReadOnly = false;
                                        btnEditAccount.Visible = false;
                                        btnAddAccount.Visible = true;
                                        btnDeleteAccount.Enabled = false;
                                    }
                                    else
                                        MessageBox.Show("Xóa tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK);
                                }
                                else
                                    MessageBox.Show("Tài khoản này đang hoạt động với hệ thống. Nên bạn không thể xóa tài khoản này khỏi hệ thống.", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                                MessageBox.Show("Bạn đã nhập sai mật khẩu, vui lòng quay lại sau.", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                    MessageBox.Show("Bạn chưa chọn được tài khoản nào.", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            _deleteTextAccount();
            _showAccount();
        }

        private void btnOutAccount_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void frm_QuanLy_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = DateTime.Now;

            cbTypeProduct.ContextMenu = new ContextMenu();
            cbLocLoaiSP.ContextMenu = new ContextMenu();
            txtPassword.Enabled = false;
            btnKhoiPhuc.Enabled = false;
            _loadListBill();
            List<TypeProductDTO> listtype = TypeProductBUS.GetAllListTypeProduct();
            cbLocLoaiSP.DataSource = listtype;
            cbLocLoaiSP.ValueMember = "ID";
            cbLocLoaiSP.DisplayMember = "NameType";
            if (cbLocLoaiSP.SelectedItem != null)
            {
                _loadProductListByTypeProductID(Convert.ToInt32(cbLocLoaiSP.SelectedValue));
            }
            
            _setAutoSizeCollumn();
        }

        private void _loadListTypeProduct(ComboBox cbx)
        {
            List<TypeProductDTO> listtype = TypeProductBUS.GetAllListTypeProduct();
            cbx.DataSource = listtype;
            cbx.ValueMember = "ID";
            cbx.DisplayMember = "NameType";
        }

        private void _loadListBill()
        {
            lstRevenue.Items.Clear();
            double totalReport = 0;
            List<BillUpDTO> list = BUS.BillBUS.GetListBillInAboutTime(dtpFromDate.Value, dtpToDate.Value);
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add("HD00" + list[i].ID.ToString());
                listitem.SubItems.Add(list[i].Total == 0 ? "-" : list[i].Total.ToString("###,### VNĐ"));
                listitem.SubItems.Add(list[i].PromotionPrice == 0 ? "-" : list[i].PromotionPrice.ToString("###,### VNĐ"));
                listitem.SubItems.Add(list[i].CustomerPrice == 0 ? "-" : list[i].CustomerPrice.ToString("###,### VNĐ"));
                listitem.SubItems.Add(list[i].OutPrice == 0 ? "-" : list[i].OutPrice.ToString("###,### VNĐ"));
                listitem.SubItems.Add(list[i].Revenue == 0 ? "-" : list[i].Revenue.ToString("###,### VNĐ"));
                listitem.SubItems.Add(list[i].CreateDay.ToString("HH:mm:ss dd/MM/yyyy"));
                listitem.SubItems.Add(AccountBUS.GetNameByAccount(list[i].Employ).ToString());
                listitem.Tag = list[i];
                lstRevenue.Items.Add(listitem);

                totalReport += list[i].Revenue;
            }

            txtReportTotal.Text = "0";
            if (totalReport > 0)
            {
                txtReportTotal.Text = totalReport.ToString("###,### VNĐ");
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            lstProduct.Items.Clear();
            List<ProductDTO> list = ProductBUS.GeProductByName(txtSearchProduct.Text);
            _createListProduct(list);

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            rptThongKe rptThongKe = new rptThongKe();
            List<BillUpDTO> lstBill = BUS.BillBUS.GetListBillInAboutTime(dtpFromDate.Value, dtpToDate.Value);
            if (lstBill.Count > 0)
            {
                rptThongKe.XuatThongKeTheoThang(lstBill, dtpFromDate.Value, dtpToDate.Value, DateTime.Now, Program.sAccount.Name);
                rptThongKe.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiện tại trong khoảng thời gian này chưa có hóa đơn nào được tạo.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void cbLoaiThucUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //khi load loại loại thức uống thì sẽ gán loại theo cái thức uống.
          
            if (cbLocLoaiSP.SelectedItem == null)
                return;
            TypeProductDTO typeProduct = cbLocLoaiSP.SelectedItem as TypeProductDTO;

            _loadProductListByTypeProductID(typeProduct.ID);
        }

        private void _loadProductListByTypeProductID(int id)
        {
            lstProduct.Items.Clear();
            //load thức uống theo mã loại thức uống
            List<ProductDTO> listProduct = ProductBUS.GetListProductByIDTypeProduct(id, -1);
            for (int i = 0; i < listProduct.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add(listProduct[i].NameProducts);
                if (listProduct[i].PriceBasic == 0)
                {
                    listitem.SubItems.Add("Miễn phí");
                }
                else listitem.SubItems.Add(listProduct[i].PriceBasic.ToString("0,000 VNĐ"));

                if (listProduct[i].SalePrice == listProduct[i].PriceBasic)
                    listitem.SubItems.Add("Không có chương trình khuyến mãi");
                else
                {
                    int phantram = (int)((listProduct[i].SalePrice * 100) / listProduct[i].PriceBasic);
                    listitem.SubItems.Add("Đang giảm" + phantram + " %");
                }
                if (listProduct[i].Status == 1)
                {
                    listitem.SubItems.Add("Đang họat động");
                }
                else
                {
                    listitem.SubItems.Add("Ngưng bán");
                }
                listitem.SubItems.Add("SP00" + listProduct[i].ID);
                listitem.Tag = listProduct[i];
                lstProduct.Items.Add(listitem);
            }
        }

        private void txtNameAcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAccount.SelectedItems.Count > 0)
                {
                    AccountDTO acc = lstAccount.SelectedItems[0].Tag as AccountDTO;
                    Frm_XacNhan frm_XN = new Frm_XacNhan("Bạn vui lòng nhập mật khẩu để xác nhận thao tác này!", Program.sAccount);
                    if (frm_XN.ShowDialog() == DialogResult.OK)
                    {
                        if (AccountBUS.IsLogin(Program.sAccount.ID, frm_XN.txtXacNhap.Text))
                        {
                            if (AccountBUS.ResetAccount(acc.ID))
                            {
                                _showAccount();
                                MessageBox.Show("Đã cập nhật reset thành công", "Thông báo", MessageBoxButtons.OK);
                                _deleteTextAccount();
                                txtNameAcount.ReadOnly = false;
                                btnEditAccount.Visible = false;
                                btnAddAccount.Visible = true;
                                btnDeleteAccount.Enabled = false;
                            }
                            else
                                MessageBox.Show("Reset mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK);
                        }
                        else MessageBox.Show("Bạn đã nhập sai mật khẩu, vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn tài khoản để thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtNameAcount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            txtKeyPress_Number(sender, e);
        }

        private void txtKeyPress_Input22(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 22)
                e.Handled = true;
        }

        private void txtKeyPress_Number(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void cbTypeProduct_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void lstRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstRevenue.SelectedItems.Count > 0)
                {
                    BillUpDTO bill = lstRevenue.SelectedItems[0].Tag as BillUpDTO;
                    DialogResult kq = MessageBox.Show("Bạn có muốn xem lại hóa đơn HD00" + bill.ID + " này có gì không?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (kq == DialogResult.OK)
                    {
                        RptThanhToan frm_TToan = new RptThanhToan();
                        frm_TToan.XuatHoaDon(bill.ID, "HÓA ĐƠN ĐÃ THANH TOÁN", bill.TableName, AccountBUS.GetNameByAccount(bill.Employ), bill.CreateDay, bill.Total.ToString(), bill.PromotionPrice.ToString(), bill.CustomerPrice.ToString(), bill.OutPrice.ToString(), bill.Revenue.ToString(), false);
                        //
                        frm_TToan.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            _loadListBill();
        }

        private void _setComboxNV(List<AccountDetailDTO> lst)
        {
            cbxNhanVien.DataSource = lst;
            cbxNhanVien.DisplayMember = "Name";
            cbxNhanVien.ValueMember = "AccountID";
        }

        private void _loadListEmployeeToCombobox()
        {
            int year = (cbxThang.SelectedItem as DimTime).Year;
            int month = (cbxThang.SelectedItem as DimTime).Month;

            List<AccountDetailDTO> listtype = EmployeeHistoryBUS.GetEmployeeByMonth(month, year);
            if (listtype.Count != 0)
            {
                _setComboxNV(listtype);
                _setEnabledComboxNhanVien(true);
            }
            else
            {
                cbxNhanVien.SelectedItem = null;
                _setEnabledComboxNhanVien(false);
            }

            _loadListEmployeeSalaried(month,year);
        }


        private void _loadListEmployeeSalaried(int month, int year)
        {
            lstLuongNhanVien.Items.Clear();
            List<AccountDetailDTO> list = EmployeeHistoryBUS.GetEmployeeByMonth(month, year, true);
            double tongTien = 0;
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add("03060" + list[i].AccountID.ToString());
                listitem.SubItems.Add(list[i].Name);
                listitem.SubItems.Add(list[i].Telephone);
                listitem.SubItems.Add(list[i].Address);
                listitem.SubItems.Add(list[i].Month.ToString());
                listitem.SubItems.Add(list[i].Year.ToString());
                listitem.SubItems.Add(list[i].SalaryByCa.ToString("###,### VNĐ"));
                listitem.SubItems.Add(list[i].Ca.ToString());
                listitem.SubItems.Add(list[i].Total.ToString("###,### VNĐ"));
                listitem.SubItems.Add(list[i].Note);

                listitem.Tag = list[i];
                tongTien += list[i].Total;

                lstLuongNhanVien.Items.Add(listitem);
            }

            txtTongTienLuong.Text = "0";
            if(tongTien > 0)
            {
                txtTongTienLuong.Text = tongTien.ToString("###,### VNĐ");
            }
        }

        class DimTime
        {
            public int Year { get; set; }

            public int Month { get; set; }

            public string Text { get; set; }

            public string Format { get; set; }

            public DimTime(int year, int month, string format, string text)
            {
                Year = year;
                Month = month;
                Text = text;
                Format = format;
            }
        }

        private List<DimTime> _getDimTimes()
        {
            List<DimTime> dimTime = new List<DimTime>();
            int nLen = 12;
            for (int year = 2019; year <= DateTime.Now.Year; year++)
            {
                if (year == DateTime.Now.Year)
                {
                    nLen = DateTime.Now.Month;
                }

                for (int month = 1; month <= nLen; month++)
                {
                    string monthFormat = month < 10 ? "0" + month : month.ToString();
                    DimTime dim = new DimTime(year, month, string.Format("{0}{1}", month, year), string.Format("Tháng {0} - Năm {1}", monthFormat, year));
                    dimTime.Add(dim);
                }
            }

            return dimTime;
        }

        private void _loadMonthDoanhThu()
        {
            List<DimTime> dimTime = _getDimTimes();
            
            cbxFromMonth.DataSource = dimTime;
            cbxFromMonth.DisplayMember = "Text";
            cbxFromMonth.ValueMember = "Format";

            cbxToMonth.DataSource = dimTime.ToArray();
            cbxToMonth.DisplayMember = "Text";
            cbxToMonth.ValueMember = "Format";

            _setDimTimeForDoanhThu();
        }

        private void _loadMonth()
        {
            List<DimTime> dimTime = _getDimTimes();

            cbxThang.DataSource = dimTime;
            cbxThang.DisplayMember = "Text";
            cbxThang.ValueMember = "Format";

            _setDateTime();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCaMonth.Text))
            {
                Double.TryParse(txtCaMonth.Text, out double ca);
                if (ca != 0)
                {
                    int idNhanvien = (cbxNhanVien.SelectedItem as AccountDetailDTO).AccountID;
                    double salary = (cbxNhanVien.SelectedItem as AccountDetailDTO).SalaryByCa;
                    int month = (cbxThang.SelectedItem as DimTime).Month;
                    int year = (cbxThang.SelectedItem as DimTime).Year;

                    if (idNhanvien != 0 &&
                        month != 0 &&
                        year != 0)
                    {
                        EmployeeHistoryDTO emp = new EmployeeHistoryDTO()
                        {
                            Year = year,
                            Month = month,
                            Ca = ca,
                            AccountID = idNhanvien,
                            SalaryByCa = salary,
                            Note = txtGhiChuLuong.Text
                        };

                        if (isAddSalary && EmployeeHistoryBUS.Add(emp))
                        {
                            btnLamMoiNhanVien_Click(sender, e);
                            MessageBox.Show("Tính lương thành công.");
                        }
                        else if (!isAddSalary && EmployeeHistoryBUS.Update(emp))
                        {
                            btnLamMoiNhanVien_Click(sender, e);
                            MessageBox.Show("Cập nhật lương thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Tính lương thất bại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số ca trong tháng cho nhân viên");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số ca trong tháng cho nhân viên");
            }
        }

        private void _setDateTime()
        {
            cbxThang.SelectedValue = string.Format("{0}{1}", DateTime.Now.Month, DateTime.Now.Year);
        }

        private void _setDateTime(int month,int year)
        {
            cbxThang.SelectedValue = string.Format("{0}{1}", month, year);
        }
        
        private void btnLamMoiNhanVien_Click(object sender, EventArgs e)
        {
            _setDateTime();
            _setEnabledComboboxNhanVienAndThang(true);
            _loadListEmployeeToCombobox();
            _setAddStatusSalaryEmployee();

            txtCaMonth.Text = "";
            _setAutoSizeCollumn();
        }

        private void _setEnabledComboxNhanVien(bool value)
        {
            btnThemLuong.Enabled = value;
            cbxNhanVien.Enabled = value;
        }

        private void _setEnabledComboboxNhanVienAndThang(bool value)
        {
            cbxThang.Enabled = value;
            _setEnabledComboxNhanVien(value);
        }

        private void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            _loadListEmployeeToCombobox();
            int year = (cbxThang.SelectedItem as DimTime).Year;
            int month = (cbxThang.SelectedItem as DimTime).Month;

            _loadListEmployeeSalaried(month, year);
        }

        private void _setNhanVien(int id)
        {
            cbxNhanVien.SelectedValue = id;
        }

        private bool isAddSalary = true;
        private void _setAddStatusSalaryEmployee(bool isAdd = true)
        {
            btnThemLuong.Text = isAdd ? "Thêm mới" : "Chỉnh sửa";
            isAddSalary = isAdd;
        }

        private void lstLuongNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLuongNhanVien.SelectedItems.Count > 0)
            {
                var nv = (lstLuongNhanVien.SelectedItems[0].Tag as AccountDetailDTO);
                var lst = new List<AccountDetailDTO>() { nv };
                _setComboxNV(lst);
                _setNhanVien(nv.AccountID);
                _setDateTime(nv.Month,nv.Year);
                _setEnabledComboboxNhanVienAndThang(false);
                btnThemLuong.Enabled = true;
                txtCaMonth.Text = nv.Ca.ToString();

                _setAddStatusSalaryEmployee(false);
            }
        }

        private void btnSuaLuong_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCaMonth.Text))
            {
                Double.TryParse(txtCaMonth.Text, out double ca);
                if (ca != 0)
                {
                    int idNhanvien = (cbxNhanVien.SelectedItem as AccountDetailDTO).AccountID;
                    double salary = (cbxNhanVien.SelectedItem as AccountDetailDTO).SalaryByCa;
                    int month = (cbxThang.SelectedItem as DimTime).Month;
                    int year = (cbxThang.SelectedItem as DimTime).Year;

                    if (idNhanvien != 0 &&
                        month != 0 &&
                        year != 0)
                    {
                        EmployeeHistoryDTO emp = new EmployeeHistoryDTO()
                        {
                            Year = year,
                            Month = month,
                            Ca = ca,
                            AccountID = idNhanvien,
                            SalaryByCa = salary
                        };

                        if (EmployeeHistoryBUS.Update(emp))
                        {
                            btnLamMoiNhanVien_Click(sender, e);
                            MessageBox.Show("Tính lương thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Tính lương thất bại.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số ca trong tháng cho nhân viên");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số ca trong tháng cho nhân viên");
            }
        }

        private bool isAddNL = true;

        private void _setAddNguyenLieu(bool isAdd = true)
        {
            btnLuuNL.Text = isAdd ? "Thêm mới" : "Chỉnh sửa";
            isAddNL = isAdd;
        }

        private void btnLuuNL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNL.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu.");
                return;
            }

            if (string.IsNullOrEmpty(txtGiaNL.Text))
            {
                MessageBox.Show("Vui lòng nhập giá nguyên liệu.");
                return;
            }

            Double.TryParse(txtGiaNL.Text, out double giaNL);
            if(giaNL <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá nguyên liệu.");
                return;
            }

            int id = lstNguyenLieu.SelectedItems.Count == 0 ? 0 :(lstNguyenLieu.SelectedItems[0].Tag as InventoryDTO) != null ? (lstNguyenLieu.SelectedItems[0].Tag as InventoryDTO).ID : 0;
            var inventory = new InventoryDTO()
            {
                ID = id,
                PriceBase = giaNL,
                Name = txtTenNL.Text,
                Note = txtGhiChuNL.Text
            };

            if (isAddNL && InventoryBUS.Add(inventory))
            {
                _setClearInventoryView();

                MessageBox.Show("Thêm nguyên vật liệu thành công.");
            }
            else if (!isAddNL && InventoryBUS.Update(inventory))
            {
                _setClearInventoryView();

                MessageBox.Show("Cập nhật nguyên vật liệu thành công.");
            }
            else
            {
                MessageBox.Show("Lưu nguyên vật liệu thất bại.");
            }
        }

        private void _loadListInventory()
        {
            lstNguyenLieu.Items.Clear();
            List<InventoryDTO> lst = InventoryBUS.GetInventoryByTimeNow();
            double tongTien = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add("IN00" + lst[i].ID.ToString());
                listitem.SubItems.Add(lst[i].Name);
                listitem.SubItems.Add(lst[i].CreatedDate.ToString("dd/MM/yyyy"));
                listitem.SubItems.Add(lst[i].PriceBase.ToString("###,### VNĐ"));
                listitem.SubItems.Add(lst[i].Note);

                listitem.Tag = lst[i];
                tongTien += lst[i].PriceBase;
                lstNguyenLieu.Items.Add(listitem);
            }

            txtTongGiaNL.Text = "0";
            if (tongTien > 0)
            {
                txtTongGiaNL.Text = tongTien.ToString("###,### VNĐ");
            }
        }

        private void _setClearInventoryView()
        {
            txtTenNL.Text = "";
            txtGiaNL.Text = "";
            txtGhiChuNL.Text = "";

            _loadListInventory();
            _setEnabledDeleteInventory(false);
            _setAddNguyenLieu(true);

            _setAutoSizeCollumn();
        }

        private void _setEnabledDeleteInventory(bool isEnabled)
        {
            btnXoaNL.Enabled = isEnabled;
        }

        private void btnLamMoiNL_Click(object sender, EventArgs e)
        {
            _setClearInventoryView();
        }

        private void lstNguyenLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNguyenLieu.SelectedItems.Count > 0)
            {
                var invent = (lstNguyenLieu.SelectedItems[0].Tag as InventoryDTO);
                txtMaNL.Text = "IN00" + invent.ID.ToString();
                txtTenNL.Text = invent.Name;
                txtGiaNL.Text = invent.PriceBase.ToString();
                txtGhiChuNL.Text = invent.Note;

                _setEnabledDeleteInventory(true);
                _setAddNguyenLieu(false);
            }
        }

        private void btnXoaNL_Click(object sender, EventArgs e)
        {
            if (lstNguyenLieu.SelectedItems.Count > 0)
            {
                var invent = (lstNguyenLieu.SelectedItems[0].Tag as InventoryDTO);
                Frm_XacNhan frm_XN = new Frm_XacNhan("Bạn vui lòng nhập mật khẩu để xác nhận thao tác này!", Program.sAccount);
                if (frm_XN.ShowDialog() == DialogResult.OK)
                {
                    if (InventoryBUS.Delete(invent.ID))
                    {
                        _setClearInventoryView();

                        MessageBox.Show("Xóa nguyên vật liệu thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nguyên vật liệu thất bại.");
                    }
                }
            }
        }

        private void _setDimTimeForDoanhThu()
        {
            cbxFromMonth.SelectedValue = string.Format("{0}{1}", 1, DateTime.Now.Year);

            cbxToMonth.SelectedValue = string.Format("{0}{1}", DateTime.Now.Month, DateTime.Now.Year);
        }

        private void btnLamMoiDoanhThu_Click(object sender, EventArgs e)
        {
            _setDimTimeForDoanhThu();
            _setAutoSizeCollumn();

            _loadRevenue();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            _loadRevenue();
        }

        private void _loadRevenue()
        {
            int fromMonth = (cbxFromMonth.SelectedItem as DimTime).Month;
            int fromYear= (cbxFromMonth.SelectedItem as DimTime).Year;
            int toMonth = (cbxToMonth.SelectedItem as DimTime).Month;
            int toYear= (cbxToMonth.SelectedItem as DimTime).Year;

            lstDoanhThu.Items.Clear();
            List<RevenueDTO> lst = RevenueBUS.GetRevenueByMonth(fromMonth, fromYear, toMonth, toYear);
            double tongTien = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                ListViewItem listitem = new ListViewItem
                {
                    Text = "#" + (i + 1).ToString()
                };
                listitem.SubItems.Add(lst[i].Month == 0 ? "Tổng" : lst[i].Month.ToString());
                listitem.SubItems.Add(lst[i].Year == 0 ? "Tổng" :  lst[i].Year.ToString());

                listitem.SubItems.Add(lst[i].TotalBill == 0 ? "-" : lst[i].TotalBill.ToString("###,### VNĐ"));

                listitem.SubItems.Add(lst[i].TotalInventory == 0 ? "-" : lst[i].TotalInventory.ToString("###,### VNĐ"));

                listitem.SubItems.Add(lst[i].TotalSalary == 0 ? "-" : lst[i].TotalSalary.ToString("###,### VNĐ"));

                listitem.SubItems.Add(lst[i].TotalRevenue == 0 ? "-" : lst[i].TotalRevenue.ToString("###,### VNĐ"));

                listitem.Tag = lst[i];
                if (lst[i].Month != 0)
                {
                    tongTien += lst[i].TotalRevenue;
                }

                lstDoanhThu.Items.Add(listitem);
            }

            txtTongDoanhThu.Text = "0";
            if (tongTien != 0)
            {
                txtTongDoanhThu.Text = tongTien.ToString("###,### VNĐ");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int fromMonth = (cbxFromMonth.SelectedItem as DimTime).Month;
            int fromYear = (cbxFromMonth.SelectedItem as DimTime).Year;
            int toMonth = (cbxToMonth.SelectedItem as DimTime).Month;
            int toYear = (cbxToMonth.SelectedItem as DimTime).Year;

            rptThongKeDoanhThu rptThongKeDoanhThu = new rptThongKeDoanhThu();
            List<RevenueDTO> lstRevenue = RevenueBUS.GetRevenueByMonth(fromMonth, fromYear, toMonth, toYear);
            if (lstRevenue.Count > 0)
            {
                rptThongKeDoanhThu.XuatThongKeTheoThang(lstRevenue, DateTime.Now, String.Format("{0}/{1}", fromMonth,fromYear), String.Format("{0}/{1}", toMonth, toYear), Program.sAccount.Name);
                rptThongKeDoanhThu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hiện tại trong khoảng thời gian này chưa có hóa đơn nào được tạo.", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}


class ChucVu
{
    public int ID { get; set; }

    public string Name { get; set; }
}

public static class Position
{
    private static Dictionary<int, string> positon = new Dictionary<int, string>();

    public static string GetName(int id)
    {
        positon.Clear();

        positon.Add(0, "Quản lý");
        positon.Add(1, "Nhân Viên Bán Hàng");
        positon.Add(2, "Đầu bếp");
        positon.Add(3, "Phụ bếp");

        if (positon.ContainsKey(id))
        {
            return positon[id];
        }

        return "Not found positon.";
    }
}
