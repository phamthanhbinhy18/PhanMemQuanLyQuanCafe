namespace MS.Main
{
    partial class Frm_ThongTinChiTietSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label26 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnThoat = new System.Windows.Forms.Button();
            lblTotal = new System.Windows.Forms.Label();
            lblPrice = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            btnDelete = new System.Windows.Forms.Button();
            btnAccept = new System.Windows.Forms.Button();
            cbQuantity = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label26
            // 
            label26.BackColor = System.Drawing.Color.Gray;
            label26.Dock = System.Windows.Forms.DockStyle.Top;
            label26.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label26.ForeColor = System.Drawing.Color.White;
            label26.Location = new System.Drawing.Point(0, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(406, 35);
            label26.TabIndex = 13;
            label26.Text = "THÔNG TIN SẢN PHẨM KHÁCH HÀNG CHỌN";
            label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(lblPrice);
            groupBox1.Controls.Add(lblProductName);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAccept);
            groupBox1.Controls.Add(cbQuantity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            groupBox1.Location = new System.Drawing.Point(4, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(397, 262);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm trong danh mục order";
            // 
            // btnThoat
            // 
            btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnThoat.Location = new System.Drawing.Point(274, 209);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(99, 36);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += new System.EventHandler(btnThoat_Click);
            // 
            // lblTotal
            // 
            lblTotal.Location = new System.Drawing.Point(189, 122);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(177, 34);
            lblTotal.TabIndex = 18;
            lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            lblPrice.Location = new System.Drawing.Point(189, 77);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(177, 34);
            lblPrice.TabIndex = 18;
            lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductName
            // 
            lblProductName.Location = new System.Drawing.Point(189, 28);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(177, 34);
            lblProductName.TabIndex = 18;
            lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            btnDelete.Location = new System.Drawing.Point(138, 209);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(130, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Hủy sản phẩm";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            // 
            // btnAccept
            // 
            btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            btnAccept.Location = new System.Drawing.Point(26, 209);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new System.Drawing.Size(106, 36);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Lưu lại";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // cbQuantity
            // 
            cbQuantity.DisplayMember = "20";
            cbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            cbQuantity.FormattingEnabled = true;
            cbQuantity.Location = new System.Drawing.Point(186, 170);
            cbQuantity.Name = "cbQuantity";
            cbQuantity.Size = new System.Drawing.Size(179, 28);
            cbQuantity.TabIndex = 0;
            cbQuantity.ValueMember = "20";
            cbQuantity.SelectedIndexChanged += new System.EventHandler(cbQuantity_SelectedIndexChanged);
            cbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(cbQuantity_KeyPress);
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label2.Location = new System.Drawing.Point(37, 170);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 24);
            label2.TabIndex = 14;
            label2.Text = "Số lượng:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label4.Location = new System.Drawing.Point(39, 127);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(143, 24);
            label4.TabIndex = 10;
            label4.Text = "Thành tiền:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.Location = new System.Drawing.Point(39, 82);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(143, 24);
            label3.TabIndex = 11;
            label3.Text = "Giá:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.Location = new System.Drawing.Point(39, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 24);
            label1.TabIndex = 8;
            label1.Text = "Tên sản phẩm:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_ThongTinChiTietSanPham
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new System.Drawing.Size(406, 304);
            Controls.Add(groupBox1);
            Controls.Add(label26);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "frm_ThongTinChiTietSanPham";
            Text = "Thông tin sản phẩm yêu cầu";
            Load += new System.EventHandler(fDetailOneProductBill_Load);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cbQuantity;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnThoat;
    }
}