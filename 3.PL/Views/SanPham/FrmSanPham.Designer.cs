namespace _3.PL.Views
{
    partial class FrmSanPham
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.cbx_Lsp = new System.Windows.Forms.ComboBox();
            this.cbx_TrangThai = new System.Windows.Forms.ComboBox();
            this.dgrid_QLSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.txt_Mota = new System.Windows.Forms.TextBox();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.rdb_DangBan = new System.Windows.Forms.RadioButton();
            this.rdb_NgungBan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddLSP = new CustomControls.RJControls.CSButton();
            this.btn_CapNhat = new CustomControls.RJControls.CSButton();
            this.btn_Them = new CustomControls.RJControls.CSButton();
            this.cbx_MaLoaiSP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLSanPham)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(965, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 21);
            this.label13.TabIndex = 7;
            this.label13.Text = "Trạng Thái";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(647, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "Loại Sản Phẩm";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(76, 75);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(282, 27);
            this.txt_TimKiem.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(76, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tìm Kiếm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TimKiem.Location = new System.Drawing.Point(383, 74);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(91, 29);
            this.btn_TimKiem.TabIndex = 9;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // cbx_Lsp
            // 
            this.cbx_Lsp.FormattingEnabled = true;
            this.cbx_Lsp.Location = new System.Drawing.Point(647, 74);
            this.cbx_Lsp.Name = "cbx_Lsp";
            this.cbx_Lsp.Size = new System.Drawing.Size(219, 28);
            this.cbx_Lsp.TabIndex = 11;
            // 
            // cbx_TrangThai
            // 
            this.cbx_TrangThai.FormattingEnabled = true;
            this.cbx_TrangThai.Location = new System.Drawing.Point(965, 74);
            this.cbx_TrangThai.Name = "cbx_TrangThai";
            this.cbx_TrangThai.Size = new System.Drawing.Size(219, 28);
            this.cbx_TrangThai.TabIndex = 10;
            // 
            // dgrid_QLSanPham
            // 
            this.dgrid_QLSanPham.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgrid_QLSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_QLSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_QLSanPham.Location = new System.Drawing.Point(3, 121);
            this.dgrid_QLSanPham.Name = "dgrid_QLSanPham";
            this.dgrid_QLSanPham.RowHeadersWidth = 51;
            this.dgrid_QLSanPham.RowTemplate.Height = 29;
            this.dgrid_QLSanPham.Size = new System.Drawing.Size(1317, 339);
            this.dgrid_QLSanPham.TabIndex = 12;
            this.dgrid_QLSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_QLSanPham_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox3.Controls.Add(this.dgrid_QLSanPham);
            this.groupBox3.Controls.Add(this.cbx_TrangThai);
            this.groupBox3.Controls.Add(this.cbx_Lsp);
            this.groupBox3.Controls.Add(this.btn_TimKiem);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_TimKiem);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1323, 463);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Sản Phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên Sản Phẩm ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loại Sản Phẩm ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(882, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trạng Thái ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(265, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(30, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 27);
            this.textBox5.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(526, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 28);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(882, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 28);
            this.comboBox3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 391);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1323, 548);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(676, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá Bán :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(676, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô Tả :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(676, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Loại SP :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sản Phẩm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng Thái :";
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Location = new System.Drawing.Point(167, 73);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(318, 27);
            this.txt_MaSanPham.TabIndex = 1;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(786, 73);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(318, 27);
            this.txt_GiaBan.TabIndex = 1;
            // 
            // txt_Mota
            // 
            this.txt_Mota.Location = new System.Drawing.Point(786, 160);
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.Size = new System.Drawing.Size(318, 27);
            this.txt_Mota.TabIndex = 1;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Location = new System.Drawing.Point(167, 160);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(318, 27);
            this.txt_TenSanPham.TabIndex = 1;
            // 
            // rdb_DangBan
            // 
            this.rdb_DangBan.AutoSize = true;
            this.rdb_DangBan.Location = new System.Drawing.Point(167, 249);
            this.rdb_DangBan.Name = "rdb_DangBan";
            this.rdb_DangBan.Size = new System.Drawing.Size(95, 24);
            this.rdb_DangBan.TabIndex = 2;
            this.rdb_DangBan.TabStop = true;
            this.rdb_DangBan.Text = "Đang Bán";
            this.rdb_DangBan.UseVisualStyleBackColor = true;
            // 
            // rdb_NgungBan
            // 
            this.rdb_NgungBan.AutoSize = true;
            this.rdb_NgungBan.Location = new System.Drawing.Point(368, 249);
            this.rdb_NgungBan.Name = "rdb_NgungBan";
            this.rdb_NgungBan.Size = new System.Drawing.Size(105, 24);
            this.rdb_NgungBan.TabIndex = 2;
            this.rdb_NgungBan.TabStop = true;
            this.rdb_NgungBan.Text = "Ngừng Bán";
            this.rdb_NgungBan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.btn_AddLSP);
            this.groupBox1.Controls.Add(this.btn_CapNhat);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.cbx_MaLoaiSP);
            this.groupBox1.Controls.Add(this.rdb_NgungBan);
            this.groupBox1.Controls.Add(this.rdb_DangBan);
            this.groupBox1.Controls.Add(this.txt_TenSanPham);
            this.groupBox1.Controls.Add(this.txt_Mota);
            this.groupBox1.Controls.Add(this.txt_GiaBan);
            this.groupBox1.Controls.Add(this.txt_MaSanPham);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1323, 847);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm";
            // 
            // btn_AddLSP
            // 
            this.btn_AddLSP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_AddLSP.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_AddLSP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_AddLSP.BorderRadius = 0;
            this.btn_AddLSP.BorderSize = 0;
            this.btn_AddLSP.FlatAppearance.BorderSize = 0;
            this.btn_AddLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddLSP.ForeColor = System.Drawing.Color.White;
            this.btn_AddLSP.Location = new System.Drawing.Point(1109, 245);
            this.btn_AddLSP.Name = "btn_AddLSP";
            this.btn_AddLSP.Size = new System.Drawing.Size(38, 30);
            this.btn_AddLSP.TabIndex = 6;
            this.btn_AddLSP.Text = "+";
            this.btn_AddLSP.TextColor = System.Drawing.Color.White;
            this.btn_AddLSP.UseVisualStyleBackColor = false;
            this.btn_AddLSP.Click += new System.EventHandler(this.btn_AddLSP_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_CapNhat.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_CapNhat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_CapNhat.BorderRadius = 15;
            this.btn_CapNhat.BorderSize = 0;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CapNhat.ForeColor = System.Drawing.Color.White;
            this.btn_CapNhat.Location = new System.Drawing.Point(786, 310);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(188, 50);
            this.btn_CapNhat.TabIndex = 5;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.TextColor = System.Drawing.Color.White;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 15;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(137, 310);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(188, 50);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbx_MaLoaiSP
            // 
            this.cbx_MaLoaiSP.FormattingEnabled = true;
            this.cbx_MaLoaiSP.Location = new System.Drawing.Point(786, 247);
            this.cbx_MaLoaiSP.Name = "cbx_MaLoaiSP";
            this.cbx_MaLoaiSP.Size = new System.Drawing.Size(306, 28);
            this.cbx_MaLoaiSP.TabIndex = 3;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 847);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_QLSanPham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.ComboBox cbx_Lsp;
        private System.Windows.Forms.ComboBox cbx_TrangThai;
        private System.Windows.Forms.DataGridView dgrid_QLSanPham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.TextBox txt_Mota;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.RadioButton rdb_DangBan;
        private System.Windows.Forms.RadioButton rdb_NgungBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControls.RJControls.CSButton btn_Them;
        private CustomControls.RJControls.CSButton btn_CapNhat;
        private System.Windows.Forms.ComboBox cbx_MaLoaiSP;
        private CustomControls.RJControls.CSButton btn_AddLSP;
    }
}