namespace MS.Main
{
    partial class Frm_DangNhap
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
            panel1 = new System.Windows.Forms.Panel();
            lblNotification = new System.Windows.Forms.Label();
            chkHidePass = new System.Windows.Forms.CheckBox();
            btnThoat = new System.Windows.Forms.Button();
            btnDangNhap = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            txtMatKhau = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            cbxNhanVien = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNotification);
            panel1.Controls.Add(chkHidePass);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            panel1.Location = new System.Drawing.Point(7, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(401, 249);
            panel1.TabIndex = 0;
            // 
            // lblNotification
            // 
            lblNotification.ForeColor = System.Drawing.Color.Red;
            lblNotification.Location = new System.Drawing.Point(3, 156);
            lblNotification.Name = "lblNotification";
            lblNotification.Size = new System.Drawing.Size(395, 48);
            lblNotification.TabIndex = 5;
            // 
            // chkHidePass
            // 
            chkHidePass.AutoSize = true;
            chkHidePass.Location = new System.Drawing.Point(175, 133);
            chkHidePass.Name = "chkHidePass";
            chkHidePass.Size = new System.Drawing.Size(136, 24);
            chkHidePass.TabIndex = 0;
            chkHidePass.Text = "Hiện mật khẩu";
            chkHidePass.UseVisualStyleBackColor = true;
            chkHidePass.CheckedChanged += new System.EventHandler(chkHidePass_CheckedChanged);
            // 
            // btnThoat
            // 
            btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnThoat.Location = new System.Drawing.Point(293, 207);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(90, 34);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += new System.EventHandler(btnThoat_Click);
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new System.Drawing.Point(178, 207);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new System.Drawing.Size(109, 35);
            btnDangNhap.TabIndex = 1;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += new System.EventHandler(btnDangNhap_Click);
            // 
            // panel3
            // 
            panel3.Controls.Add(txtMatKhau);
            panel3.Controls.Add(label2);
            panel3.Location = new System.Drawing.Point(3, 90);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(389, 37);
            panel3.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new System.Drawing.Point(172, 4);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.ShortcutsEnabled = false;
            txtMatKhau.Size = new System.Drawing.Size(208, 27);
            txtMatKhau.TabIndex = 0;
            txtMatKhau.Text = "1234567";
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtMatKhau_KeyPress);
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label2.Location = new System.Drawing.Point(7, 4);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 27);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxNhanVien);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(3, 41);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(389, 43);
            panel2.TabIndex = 0;
            // 
            // cbxNhanVien
            // 
            cbxNhanVien.FormattingEnabled = true;
            cbxNhanVien.Location = new System.Drawing.Point(172, 8);
            cbxNhanVien.Name = "cbxNhanVien";
            cbxNhanVien.Size = new System.Drawing.Size(208, 28);
            cbxNhanVien.TabIndex = 0;
            cbxNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(cbxNhanVien_KeyPress);
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.Location = new System.Drawing.Point(3, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 27);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.LightPink;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.ForeColor = System.Drawing.Color.Maroon;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(412, 35);
            label3.TabIndex = 10;
            label3.Text = "ĐĂNG NHẬP";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            thôngTinCáNhânToolStripMenuItem,
            helpToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 35);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(412, 31);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(162, 27);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(informationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            helpToolStripMenuItem.Text = "Thông tin phần mềm";
            helpToolStripMenuItem.Click += new System.EventHandler(helpToolStripMenuItem_Click);
            // 
            // frm_DangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new System.Drawing.Size(412, 291);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "frm_DangNhap";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += new System.EventHandler(fLogin_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chkHidePass;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

