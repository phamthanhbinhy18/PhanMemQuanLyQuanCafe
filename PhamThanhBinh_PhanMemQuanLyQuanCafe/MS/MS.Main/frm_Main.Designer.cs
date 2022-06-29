namespace MS.Main
{
    partial class Frm_TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
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
            txtOrder = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnDangXuat = new System.Windows.Forms.Button();
            btnOrder = new System.Windows.Forms.Button();
            btnAdmin = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            txtOrder.SuspendLayout();
            SuspendLayout();
            // 
            // txtOrder
            // 
            txtOrder.AutoScroll = true;
            txtOrder.Controls.Add(label2);
            txtOrder.Controls.Add(label1);
            txtOrder.Controls.Add(btnDangXuat);
            txtOrder.Controls.Add(btnOrder);
            txtOrder.Controls.Add(btnAdmin);
            txtOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            txtOrder.Location = new System.Drawing.Point(4, 38);
            txtOrder.Name = "txtOrder";
            txtOrder.Size = new System.Drawing.Size(604, 263);
            txtOrder.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label2.Location = new System.Drawing.Point(16, 215);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 42);
            label2.TabIndex = 5;
            label2.Text = "ĐỀ TÀI:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label1.Location = new System.Drawing.Point(92, 215);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(377, 42);
            label1.TabIndex = 4;
            label1.Text = "Phần mềm quản lý quán cafe";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            btnDangXuat.Location = new System.Drawing.Point(475, 215);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new System.Drawing.Size(111, 42);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += new System.EventHandler(btnDangXuat_Click);
            // 
            // btnOrder
            // 
            btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            btnOrder.ForeColor = System.Drawing.Color.Orange;
            btnOrder.Location = new System.Drawing.Point(306, 18);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(280, 183);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "QUẢN LÝ BÁN HÀNG";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += new System.EventHandler(btnOrder_Click);
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdmin.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAdmin.ForeColor = System.Drawing.Color.DodgerBlue;
            btnAdmin.Location = new System.Drawing.Point(16, 18);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new System.Drawing.Size(283, 183);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "QUẢN TRỊ HỆ THỐNG";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += new System.EventHandler(btnAdmin_Click);
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.LightPink;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.ForeColor = System.Drawing.Color.Maroon;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(610, 35);
            label3.TabIndex = 12;
            label3.Text = "CHÀO MỪNG BẠN ĐẾN VỚI PHẦN MỀN QUẢN LÝ";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_TrangChu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(610, 304);
            Controls.Add(label3);
            Controls.Add(txtOrder);
            Name = "frm_TrangChu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Điều hướng quản lý";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(fTrangChu_FormClosing);
            Load += new System.EventHandler(fTrangChu_Load);
            txtOrder.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel txtOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}