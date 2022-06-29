namespace MS.Main
{
    partial class frm_ThaoTacBan
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
            lstTableFrom = new System.Windows.Forms.ListView();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lstTableTo = new System.Windows.Forms.ListView();
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            panel1 = new System.Windows.Forms.Panel();
            cbxTableFrom = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtBillFrom = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            cbxTableTo = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtBillTo = new System.Windows.Forms.TextBox();
            panel3 = new System.Windows.Forms.Panel();
            btnNextAll = new System.Windows.Forms.Button();
            btnPreviousAll = new System.Windows.Forms.Button();
            btnNextOne = new System.Windows.Forms.Button();
            btnPreviousOne = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label23 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lstTableFrom
            // 
            lstTableFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            lstTableFrom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4,
            columnHeader9});
            lstTableFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lstTableFrom.FullRowSelect = true;
            lstTableFrom.GridLines = true;
            lstTableFrom.Location = new System.Drawing.Point(14, 131);
            lstTableFrom.Margin = new System.Windows.Forms.Padding(5);
            lstTableFrom.Name = "lstTableFrom";
            lstTableFrom.Size = new System.Drawing.Size(647, 373);
            lstTableFrom.TabIndex = 1;
            lstTableFrom.UseCompatibleStateImageBehavior = false;
            lstTableFrom.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 1;
            columnHeader1.Text = "Tên sản phẩm";
            columnHeader1.Width = 123;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 2;
            columnHeader2.Text = "SL";
            columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 3;
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 4;
            columnHeader4.Text = "Tổng tiền";
            columnHeader4.Width = 108;
            // 
            // columnHeader9
            // 
            columnHeader9.DisplayIndex = 0;
            columnHeader9.Text = "STT";
            // 
            // lstTableTo
            // 
            lstTableTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lstTableTo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader5,
            columnHeader6,
            columnHeader7,
            columnHeader8,
            columnHeader10});
            lstTableTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lstTableTo.FullRowSelect = true;
            lstTableTo.GridLines = true;
            lstTableTo.Location = new System.Drawing.Point(776, 134);
            lstTableTo.Margin = new System.Windows.Forms.Padding(5);
            lstTableTo.Name = "lstTableTo";
            lstTableTo.Size = new System.Drawing.Size(436, 373);
            lstTableTo.TabIndex = 2;
            lstTableTo.UseCompatibleStateImageBehavior = false;
            lstTableTo.View = System.Windows.Forms.View.Details;
            lstTableTo.SelectedIndexChanged += new System.EventHandler(_lstTableTo_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 1;
            columnHeader5.Text = "Tên sản phẩm";
            columnHeader5.Width = 123;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "SL";
            columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Đơn giá";
            columnHeader7.Width = 118;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tổng tiền";
            columnHeader8.Width = 108;
            // 
            // columnHeader10
            // 
            columnHeader10.DisplayIndex = 0;
            columnHeader10.Text = "STT";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxTableFrom);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBillFrom);
            panel1.Location = new System.Drawing.Point(14, 38);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(592, 88);
            panel1.TabIndex = 5;
            // 
            // cbxTableFrom
            // 
            cbxTableFrom.FormattingEnabled = true;
            cbxTableFrom.Location = new System.Drawing.Point(172, 52);
            cbxTableFrom.Name = "cbxTableFrom";
            cbxTableFrom.Size = new System.Drawing.Size(231, 28);
            cbxTableFrom.TabIndex = 4;
            cbxTableFrom.SelectedIndexChanged += new System.EventHandler(cbxIDFromTable_SelectedIndexChanged);
            cbxTableFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_cbxTableFrom_KeyPress);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(119, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Bàn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(61, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã hóa đơn:";
            // 
            // txtBillFrom
            // 
            txtBillFrom.Enabled = false;
            txtBillFrom.Location = new System.Drawing.Point(172, 15);
            txtBillFrom.Name = "txtBillFrom";
            txtBillFrom.Size = new System.Drawing.Size(231, 27);
            txtBillFrom.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbxTableTo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtBillTo);
            panel2.Location = new System.Drawing.Point(774, 38);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(497, 88);
            panel2.TabIndex = 6;
            // 
            // cbxTableTo
            // 
            cbxTableTo.FormattingEnabled = true;
            cbxTableTo.Location = new System.Drawing.Point(181, 51);
            cbxTableTo.Name = "cbxTableTo";
            cbxTableTo.Size = new System.Drawing.Size(231, 28);
            cbxTableTo.TabIndex = 8;
            cbxTableTo.SelectedIndexChanged += new System.EventHandler(cbxIDNextTable_SelectedIndexChanged);
            cbxTableTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_cbxTableFrom_KeyPress);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(126, 57);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Bàn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(70, 15);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 20);
            label5.TabIndex = 6;
            label5.Text = "Mã hóa đơn:";
            // 
            // txtBillTo
            // 
            txtBillTo.Enabled = false;
            txtBillTo.Location = new System.Drawing.Point(181, 15);
            txtBillTo.Name = "txtBillTo";
            txtBillTo.Size = new System.Drawing.Size(231, 27);
            txtBillTo.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNextAll);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnPreviousAll);
            panel3.Controls.Add(btnNextOne);
            panel3.Controls.Add(btnPreviousOne);
            panel3.Location = new System.Drawing.Point(669, 134);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(103, 370);
            panel3.TabIndex = 7;
            // 
            // btnNextAll
            // 
            btnNextAll.Location = new System.Drawing.Point(10, 247);
            btnNextAll.Name = "btnNextAll";
            btnNextAll.Size = new System.Drawing.Size(86, 38);
            btnNextAll.TabIndex = 3;
            btnNextAll.Text = ">>";
            btnNextAll.UseVisualStyleBackColor = true;
            btnNextAll.Click += new System.EventHandler(_btnNextAll_Click);
            // 
            // btnPreviousAll
            // 
            btnPreviousAll.Location = new System.Drawing.Point(10, 94);
            btnPreviousAll.Name = "btnPreviousAll";
            btnPreviousAll.Size = new System.Drawing.Size(86, 41);
            btnPreviousAll.TabIndex = 2;
            btnPreviousAll.Text = "<<";
            btnPreviousAll.UseVisualStyleBackColor = true;
            btnPreviousAll.Click += new System.EventHandler(_btnPreviousAll_Click);
            // 
            // btnNextOne
            // 
            btnNextOne.Location = new System.Drawing.Point(10, 190);
            btnNextOne.Name = "btnNextOne";
            btnNextOne.Size = new System.Drawing.Size(86, 42);
            btnNextOne.TabIndex = 1;
            btnNextOne.Text = ">";
            btnNextOne.UseVisualStyleBackColor = true;
            btnNextOne.Click += new System.EventHandler(btnNextOne_Click);
            // 
            // btnPreviousOne
            // 
            btnPreviousOne.Location = new System.Drawing.Point(10, 42);
            btnPreviousOne.Name = "btnPreviousOne";
            btnPreviousOne.Size = new System.Drawing.Size(86, 37);
            btnPreviousOne.TabIndex = 0;
            btnPreviousOne.Text = "<";
            btnPreviousOne.UseVisualStyleBackColor = true;
            btnPreviousOne.Click += new System.EventHandler(btnPreviousOne_Click);
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(10, 329);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(86, 38);
            button1.TabIndex = 9;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(_button1_Click_1);
            // 
            // label23
            // 
            label23.BackColor = System.Drawing.Color.LightPink;
            label23.Dock = System.Windows.Forms.DockStyle.Top;
            label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label23.ForeColor = System.Drawing.Color.Maroon;
            label23.Location = new System.Drawing.Point(0, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(1016, 35);
            label23.TabIndex = 10;
            label23.Text = "QUẢN LÝ SẢN PHẨM TRONG DANH MỤC GỌI SẢN PHẨM";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ThaoTacBan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1016, 518);
            Controls.Add(label23);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lstTableTo);
            Controls.Add(lstTableFrom);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Margin = new System.Windows.Forms.Padding(5);
            Name = "frm_ThaoTacBan";
            Text = "Quản lý sản phẩm trong danh mục gọi sản phẩm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(frm_ThaoTacBan_FormClosing);
            Load += new System.EventHandler(frm_ThaoTacBan_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTableFrom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lstTableTo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxTableFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxTableTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillTo;
        private System.Windows.Forms.Button btnNextAll;
        private System.Windows.Forms.Button btnPreviousAll;
        private System.Windows.Forms.Button btnNextOne;
        private System.Windows.Forms.Button btnPreviousOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;

    }
}