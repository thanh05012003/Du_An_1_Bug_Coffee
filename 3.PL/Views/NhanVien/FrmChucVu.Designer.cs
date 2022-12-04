namespace _3.PL.Views.NhanVien
{
    partial class FrmChucVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaCv = new System.Windows.Forms.TextBox();
            this.txt_TenCv = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dtgrid_ChucVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_ChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ:";
            // 
            // txt_MaCv
            // 
            this.txt_MaCv.Location = new System.Drawing.Point(222, 49);
            this.txt_MaCv.Name = "txt_MaCv";
            this.txt_MaCv.Size = new System.Drawing.Size(195, 27);
            this.txt_MaCv.TabIndex = 2;
            // 
            // txt_TenCv
            // 
            this.txt_TenCv.Location = new System.Drawing.Point(222, 110);
            this.txt_TenCv.Name = "txt_TenCv";
            this.txt_TenCv.Size = new System.Drawing.Size(195, 27);
            this.txt_TenCv.TabIndex = 3;
            this.txt_TenCv.TextChanged += new System.EventHandler(this.txt_TenCv_TextChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(51, 189);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(125, 50);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(271, 189);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(146, 50);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dtgrid_ChucVu
            // 
            this.dtgrid_ChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_ChucVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_ChucVu.Location = new System.Drawing.Point(0, 295);
            this.dtgrid_ChucVu.Name = "dtgrid_ChucVu";
            this.dtgrid_ChucVu.RowHeadersWidth = 51;
            this.dtgrid_ChucVu.RowTemplate.Height = 29;
            this.dtgrid_ChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_ChucVu.Size = new System.Drawing.Size(496, 188);
            this.dtgrid_ChucVu.TabIndex = 6;
            this.dtgrid_ChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_ChucVu_CellClick);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 483);
            this.Controls.Add(this.dtgrid_ChucVu);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TenCv);
            this.Controls.Add(this.txt_MaCv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_ChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaCv;
        private System.Windows.Forms.TextBox txt_TenCv;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dtgrid_ChucVu;
    }
}