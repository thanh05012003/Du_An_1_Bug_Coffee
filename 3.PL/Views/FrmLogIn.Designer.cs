namespace _3.PL.Views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DangNhap = new CustomControls.RJControls.CSButton();
            this.txt_MatKhau = new CustomControls.RJControls.CSTextBox();
            this.txt_TaiKhoan = new CustomControls.RJControls.CSTextBox();
            this.cb_Show = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 483);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_DangNhap);
            this.panel1.Controls.Add(this.txt_MatKhau);
            this.panel1.Controls.Add(this.txt_TaiKhoan);
            this.panel1.Controls.Add(this.cb_Show);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(433, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 483);
            this.panel1.TabIndex = 24;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_DangNhap.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_DangNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DangNhap.BorderRadius = 15;
            this.btn_DangNhap.BorderSize = 0;
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Location = new System.Drawing.Point(95, 374);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(208, 76);
            this.btn_DangNhap.TabIndex = 34;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.TextColor = System.Drawing.Color.White;
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click_1);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_MatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MatKhau.BorderRadius = 15;
            this.txt_MatKhau.BorderSize = 2;
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_MatKhau.Location = new System.Drawing.Point(26, 263);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhau.Multiline = false;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MatKhau.PasswordChar = false;
            this.txt_MatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MatKhau.PlaceholderText = "Password";
            this.txt_MatKhau.Size = new System.Drawing.Size(376, 40);
            this.txt_MatKhau.TabIndex = 33;
            this.txt_MatKhau.Texts = "";
            this.txt_MatKhau.UnderlinedStyle = false;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TaiKhoan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_TaiKhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TaiKhoan.BorderRadius = 15;
            this.txt_TaiKhoan.BorderSize = 2;
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(26, 160);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaiKhoan.Multiline = false;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TaiKhoan.PasswordChar = false;
            this.txt_TaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TaiKhoan.PlaceholderText = "Email hoặc số điện thoại";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(376, 40);
            this.txt_TaiKhoan.TabIndex = 32;
            this.txt_TaiKhoan.Texts = "";
            this.txt_TaiKhoan.UnderlinedStyle = false;
            // 
            // cb_Show
            // 
            this.cb_Show.AutoSize = true;
            this.cb_Show.Location = new System.Drawing.Point(268, 334);
            this.cb_Show.Name = "cb_Show";
            this.cb_Show.Size = new System.Drawing.Size(134, 24);
            this.cb_Show.TabIndex = 31;
            this.cb_Show.Text = "Show password";
            this.cb_Show.UseVisualStyleBackColor = true;
            this.cb_Show.CheckedChanged += new System.EventHandler(this.cb_Show_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(131, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 41);
            this.label3.TabIndex = 28;
            this.label3.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tài khoản";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Show;
        private CustomControls.RJControls.CSTextBox txt_MatKhau;
        private CustomControls.RJControls.CSTextBox txt_TaiKhoan;
        private CustomControls.RJControls.CSButton btn_DangNhap;
    }

        //#endregion

        //private System.Windows.Forms.Label label1;
    }
