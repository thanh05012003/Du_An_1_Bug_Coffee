namespace _3.PL.Views.BanHang
{
    partial class FrmBanHang
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
            this.cbb_loaiSP = new System.Windows.Forms.ComboBox();
            this.dtg_hdCho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pane_HDCho = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrid_HdChoCT = new System.Windows.Forms.DataGridView();
            this.btn_XacNhan = new CustomControls.RJControls.CSButton();
            this.btn_MangDi = new CustomControls.RJControls.CSButton();
            this.flp_HoaDon = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XoaSp = new System.Windows.Forms.Button();
            this.btn_ThemSp = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DonGiaSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Ban = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_ThemHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdCho)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pane_HDCho.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HdChoCT)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_loaiSP
            // 
            this.cbb_loaiSP.FormattingEnabled = true;
            this.cbb_loaiSP.Location = new System.Drawing.Point(452, 15);
            this.cbb_loaiSP.Name = "cbb_loaiSP";
            this.cbb_loaiSP.Size = new System.Drawing.Size(166, 28);
            this.cbb_loaiSP.TabIndex = 66;
            this.cbb_loaiSP.SelectedIndexChanged += new System.EventHandler(this.cbb_loaiSP_SelectedIndexChanged);
            // 
            // dtg_hdCho
            // 
            this.dtg_hdCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_hdCho.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtg_hdCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hdCho.Location = new System.Drawing.Point(13, 662);
            this.dtg_hdCho.Name = "dtg_hdCho";
            this.dtg_hdCho.RowHeadersWidth = 51;
            this.dtg_hdCho.RowTemplate.Height = 29;
            this.dtg_hdCho.Size = new System.Drawing.Size(605, 152);
            this.dtg_hdCho.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(304, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Hóa đơn chờ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbb_loaiSP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtg_hdCho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 847);
            this.panel1.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 566);
            this.panel2.TabIndex = 67;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(606, 564);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pane_HDCho
            // 
            this.pane_HDCho.Controls.Add(this.groupBox1);
            this.pane_HDCho.Controls.Add(this.btn_XacNhan);
            this.pane_HDCho.Controls.Add(this.btn_MangDi);
            this.pane_HDCho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pane_HDCho.Location = new System.Drawing.Point(654, 230);
            this.pane_HDCho.Name = "pane_HDCho";
            this.pane_HDCho.Size = new System.Drawing.Size(669, 617);
            this.pane_HDCho.TabIndex = 103;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrid_HdChoCT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 261);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // dgrid_HdChoCT
            // 
            this.dgrid_HdChoCT.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgrid_HdChoCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HdChoCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_HdChoCT.Location = new System.Drawing.Point(3, 23);
            this.dgrid_HdChoCT.Name = "dgrid_HdChoCT";
            this.dgrid_HdChoCT.RowHeadersWidth = 51;
            this.dgrid_HdChoCT.RowTemplate.Height = 29;
            this.dgrid_HdChoCT.Size = new System.Drawing.Size(663, 235);
            this.dgrid_HdChoCT.TabIndex = 0;
            this.dgrid_HdChoCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HdChoCT_CellClick);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_XacNhan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_XacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XacNhan.BorderRadius = 15;
            this.btn_XacNhan.BorderSize = 0;
            this.btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhan.Location = new System.Drawing.Point(437, 498);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(188, 50);
            this.btn_XacNhan.TabIndex = 137;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.TextColor = System.Drawing.Color.White;
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_MangDi
            // 
            this.btn_MangDi.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_MangDi.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_MangDi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_MangDi.BorderRadius = 15;
            this.btn_MangDi.BorderSize = 0;
            this.btn_MangDi.FlatAppearance.BorderSize = 0;
            this.btn_MangDi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MangDi.ForeColor = System.Drawing.Color.White;
            this.btn_MangDi.Location = new System.Drawing.Point(31, 498);
            this.btn_MangDi.Name = "btn_MangDi";
            this.btn_MangDi.Size = new System.Drawing.Size(188, 50);
            this.btn_MangDi.TabIndex = 136;
            this.btn_MangDi.Text = "Mang đi";
            this.btn_MangDi.TextColor = System.Drawing.Color.White;
            this.btn_MangDi.UseVisualStyleBackColor = false;
            this.btn_MangDi.Click += new System.EventHandler(this.btn_MangDi_Click);
            // 
            // flp_HoaDon
            // 
            this.flp_HoaDon.Location = new System.Drawing.Point(3, 201);
            this.flp_HoaDon.Name = "flp_HoaDon";
            this.flp_HoaDon.Size = new System.Drawing.Size(478, 34);
            this.flp_HoaDon.TabIndex = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XoaSp);
            this.groupBox2.Controls.Add(this.btn_ThemSp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.flp_HoaDon);
            this.groupBox2.Controls.Add(this.txt_GhiChu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nud_SoLuong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_DonGiaSP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_TenSP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbb_Ban);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.btn_ThemHD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(654, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 241);
            this.groupBox2.TabIndex = 147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn thực đơn";
            // 
            // btn_XoaSp
            // 
            this.btn_XoaSp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_XoaSp.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XoaSp.Location = new System.Drawing.Point(518, 136);
            this.btn_XoaSp.Name = "btn_XoaSp";
            this.btn_XoaSp.Size = new System.Drawing.Size(130, 54);
            this.btn_XoaSp.TabIndex = 159;
            this.btn_XoaSp.Text = "Xoá";
            this.btn_XoaSp.UseVisualStyleBackColor = false;
            this.btn_XoaSp.Click += new System.EventHandler(this.btn_XoaSp_Click);
            // 
            // btn_ThemSp
            // 
            this.btn_ThemSp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ThemSp.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemSp.Location = new System.Drawing.Point(351, 137);
            this.btn_ThemSp.Name = "btn_ThemSp";
            this.btn_ThemSp.Size = new System.Drawing.Size(130, 54);
            this.btn_ThemSp.TabIndex = 146;
            this.btn_ThemSp.Text = "Thêm vào hoá đơn";
            this.btn_ThemSp.UseVisualStyleBackColor = false;
            this.btn_ThemSp.Click += new System.EventHandler(this.btn_ThemSp_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(26, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 158;
            this.label11.Text = "Chọn bàn:";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(454, 97);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(125, 27);
            this.txt_GhiChu.TabIndex = 157;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(347, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 156;
            this.label10.Text = "Ghi chú:";
            // 
            // nud_SoLuong
            // 
            this.nud_SoLuong.Location = new System.Drawing.Point(454, 51);
            this.nud_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SoLuong.Name = "nud_SoLuong";
            this.nud_SoLuong.Size = new System.Drawing.Size(120, 27);
            this.nud_SoLuong.TabIndex = 155;
            this.nud_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(347, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 154;
            this.label9.Text = "Số lượng:";
            // 
            // txt_DonGiaSP
            // 
            this.txt_DonGiaSP.Location = new System.Drawing.Point(132, 94);
            this.txt_DonGiaSP.Name = "txt_DonGiaSP";
            this.txt_DonGiaSP.Size = new System.Drawing.Size(125, 27);
            this.txt_DonGiaSP.TabIndex = 153;
            this.txt_DonGiaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGiaSP_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(25, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 152;
            this.label8.Text = "Đơn giá:";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(132, 48);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(125, 27);
            this.txt_TenSP.TabIndex = 151;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 147;
            this.label5.Text = "Tên món:";
            // 
            // cbb_Ban
            // 
            this.cbb_Ban.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbb_Ban.FormattingEnabled = true;
            this.cbb_Ban.Location = new System.Drawing.Point(136, 150);
            this.cbb_Ban.Name = "cbb_Ban";
            this.cbb_Ban.Size = new System.Drawing.Size(167, 28);
            this.cbb_Ban.TabIndex = 150;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(595, 199);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 39);
            this.button9.TabIndex = 149;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ThemHD.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemHD.Location = new System.Drawing.Point(518, 199);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(61, 39);
            this.btn_ThemHD.TabIndex = 148;
            this.btn_ThemHD.Text = "+";
            this.btn_ThemHD.UseVisualStyleBackColor = false;
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click_1);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 847);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pane_HDCho);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBanHang";
            this.Text = "Bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdCho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pane_HDCho.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HdChoCT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_loaiSP;
        private System.Windows.Forms.DataGridView dtg_hdCho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pane_HDCho;
        private CustomControls.RJControls.CSButton btn_XacNhan;
        private CustomControls.RJControls.CSButton btn_MangDi;
        private System.Windows.Forms.FlowLayoutPanel flp_HoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DonGiaSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_Ban;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_ThemHD;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_SoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ThemSp;
        private System.Windows.Forms.Button btn_XoaSp;
        private System.Windows.Forms.DataGridView dgrid_HdChoCT;
    }
}