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
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.cb_Show = new System.Windows.Forms.CheckBox();
            this.lb_MatKhauFail = new System.Windows.Forms.Label();
            this.lb_EmailFail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.txt_MatKhau);
            this.panel1.Controls.Add(this.cb_Show);
            this.panel1.Controls.Add(this.lb_MatKhauFail);
            this.panel1.Controls.Add(this.lb_EmailFail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_DangNhap);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(433, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 483);
            this.panel1.TabIndex = 24;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MatKhau.Location = new System.Drawing.Point(17, 276);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(381, 38);
            this.txt_MatKhau.TabIndex = 32;
            this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
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
            // lb_MatKhauFail
            // 
            this.lb_MatKhauFail.AutoSize = true;
            this.lb_MatKhauFail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_MatKhauFail.ForeColor = System.Drawing.Color.Red;
            this.lb_MatKhauFail.Location = new System.Drawing.Point(21, 333);
            this.lb_MatKhauFail.Name = "lb_MatKhauFail";
            this.lb_MatKhauFail.Size = new System.Drawing.Size(55, 23);
            this.lb_MatKhauFail.TabIndex = 30;
            this.lb_MatKhauFail.Text = "label4";
            // 
            // lb_EmailFail
            // 
            this.lb_EmailFail.AutoSize = true;
            this.lb_EmailFail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_EmailFail.ForeColor = System.Drawing.Color.Red;
            this.lb_EmailFail.Location = new System.Drawing.Point(17, 209);
            this.lb_EmailFail.Name = "lb_EmailFail";
            this.lb_EmailFail.Size = new System.Drawing.Size(55, 23);
            this.lb_EmailFail.TabIndex = 29;
            this.lb_EmailFail.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 53);
            this.label3.TabIndex = 28;
            this.label3.Text = "Đăng nhập";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangNhap.Location = new System.Drawing.Point(64, 375);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(272, 88);
            this.btn_DangNhap.TabIndex = 27;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Location = new System.Drawing.Point(12, 160);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(390, 45);
            this.txt_Email.TabIndex = 25;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 34);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Email:";
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
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_EmailFail;
        private System.Windows.Forms.Label lb_MatKhauFail;
        private System.Windows.Forms.CheckBox cb_Show;
        private System.Windows.Forms.TextBox txt_MatKhau;
    }

        //#endregion

        //private System.Windows.Forms.Label label1;
    }
