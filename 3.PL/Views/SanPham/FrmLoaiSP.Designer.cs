namespace _3.PL.Views.SanPham
{
    partial class FrmLoaiSP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrid_LSP = new System.Windows.Forms.DataGridView();
            this.txt_MaLSP = new CustomControls.RJControls.CSTextBox();
            this.txt_TenLSP = new CustomControls.RJControls.CSTextBox();
            this.btn_Sua = new CustomControls.RJControls.CSButton();
            this.btn_Them = new CustomControls.RJControls.CSButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_LSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Loại Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã:";
            // 
            // dtgrid_LSP
            // 
            this.dtgrid_LSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_LSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_LSP.BackgroundColor = System.Drawing.Color.White;
            this.dtgrid_LSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_LSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_LSP.Location = new System.Drawing.Point(0, 278);
            this.dtgrid_LSP.Name = "dtgrid_LSP";
            this.dtgrid_LSP.RowHeadersWidth = 51;
            this.dtgrid_LSP.RowTemplate.Height = 29;
            this.dtgrid_LSP.Size = new System.Drawing.Size(604, 188);
            this.dtgrid_LSP.TabIndex = 12;
            this.dtgrid_LSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_LSP_CellClick);
            // 
            // txt_MaLSP
            // 
            this.txt_MaLSP.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaLSP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_MaLSP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaLSP.BorderRadius = 15;
            this.txt_MaLSP.BorderSize = 2;
            this.txt_MaLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_MaLSP.Location = new System.Drawing.Point(294, 30);
            this.txt_MaLSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLSP.Multiline = false;
            this.txt_MaLSP.Name = "txt_MaLSP";
            this.txt_MaLSP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaLSP.PasswordChar = false;
            this.txt_MaLSP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaLSP.PlaceholderText = "";
            this.txt_MaLSP.Size = new System.Drawing.Size(195, 35);
            this.txt_MaLSP.TabIndex = 13;
            this.txt_MaLSP.Texts = "";
            this.txt_MaLSP.UnderlinedStyle = false;
            // 
            // txt_TenLSP
            // 
            this.txt_TenLSP.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenLSP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_TenLSP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenLSP.BorderRadius = 15;
            this.txt_TenLSP.BorderSize = 2;
            this.txt_TenLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TenLSP.Location = new System.Drawing.Point(294, 95);
            this.txt_TenLSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenLSP.Multiline = false;
            this.txt_TenLSP.Name = "txt_TenLSP";
            this.txt_TenLSP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenLSP.PasswordChar = false;
            this.txt_TenLSP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenLSP.PlaceholderText = "";
            this.txt_TenLSP.Size = new System.Drawing.Size(195, 35);
            this.txt_TenLSP.TabIndex = 14;
            this.txt_TenLSP.Texts = "";
            this.txt_TenLSP.UnderlinedStyle = false;
            this.txt_TenLSP._TextChanged += new System.EventHandler(this.txt_TenLSP__TextChanged);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Sua.BorderRadius = 15;
            this.btn_Sua.BorderSize = 0;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(327, 177);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(188, 50);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
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
            this.btn_Them.Location = new System.Drawing.Point(78, 177);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(188, 50);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // FrmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 466);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.txt_TenLSP);
            this.Controls.Add(this.txt_MaLSP);
            this.Controls.Add(this.dtgrid_LSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLoaiSP";
            this.Text = "FrmLoaiSP";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_LSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrid_LSP;
        private CustomControls.RJControls.CSTextBox txt_MaLSP;
        private CustomControls.RJControls.CSTextBox txt_TenLSP;
        private CustomControls.RJControls.CSButton btn_Sua;
        private CustomControls.RJControls.CSButton btn_Them;
    }
}