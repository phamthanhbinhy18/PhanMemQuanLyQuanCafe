namespace MS.Main
{
    partial class Frm_XacNhan
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
            lblThongBao = new System.Windows.Forms.Label();
            txtXacNhap = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblThongBao
            // 
            lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblThongBao.Location = new System.Drawing.Point(12, 9);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new System.Drawing.Size(357, 71);
            lblThongBao.TabIndex = 0;
            lblThongBao.Text = "Điều này rất quan trọng với hệ thống, ";
            lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtXacNhap
            // 
            txtXacNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtXacNhap.Location = new System.Drawing.Point(152, 82);
            txtXacNhap.Name = "txtXacNhap";
            txtXacNhap.ShortcutsEnabled = false;
            txtXacNhap.Size = new System.Drawing.Size(217, 26);
            txtXacNhap.TabIndex = 1;
            txtXacNhap.UseSystemPasswordChar = true;
            txtXacNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtXacNhap_KeyPress);
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 23);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu của bạn:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCancel.Location = new System.Drawing.Point(259, 122);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(110, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.BackColor = System.Drawing.Color.PaleGreen;
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOK.Location = new System.Drawing.Point(143, 122);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(110, 36);
            btnOK.TabIndex = 4;
            btnOK.Text = "Đồng ý";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += new System.EventHandler(btnOK_Click);
            // 
            // frm_XacNhan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(379, 165);
            ControlBox = false;
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(txtXacNhap);
            Controls.Add(lblThongBao);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "frm_XacNhan";
            Text = "Thông báo";
            Load += new System.EventHandler(frm_XacNhan_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.TextBox txtXacNhap;
    }
}