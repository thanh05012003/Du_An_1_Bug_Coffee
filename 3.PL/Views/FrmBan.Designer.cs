namespace _3.PL.Views
{
    partial class FrmBan
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThanhToan = new CustomControls.RJControls.CSButton();
            this.cmb_Ban = new System.Windows.Forms.ComboBox();
            this.btn_TachHd = new CustomControls.RJControls.CSButton();
            this.btn_ChuyenBan = new CustomControls.RJControls.CSButton();
            this.dgrid_TTSp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_SanPham = new CustomControls.RJControls.CSComboBox();
            this.cmb_LoaiSanPham = new CustomControls.RJControls.CSComboBox();
            this.nud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.btn_ThemMon = new CustomControls.RJControls.CSButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TTSp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 847);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(784, 667);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 180);
            this.panel1.TabIndex = 1;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ThanhToan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThanhToan.BorderRadius = 20;
            this.btn_ThanhToan.BorderSize = 0;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(249, 85);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(260, 74);
            this.btn_ThanhToan.TabIndex = 8;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.TextColor = System.Drawing.Color.White;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // cmb_Ban
            // 
            this.cmb_Ban.FormattingEnabled = true;
            this.cmb_Ban.Location = new System.Drawing.Point(792, 55);
            this.cmb_Ban.Name = "cmb_Ban";
            this.cmb_Ban.Size = new System.Drawing.Size(133, 28);
            this.cmb_Ban.TabIndex = 11;
            // 
            // btn_TachHd
            // 
            this.btn_TachHd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_TachHd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_TachHd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TachHd.BorderRadius = 15;
            this.btn_TachHd.BorderSize = 0;
            this.btn_TachHd.FlatAppearance.BorderSize = 0;
            this.btn_TachHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TachHd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TachHd.ForeColor = System.Drawing.Color.White;
            this.btn_TachHd.Location = new System.Drawing.Point(1176, 9);
            this.btn_TachHd.Name = "btn_TachHd";
            this.btn_TachHd.Size = new System.Drawing.Size(135, 40);
            this.btn_TachHd.TabIndex = 10;
            this.btn_TachHd.Text = "Tách hoá đơn";
            this.btn_TachHd.TextColor = System.Drawing.Color.White;
            this.btn_TachHd.UseVisualStyleBackColor = false;
            this.btn_TachHd.Click += new System.EventHandler(this.btn_TachHd_Click);
            // 
            // btn_ChuyenBan
            // 
            this.btn_ChuyenBan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ChuyenBan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ChuyenBan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ChuyenBan.BorderRadius = 15;
            this.btn_ChuyenBan.BorderSize = 0;
            this.btn_ChuyenBan.FlatAppearance.BorderSize = 0;
            this.btn_ChuyenBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChuyenBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChuyenBan.ForeColor = System.Drawing.Color.White;
            this.btn_ChuyenBan.Location = new System.Drawing.Point(790, 9);
            this.btn_ChuyenBan.Name = "btn_ChuyenBan";
            this.btn_ChuyenBan.Size = new System.Drawing.Size(135, 40);
            this.btn_ChuyenBan.TabIndex = 9;
            this.btn_ChuyenBan.Text = "Chuyển bàn";
            this.btn_ChuyenBan.TextColor = System.Drawing.Color.White;
            this.btn_ChuyenBan.UseVisualStyleBackColor = false;
            this.btn_ChuyenBan.Click += new System.EventHandler(this.btn_ChuyenBan_Click);
            // 
            // dgrid_TTSp
            // 
            this.dgrid_TTSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_TTSp.BackgroundColor = System.Drawing.Color.White;
            this.dgrid_TTSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_TTSp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_TTSp.Location = new System.Drawing.Point(784, 294);
            this.dgrid_TTSp.Name = "dgrid_TTSp";
            this.dgrid_TTSp.RowHeadersWidth = 51;
            this.dgrid_TTSp.RowTemplate.Height = 29;
            this.dgrid_TTSp.Size = new System.Drawing.Size(539, 373);
            this.dgrid_TTSp.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_SanPham);
            this.groupBox1.Controls.Add(this.cmb_LoaiSanPham);
            this.groupBox1.Controls.Add(this.nud_SoLuong);
            this.groupBox1.Controls.Add(this.btn_ThemMon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(784, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 205);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(324, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Loại sản phẩm";
            // 
            // cmb_SanPham
            // 
            this.cmb_SanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_SanPham.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_SanPham.BorderSize = 2;
            this.cmb_SanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_SanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_SanPham.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_SanPham.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_SanPham.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_SanPham.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_SanPham.Location = new System.Drawing.Point(23, 155);
            this.cmb_SanPham.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_SanPham.Name = "cmb_SanPham";
            this.cmb_SanPham.Padding = new System.Windows.Forms.Padding(2);
            this.cmb_SanPham.Size = new System.Drawing.Size(250, 34);
            this.cmb_SanPham.TabIndex = 20;
            this.cmb_SanPham.Texts = "";
            // 
            // cmb_LoaiSanPham
            // 
            this.cmb_LoaiSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_LoaiSanPham.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_LoaiSanPham.BorderSize = 2;
            this.cmb_LoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_LoaiSanPham.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_LoaiSanPham.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_LoaiSanPham.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_LoaiSanPham.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_LoaiSanPham.Location = new System.Drawing.Point(23, 76);
            this.cmb_LoaiSanPham.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_LoaiSanPham.Name = "cmb_LoaiSanPham";
            this.cmb_LoaiSanPham.Padding = new System.Windows.Forms.Padding(2);
            this.cmb_LoaiSanPham.Size = new System.Drawing.Size(250, 34);
            this.cmb_LoaiSanPham.TabIndex = 19;
            this.cmb_LoaiSanPham.Texts = "";
            this.cmb_LoaiSanPham.OnSelectedIndexChanged += new System.EventHandler(this.cmb_LoaiSanPham_OnSelectedIndexChanged_1);
            // 
            // nud_SoLuong
            // 
            this.nud_SoLuong.Location = new System.Drawing.Point(326, 80);
            this.nud_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SoLuong.Name = "nud_SoLuong";
            this.nud_SoLuong.Size = new System.Drawing.Size(94, 27);
            this.nud_SoLuong.TabIndex = 18;
            this.nud_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_ThemMon
            // 
            this.btn_ThemMon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ThemMon.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ThemMon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemMon.BorderRadius = 15;
            this.btn_ThemMon.BorderSize = 0;
            this.btn_ThemMon.FlatAppearance.BorderSize = 0;
            this.btn_ThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemMon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemMon.ForeColor = System.Drawing.Color.White;
            this.btn_ThemMon.Location = new System.Drawing.Point(324, 139);
            this.btn_ThemMon.Name = "btn_ThemMon";
            this.btn_ThemMon.Size = new System.Drawing.Size(123, 50);
            this.btn_ThemMon.TabIndex = 17;
            this.btn_ThemMon.Text = "Thêm món";
            this.btn_ThemMon.TextColor = System.Drawing.Color.White;
            this.btn_ThemMon.UseVisualStyleBackColor = false;
            this.btn_ThemMon.Click += new System.EventHandler(this.btn_ThemMon_Click_1);
            // 
            // FrmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 847);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_Ban);
            this.Controls.Add(this.btn_TachHd);
            this.Controls.Add(this.btn_ChuyenBan);
            this.Controls.Add(this.dgrid_TTSp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmBan";
            this.Text = "FrmBan";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TTSp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrid_TTSp;
        private CustomControls.RJControls.CSButton btn_ThanhToan;
        private System.Windows.Forms.ComboBox cmb_Ban;
        private CustomControls.RJControls.CSButton btn_TachHd;
        private CustomControls.RJControls.CSButton btn_ChuyenBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.CSComboBox cmb_SanPham;
        private CustomControls.RJControls.CSComboBox cmb_LoaiSanPham;
        private System.Windows.Forms.NumericUpDown nud_SoLuong;
        private CustomControls.RJControls.CSButton btn_ThemMon;
    }
}