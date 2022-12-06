namespace _3.PL.Views
{
    partial class FrmKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuyenMai));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_update = new CustomControls.RJControls.CSButton();
            this.btn_add = new CustomControls.RJControls.CSButton();
            this.rb_khongHD = new CustomControls.RJControls.CSRadioButton();
            this.rb_hoatDong = new CustomControls.RJControls.CSRadioButton();
            this.date_ngayKT = new CustomControls.RJControls.CSDatePicker();
            this.date_ngayBD = new CustomControls.RJControls.CSDatePicker();
            this.tbt_sale = new CustomControls.RJControls.CSTextBox();
            this.tbt_moTa = new CustomControls.RJControls.CSTextBox();
            this.tbt_TenKM = new CustomControls.RJControls.CSTextBox();
            this.tbt_MaKM = new CustomControls.RJControls.CSTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbb_tThaiKM = new CustomControls.RJControls.CSComboBox();
            this.dtg_showKM = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showKM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khuyến Mãi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khuyến Mãi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Bắt Đầu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Kết Thúc :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng Thái :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giảm Giá :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mô Tả :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.rb_khongHD);
            this.groupBox1.Controls.Add(this.rb_hoatDong);
            this.groupBox1.Controls.Add(this.date_ngayKT);
            this.groupBox1.Controls.Add(this.date_ngayBD);
            this.groupBox1.Controls.Add(this.tbt_sale);
            this.groupBox1.Controls.Add(this.tbt_moTa);
            this.groupBox1.Controls.Add(this.tbt_TenKM);
            this.groupBox1.Controls.Add(this.tbt_MaKM);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 834);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_update.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_update.BorderRadius = 15;
            this.btn_update.BorderSize = 0;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(347, 548);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(168, 50);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.TextColor = System.Drawing.Color.White;
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_add.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_add.BorderRadius = 15;
            this.btn_add.BorderSize = 0;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(52, 548);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(168, 50);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Thêm";
            this.btn_add.TextColor = System.Drawing.Color.White;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // rb_khongHD
            // 
            this.rb_khongHD.AutoSize = true;
            this.rb_khongHD.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rb_khongHD.Location = new System.Drawing.Point(327, 358);
            this.rb_khongHD.MinimumSize = new System.Drawing.Size(0, 21);
            this.rb_khongHD.Name = "rb_khongHD";
            this.rb_khongHD.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rb_khongHD.Size = new System.Drawing.Size(156, 24);
            this.rb_khongHD.TabIndex = 14;
            this.rb_khongHD.TabStop = true;
            this.rb_khongHD.Text = "Không hoạt động";
            this.rb_khongHD.UnCheckedColor = System.Drawing.Color.Black;
            this.rb_khongHD.UseVisualStyleBackColor = true;
            // 
            // rb_hoatDong
            // 
            this.rb_hoatDong.AutoSize = true;
            this.rb_hoatDong.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rb_hoatDong.Location = new System.Drawing.Point(161, 358);
            this.rb_hoatDong.MinimumSize = new System.Drawing.Size(0, 21);
            this.rb_hoatDong.Name = "rb_hoatDong";
            this.rb_hoatDong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rb_hoatDong.Size = new System.Drawing.Size(112, 24);
            this.rb_hoatDong.TabIndex = 13;
            this.rb_hoatDong.TabStop = true;
            this.rb_hoatDong.Text = "Hoạt động";
            this.rb_hoatDong.UnCheckedColor = System.Drawing.Color.Black;
            this.rb_hoatDong.UseVisualStyleBackColor = true;
            // 
            // date_ngayKT
            // 
            this.date_ngayKT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.date_ngayKT.BorderSize = 2;
            this.date_ngayKT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_ngayKT.Location = new System.Drawing.Point(161, 310);
            this.date_ngayKT.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_ngayKT.Name = "date_ngayKT";
            this.date_ngayKT.Size = new System.Drawing.Size(320, 35);
            this.date_ngayKT.SkinColor = System.Drawing.Color.White;
            this.date_ngayKT.TabIndex = 12;
            this.date_ngayKT.TextColor = System.Drawing.Color.Black;
            // 
            // date_ngayBD
            // 
            this.date_ngayBD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.date_ngayBD.BorderSize = 2;
            this.date_ngayBD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_ngayBD.Location = new System.Drawing.Point(161, 263);
            this.date_ngayBD.MinimumSize = new System.Drawing.Size(4, 35);
            this.date_ngayBD.Name = "date_ngayBD";
            this.date_ngayBD.Size = new System.Drawing.Size(320, 35);
            this.date_ngayBD.SkinColor = System.Drawing.Color.White;
            this.date_ngayBD.TabIndex = 11;
            this.date_ngayBD.TextColor = System.Drawing.Color.Black;
            // 
            // tbt_sale
            // 
            this.tbt_sale.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_sale.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_sale.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_sale.BorderRadius = 15;
            this.tbt_sale.BorderSize = 2;
            this.tbt_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_sale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_sale.Location = new System.Drawing.Point(161, 398);
            this.tbt_sale.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_sale.Multiline = false;
            this.tbt_sale.Name = "tbt_sale";
            this.tbt_sale.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_sale.PasswordChar = false;
            this.tbt_sale.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_sale.PlaceholderText = "";
            this.tbt_sale.Size = new System.Drawing.Size(320, 35);
            this.tbt_sale.TabIndex = 10;
            this.tbt_sale.Texts = "";
            this.tbt_sale.UnderlinedStyle = false;
            // 
            // tbt_moTa
            // 
            this.tbt_moTa.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_moTa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_moTa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_moTa.BorderRadius = 15;
            this.tbt_moTa.BorderSize = 2;
            this.tbt_moTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_moTa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_moTa.Location = new System.Drawing.Point(161, 449);
            this.tbt_moTa.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_moTa.Multiline = false;
            this.tbt_moTa.Name = "tbt_moTa";
            this.tbt_moTa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_moTa.PasswordChar = false;
            this.tbt_moTa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_moTa.PlaceholderText = "";
            this.tbt_moTa.Size = new System.Drawing.Size(320, 35);
            this.tbt_moTa.TabIndex = 9;
            this.tbt_moTa.Texts = "";
            this.tbt_moTa.UnderlinedStyle = false;
            // 
            // tbt_TenKM
            // 
            this.tbt_TenKM.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_TenKM.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_TenKM.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_TenKM.BorderRadius = 15;
            this.tbt_TenKM.BorderSize = 2;
            this.tbt_TenKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_TenKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_TenKM.Location = new System.Drawing.Point(161, 215);
            this.tbt_TenKM.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_TenKM.Multiline = false;
            this.tbt_TenKM.Name = "tbt_TenKM";
            this.tbt_TenKM.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_TenKM.PasswordChar = false;
            this.tbt_TenKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_TenKM.PlaceholderText = "";
            this.tbt_TenKM.Size = new System.Drawing.Size(320, 35);
            this.tbt_TenKM.TabIndex = 8;
            this.tbt_TenKM.Texts = "";
            this.tbt_TenKM.UnderlinedStyle = false;
            // 
            // tbt_MaKM
            // 
            this.tbt_MaKM.BackColor = System.Drawing.SystemColors.Window;
            this.tbt_MaKM.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbt_MaKM.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbt_MaKM.BorderRadius = 15;
            this.tbt_MaKM.BorderSize = 2;
            this.tbt_MaKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_MaKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbt_MaKM.Location = new System.Drawing.Point(161, 172);
            this.tbt_MaKM.Margin = new System.Windows.Forms.Padding(4);
            this.tbt_MaKM.Multiline = false;
            this.tbt_MaKM.Name = "tbt_MaKM";
            this.tbt_MaKM.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbt_MaKM.PasswordChar = false;
            this.tbt_MaKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbt_MaKM.PlaceholderText = "";
            this.tbt_MaKM.Size = new System.Drawing.Size(320, 35);
            this.tbt_MaKM.TabIndex = 7;
            this.tbt_MaKM.Texts = "";
            this.tbt_MaKM.UnderlinedStyle = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox5.Location = new System.Drawing.Point(192, 632);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 142);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Location = new System.Drawing.Point(215, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbb_tThaiKM);
            this.groupBox4.Controls.Add(this.dtg_showKM);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(607, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(704, 823);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khuyến Mãi";
            // 
            // cbb_tThaiKM
            // 
            this.cbb_tThaiKM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_tThaiKM.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbb_tThaiKM.BorderSize = 2;
            this.cbb_tThaiKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbb_tThaiKM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_tThaiKM.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_tThaiKM.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbb_tThaiKM.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbb_tThaiKM.ListTextColor = System.Drawing.Color.DimGray;
            this.cbb_tThaiKM.Location = new System.Drawing.Point(25, 47);
            this.cbb_tThaiKM.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbb_tThaiKM.Name = "cbb_tThaiKM";
            this.cbb_tThaiKM.Padding = new System.Windows.Forms.Padding(2);
            this.cbb_tThaiKM.Size = new System.Drawing.Size(250, 34);
            this.cbb_tThaiKM.TabIndex = 5;
            this.cbb_tThaiKM.Texts = "";
            // 
            // dtg_showKM
            // 
            this.dtg_showKM.BackgroundColor = System.Drawing.Color.White;
            this.dtg_showKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_showKM.Location = new System.Drawing.Point(9, 95);
            this.dtg_showKM.Name = "dtg_showKM";
            this.dtg_showKM.RowHeadersWidth = 51;
            this.dtg_showKM.RowTemplate.Height = 29;
            this.dtg_showKM.Size = new System.Drawing.Size(689, 558);
            this.dtg_showKM.TabIndex = 1;
            this.dtg_showKM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_showKM_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(25, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Trạng Thái";
            // 
            // FrmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 847);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmKhuyenMai";
            this.Text = "FrmKhuyenMai";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_showKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtg_showKM;
        private System.Windows.Forms.Label label13;
        private CustomControls.RJControls.CSTextBox tbt_sale;
        private CustomControls.RJControls.CSTextBox tbt_moTa;
        private CustomControls.RJControls.CSTextBox tbt_TenKM;
        private CustomControls.RJControls.CSTextBox tbt_MaKM;
        private CustomControls.RJControls.CSDatePicker date_ngayKT;
        private CustomControls.RJControls.CSDatePicker date_ngayBD;
        private CustomControls.RJControls.CSRadioButton rb_khongHD;
        private CustomControls.RJControls.CSRadioButton rb_hoatDong;
        private CustomControls.RJControls.CSButton btn_update;
        private CustomControls.RJControls.CSButton btn_add;
        private CustomControls.RJControls.CSComboBox cbb_tThaiKM;
    }
}