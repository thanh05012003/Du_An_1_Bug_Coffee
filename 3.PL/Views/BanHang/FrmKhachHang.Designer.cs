namespace _3.PL.Views.BanHang
{
    partial class FrmKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CapNhat = new CustomControls.RJControls.CSButton();
            this.btn_Them = new CustomControls.RJControls.CSButton();
            this.txt_DiaChi = new CustomControls.RJControls.CSTextBox();
            this.txt_DiemTl = new CustomControls.RJControls.CSTextBox();
            this.txt_SDT = new CustomControls.RJControls.CSTextBox();
            this.txt_HoTen = new CustomControls.RJControls.CSTextBox();
            this.txt_MaKH = new CustomControls.RJControls.CSTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrid_TTKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TTKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.txt_DiaChi);
            this.panel1.Controls.Add(this.txt_DiemTl);
            this.panel1.Controls.Add(this.txt_SDT);
            this.panel1.Controls.Add(this.txt_HoTen);
            this.panel1.Controls.Add(this.txt_MaKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 665);
            this.panel1.TabIndex = 0;
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
            this.btn_CapNhat.Location = new System.Drawing.Point(216, 575);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(144, 48);
            this.btn_CapNhat.TabIndex = 12;
            this.btn_CapNhat.Text = "Cập nhật";
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
            this.btn_Them.Location = new System.Drawing.Point(36, 575);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(144, 48);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DiaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_DiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DiaChi.BorderRadius = 7;
            this.txt_DiaChi.BorderSize = 2;
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(36, 422);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DiaChi.PasswordChar = false;
            this.txt_DiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(324, 100);
            this.txt_DiaChi.TabIndex = 10;
            this.txt_DiaChi.Texts = "";
            this.txt_DiaChi.UnderlinedStyle = false;
            // 
            // txt_DiemTl
            // 
            this.txt_DiemTl.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DiemTl.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_DiemTl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DiemTl.BorderRadius = 7;
            this.txt_DiemTl.BorderSize = 2;
            this.txt_DiemTl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DiemTl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_DiemTl.Location = new System.Drawing.Point(36, 330);
            this.txt_DiemTl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiemTl.Multiline = false;
            this.txt_DiemTl.Name = "txt_DiemTl";
            this.txt_DiemTl.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DiemTl.PasswordChar = false;
            this.txt_DiemTl.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DiemTl.PlaceholderText = "";
            this.txt_DiemTl.Size = new System.Drawing.Size(324, 35);
            this.txt_DiemTl.TabIndex = 9;
            this.txt_DiemTl.Texts = "0";
            this.txt_DiemTl.UnderlinedStyle = false;
            this.txt_DiemTl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiemTl_KeyPress);
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SDT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_SDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_SDT.BorderRadius = 7;
            this.txt_SDT.BorderSize = 2;
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SDT.Location = new System.Drawing.Point(36, 238);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Multiline = false;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_SDT.PasswordChar = false;
            this.txt_SDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SDT.PlaceholderText = "";
            this.txt_SDT.Size = new System.Drawing.Size(324, 35);
            this.txt_SDT.TabIndex = 8;
            this.txt_SDT.Texts = "";
            this.txt_SDT.UnderlinedStyle = false;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BackColor = System.Drawing.SystemColors.Window;
            this.txt_HoTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_HoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_HoTen.BorderRadius = 7;
            this.txt_HoTen.BorderSize = 2;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_HoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_HoTen.Location = new System.Drawing.Point(36, 146);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Multiline = false;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_HoTen.PasswordChar = false;
            this.txt_HoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(324, 35);
            this.txt_HoTen.TabIndex = 7;
            this.txt_HoTen.Texts = "";
            this.txt_HoTen.UnderlinedStyle = false;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaKH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_MaKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaKH.BorderRadius = 7;
            this.txt_MaKH.BorderSize = 2;
            this.txt_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_MaKH.Location = new System.Drawing.Point(36, 54);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaKH.Multiline = false;
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaKH.PasswordChar = false;
            this.txt_MaKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaKH.PlaceholderText = "";
            this.txt_MaKH.Size = new System.Drawing.Size(324, 35);
            this.txt_MaKH.TabIndex = 6;
            this.txt_MaKH.Texts = "";
            this.txt_MaKH.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số ĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Điểm TL:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgrid_TTKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(445, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 665);
            this.panel2.TabIndex = 1;
            // 
            // dgrid_TTKhachHang
            // 
            this.dgrid_TTKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_TTKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_TTKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_TTKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgrid_TTKhachHang.Name = "dgrid_TTKhachHang";
            this.dgrid_TTKhachHang.RowHeadersWidth = 51;
            this.dgrid_TTKhachHang.RowTemplate.Height = 29;
            this.dgrid_TTKhachHang.Size = new System.Drawing.Size(477, 665);
            this.dgrid_TTKhachHang.TabIndex = 0;
            this.dgrid_TTKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_TTKhachHang_CellClick_1);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKhachHang";
            this.Text = "KhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TTKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.CSButton btn_CapNhat;
        private CustomControls.RJControls.CSButton btn_Them;
        private CustomControls.RJControls.CSTextBox txt_DiaChi;
        private CustomControls.RJControls.CSTextBox txt_DiemTl;
        private CustomControls.RJControls.CSTextBox txt_SDT;
        private CustomControls.RJControls.CSTextBox txt_HoTen;
        private CustomControls.RJControls.CSTextBox txt_MaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrid_TTKhachHang;
    }

    
}