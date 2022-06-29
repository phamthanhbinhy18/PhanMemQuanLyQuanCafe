namespace MS.Main
{
    partial class Frm_ThanhToan
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienTon = new System.Windows.Forms.TextBox();
            this.txtHuy = new System.Windows.Forms.Button();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMaHD = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "YÊU CẦU THANH TOÁN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.AllowDrop = true;
            this.btnXuatHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHD.Location = new System.Drawing.Point(170, 282);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(123, 40);
            this.btnXuatHD.TabIndex = 5;
            this.btnXuatHD.Text = "Xuất hóa đơn";
            this.btnXuatHD.UseVisualStyleBackColor = true;
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã HD:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số tiền của khách:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSTK
            // 
            this.txtSTK.AllowDrop = true;
            this.txtSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTK.Location = new System.Drawing.Point(186, 117);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.ShortcutsEnabled = false;
            this.txtSTK.Size = new System.Drawing.Size(190, 27);
            this.txtSTK.TabIndex = 0;
            this.txtSTK.Text = "0";
            this.txtSTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSTK.TextChanged += new System.EventHandler(this.txtSTK_TextChanged);
            this.txtSTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTK_KeyPress);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tổng tiền:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTongTien
            // 
            this.txtTongTien.AllowDrop = true;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(186, 150);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ShortcutsEnabled = false;
            this.txtTongTien.Size = new System.Drawing.Size(190, 27);
            this.txtTongTien.TabIndex = 1;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiền thừa:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTienTon
            // 
            this.txtTienTon.AllowDrop = true;
            this.txtTienTon.Enabled = false;
            this.txtTienTon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienTon.Location = new System.Drawing.Point(186, 183);
            this.txtTienTon.Name = "txtTienTon";
            this.txtTienTon.ShortcutsEnabled = false;
            this.txtTienTon.Size = new System.Drawing.Size(190, 27);
            this.txtTienTon.TabIndex = 2;
            this.txtTienTon.Text = "0";
            this.txtTienTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHuy
            // 
            this.txtHuy.AllowDrop = true;
            this.txtHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuy.Location = new System.Drawing.Point(311, 282);
            this.txtHuy.Name = "txtHuy";
            this.txtHuy.Size = new System.Drawing.Size(65, 40);
            this.txtHuy.TabIndex = 6;
            this.txtHuy.Text = "Hủy";
            this.txtHuy.UseVisualStyleBackColor = true;
            this.txtHuy.Click += new System.EventHandler(this.txtHuy_Click);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(182, 43);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(190, 27);
            this.lblThoiGian.TabIndex = 16;
            this.lblThoiGian.Text = "Thời gian";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "(vnđ)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "(vnđ)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "(vnđ)";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ngày lập:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txtMaHD.Location = new System.Drawing.Point(186, 80);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(190, 27);
            this.txtMaHD.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Giảm giá:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPromotion
            // 
            this.txtPromotion.AllowDrop = true;
            this.txtPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromotion.Location = new System.Drawing.Point(186, 216);
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.ShortcutsEnabled = false;
            this.txtPromotion.Size = new System.Drawing.Size(190, 27);
            this.txtPromotion.TabIndex = 3;
            this.txtPromotion.Text = "0";
            this.txtPromotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPromotion.TextChanged += new System.EventHandler(this.txtSTK_TextChanged);
            this.txtPromotion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSTK_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(381, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "(vnđ)";
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "Thành tiền:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AllowDrop = true;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(186, 249);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ShortcutsEnabled = false;
            this.txtThanhTien.Size = new System.Drawing.Size(190, 27);
            this.txtThanhTien.TabIndex = 4;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(382, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "(vnđ)";
            // 
            // Frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 331);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.txtHuy);
            this.Controls.Add(this.txtTienTon);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtPromotion);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuatHD);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_ThanhToan";
            this.Text = "Thực hiện thanh toán";
            this.Load += new System.EventHandler(this.frm_ThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXuatHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienTon;
        private System.Windows.Forms.Button txtHuy;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtMaHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label13;
    }
}