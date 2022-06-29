namespace MS.Main
{
    partial class frm_LayLaiMatKhau
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
            panel5 = new System.Windows.Forms.Panel();
            lblThongBao = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lblNhanVien = new System.Windows.Forms.Label();
            cbxNhanVien = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            btnChange = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            txtPassOld = new System.Windows.Forms.TextBox();
            panel4 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            txtPasswwordNew = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            txtRetypePass = new System.Windows.Forms.TextBox();
            label23 = new System.Windows.Forms.Label();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(lblThongBao);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(btnChange);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel1);
            panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            panel5.Location = new System.Drawing.Point(6, 38);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(351, 248);
            panel5.TabIndex = 7;
            // 
            // lblThongBao
            // 
            lblThongBao.ForeColor = System.Drawing.Color.Red;
            lblThongBao.Location = new System.Drawing.Point(6, 0);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new System.Drawing.Size(341, 27);
            lblThongBao.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblNhanVien);
            panel3.Controls.Add(cbxNhanVien);
            panel3.Controls.Add(label5);
            panel3.Location = new System.Drawing.Point(6, 30);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(341, 36);
            panel3.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            lblNhanVien.Location = new System.Drawing.Point(136, 1);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new System.Drawing.Size(196, 32);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Visible = false;
            // 
            // cbxNhanVien
            // 
            cbxNhanVien.FormattingEnabled = true;
            cbxNhanVien.Location = new System.Drawing.Point(136, 4);
            cbxNhanVien.Name = "cbxNhanVien";
            cbxNhanVien.Size = new System.Drawing.Size(196, 28);
            cbxNhanVien.TabIndex = 0;
            cbxNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(cbxNhanVien_KeyPress);
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label5.Location = new System.Drawing.Point(3, 5);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(127, 27);
            label5.TabIndex = 1;
            label5.Text = "Tên nhân viên:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(259, 202);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(80, 37);
            button2.TabIndex = 6;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            // 
            // btnChange
            // 
            btnChange.Location = new System.Drawing.Point(117, 202);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(136, 37);
            btnChange.TabIndex = 5;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += new System.EventHandler(btnChange_Click);
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassOld);
            panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            panel2.Location = new System.Drawing.Point(6, 70);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(341, 39);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.Location = new System.Drawing.Point(13, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 24);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu cũ:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassOld
            // 
            txtPassOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            txtPassOld.Location = new System.Drawing.Point(136, 8);
            txtPassOld.Name = "txtPassOld";
            txtPassOld.ShortcutsEnabled = false;
            txtPassOld.Size = new System.Drawing.Size(197, 27);
            txtPassOld.TabIndex = 0;
            txtPassOld.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPassOld_KeyPress);
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtPasswwordNew);
            panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            panel4.Location = new System.Drawing.Point(6, 113);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(341, 39);
            panel4.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.Location = new System.Drawing.Point(13, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 24);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu mới:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPasswwordNew
            // 
            txtPasswwordNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            txtPasswwordNew.Location = new System.Drawing.Point(136, 7);
            txtPasswwordNew.Name = "txtPasswwordNew";
            txtPasswwordNew.ShortcutsEnabled = false;
            txtPasswwordNew.Size = new System.Drawing.Size(197, 27);
            txtPasswwordNew.TabIndex = 0;
            txtPasswwordNew.UseSystemPasswordChar = true;
            txtPasswwordNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPassOld_KeyPress);
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtRetypePass);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            panel1.Location = new System.Drawing.Point(6, 157);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(341, 39);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label4.Location = new System.Drawing.Point(13, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(117, 24);
            label4.TabIndex = 1;
            label4.Text = "Nhập lại:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRetypePass
            // 
            txtRetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            txtRetypePass.Location = new System.Drawing.Point(136, 5);
            txtRetypePass.Name = "txtRetypePass";
            txtRetypePass.ShortcutsEnabled = false;
            txtRetypePass.Size = new System.Drawing.Size(197, 27);
            txtRetypePass.TabIndex = 0;
            txtRetypePass.UseSystemPasswordChar = true;
            txtRetypePass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtPassOld_KeyPress);
            // 
            // label23
            // 
            label23.BackColor = System.Drawing.Color.LightPink;
            label23.Dock = System.Windows.Forms.DockStyle.Top;
            label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label23.ForeColor = System.Drawing.Color.Maroon;
            label23.Location = new System.Drawing.Point(0, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(360, 35);
            label23.TabIndex = 8;
            label23.Text = "THAY ĐỔI MẬT KHẨU";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_LayLaiMatKhau
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(360, 290);
            Controls.Add(label23);
            Controls.Add(panel5);
            Name = "frm_LayLaiMatKhau";
            Text = "Đổi mật khẩu";
            Load += new System.EventHandler(frm_LayLaiMatKhau_Load);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswwordNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label23;
    }
}