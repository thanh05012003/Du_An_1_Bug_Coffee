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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TenLSP = new System.Windows.Forms.TextBox();
            this.txt_MaLSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrid_LSP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_LSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(327, 176);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(146, 50);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(125, 176);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 50);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TenLSP
            // 
            this.txt_TenLSP.Location = new System.Drawing.Point(294, 97);
            this.txt_TenLSP.Name = "txt_TenLSP";
            this.txt_TenLSP.Size = new System.Drawing.Size(195, 27);
            this.txt_TenLSP.TabIndex = 9;
            this.txt_TenLSP.TextChanged += new System.EventHandler(this.txt_TenLSP_TextChanged);
            // 
            // txt_MaLSP
            // 
            this.txt_MaLSP.Location = new System.Drawing.Point(294, 36);
            this.txt_MaLSP.Name = "txt_MaLSP";
            this.txt_MaLSP.Size = new System.Drawing.Size(195, 27);
            this.txt_MaLSP.TabIndex = 8;
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
            // FrmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 466);
            this.Controls.Add(this.dtgrid_LSP);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TenLSP);
            this.Controls.Add(this.txt_MaLSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLoaiSP";
            this.Text = "FrmLoaiSP";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_LSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_TenLSP;
        private System.Windows.Forms.TextBox txt_MaLSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrid_LSP;
    }
}