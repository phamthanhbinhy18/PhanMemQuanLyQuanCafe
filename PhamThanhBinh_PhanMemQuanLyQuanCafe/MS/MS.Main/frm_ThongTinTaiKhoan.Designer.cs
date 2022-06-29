namespace MS.Main
{
    partial class Frm_ThongTinTaiKhoan
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
            panel3 = new System.Windows.Forms.Panel();
            lblSDT = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblNoiSinh = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel7 = new System.Windows.Forms.Panel();
            lblDiaChi = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            btnDMK = new System.Windows.Forms.Button();
            btnOut = new System.Windows.Forms.Button();
            panel16 = new System.Windows.Forms.Panel();
            lblName = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel16.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(btnDMK);
            panel1.Controls.Add(btnOut);
            panel1.Controls.Add(panel16);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            panel1.Location = new System.Drawing.Point(4, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(388, 270);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblSDT);
            panel3.Controls.Add(label5);
            panel3.Location = new System.Drawing.Point(10, 85);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(368, 39);
            panel3.TabIndex = 15;
            // 
            // lblSDT
            // 
            lblSDT.Location = new System.Drawing.Point(163, 7);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new System.Drawing.Size(196, 27);
            lblSDT.TabIndex = 2;
            lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label5.Location = new System.Drawing.Point(3, 7);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(153, 27);
            label5.TabIndex = 1;
            label5.Text = "Số điện thoại:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblNoiSinh);
            panel2.Controls.Add(label3);
            panel2.Location = new System.Drawing.Point(10, 44);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(368, 39);
            panel2.TabIndex = 14;
            // 
            // lblNoiSinh
            // 
            lblNoiSinh.Location = new System.Drawing.Point(163, 7);
            lblNoiSinh.Name = "lblNoiSinh";
            lblNoiSinh.Size = new System.Drawing.Size(196, 27);
            lblNoiSinh.TabIndex = 2;
            lblNoiSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.Location = new System.Drawing.Point(3, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(153, 27);
            label3.TabIndex = 1;
            label3.Text = "Nơi sinh:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblDiaChi);
            panel7.Controls.Add(label7);
            panel7.Location = new System.Drawing.Point(10, 126);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(368, 101);
            panel7.TabIndex = 13;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new System.Drawing.Point(168, 10);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new System.Drawing.Size(190, 80);
            lblDiaChi.TabIndex = 3;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label7.Location = new System.Drawing.Point(13, 10);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(143, 24);
            label7.TabIndex = 1;
            label7.Text = "Địa chỉ:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDMK
            // 
            btnDMK.Location = new System.Drawing.Point(93, 233);
            btnDMK.Name = "btnDMK";
            btnDMK.Size = new System.Drawing.Size(180, 33);
            btnDMK.TabIndex = 10;
            btnDMK.Text = "Đổi mật khẩu";
            btnDMK.UseVisualStyleBackColor = true;
            btnDMK.Click += new System.EventHandler(btnDMK_Click);
            // 
            // btnOut
            // 
            btnOut.Location = new System.Drawing.Point(279, 233);
            btnOut.Name = "btnOut";
            btnOut.Size = new System.Drawing.Size(99, 33);
            btnOut.TabIndex = 9;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += new System.EventHandler(btnOut_Click);
            // 
            // panel16
            // 
            panel16.Controls.Add(lblName);
            panel16.Controls.Add(label6);
            panel16.Location = new System.Drawing.Point(10, 3);
            panel16.Name = "panel16";
            panel16.Size = new System.Drawing.Size(368, 39);
            panel16.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.Location = new System.Drawing.Point(163, 8);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(196, 27);
            lblName.TabIndex = 2;
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label6.Location = new System.Drawing.Point(3, 7);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(153, 27);
            label6.TabIndex = 1;
            label6.Text = "Họ và tên:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            label23.BackColor = System.Drawing.Color.LightPink;
            label23.Dock = System.Windows.Forms.DockStyle.Top;
            label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label23.ForeColor = System.Drawing.Color.Maroon;
            label23.Location = new System.Drawing.Point(0, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(396, 35);
            label23.TabIndex = 1;
            label23.Text = "THÔNG TIN CÁ NHÂN";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ThongTinTaiKhoan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(396, 311);
            Controls.Add(label23);
            Controls.Add(panel1);
            Name = "frm_ThongTinTaiKhoan";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            Load += new System.EventHandler(frm_ThongTinTaiKhoan_Load);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel16.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnDMK;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNoiSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label23;
    }
}