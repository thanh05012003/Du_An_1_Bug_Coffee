namespace _3.PL.Views
{
    partial class FrmLichSuHD
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
            this.pane_LSHD = new System.Windows.Forms.Panel();
            this.dgrid_HoaDonCT = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dgrid_HoaDon = new System.Windows.Forms.DataGridView();
            this.dtp_KetThuc = new System.Windows.Forms.DateTimePicker();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dtp_BatDau = new System.Windows.Forms.DateTimePicker();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pane_LSHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // pane_LSHD
            // 
            this.pane_LSHD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pane_LSHD.Controls.Add(this.dgrid_HoaDonCT);
            this.pane_LSHD.Controls.Add(this.label5);
            this.pane_LSHD.Controls.Add(this.dgrid_HoaDon);
            this.pane_LSHD.Controls.Add(this.dtp_KetThuc);
            this.pane_LSHD.Controls.Add(this.txt_TimKiem);
            this.pane_LSHD.Controls.Add(this.dtp_BatDau);
            this.pane_LSHD.Controls.Add(this.btn_TimKiem);
            this.pane_LSHD.Controls.Add(this.btn_Loc);
            this.pane_LSHD.Controls.Add(this.label2);
            this.pane_LSHD.Controls.Add(this.label1);
            this.pane_LSHD.Controls.Add(this.label3);
            this.pane_LSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pane_LSHD.Location = new System.Drawing.Point(0, 0);
            this.pane_LSHD.Name = "pane_LSHD";
            this.pane_LSHD.Size = new System.Drawing.Size(1305, 770);
            this.pane_LSHD.TabIndex = 5;
            // 
            // dgrid_HoaDonCT
            // 
            this.dgrid_HoaDonCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_HoaDonCT.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgrid_HoaDonCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDonCT.Location = new System.Drawing.Point(13, 378);
            this.dgrid_HoaDonCT.Name = "dgrid_HoaDonCT";
            this.dgrid_HoaDonCT.RowHeadersWidth = 51;
            this.dgrid_HoaDonCT.RowTemplate.Height = 29;
            this.dgrid_HoaDonCT.Size = new System.Drawing.Size(1264, 380);
            this.dgrid_HoaDonCT.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(473, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "Chi Tiết Hóa Đơn";
            // 
            // dgrid_HoaDon
            // 
            this.dgrid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_HoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_HoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgrid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDon.Location = new System.Drawing.Point(13, 87);
            this.dgrid_HoaDon.Name = "dgrid_HoaDon";
            this.dgrid_HoaDon.RowHeadersWidth = 51;
            this.dgrid_HoaDon.RowTemplate.Height = 29;
            this.dgrid_HoaDon.Size = new System.Drawing.Size(1264, 227);
            this.dgrid_HoaDon.TabIndex = 18;
            this.dgrid_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDon_CellClick);
            // 
            // dtp_KetThuc
            // 
            this.dtp_KetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_KetThuc.Location = new System.Drawing.Point(796, 50);
            this.dtp_KetThuc.Name = "dtp_KetThuc";
            this.dtp_KetThuc.Size = new System.Drawing.Size(140, 27);
            this.dtp_KetThuc.TabIndex = 16;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(13, 46);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(502, 34);
            this.txt_TimKiem.TabIndex = 15;
            // 
            // dtp_BatDau
            // 
            this.dtp_BatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BatDau.Location = new System.Drawing.Point(630, 50);
            this.dtp_BatDau.Name = "dtp_BatDau";
            this.dtp_BatDau.Size = new System.Drawing.Size(140, 27);
            this.dtp_BatDau.TabIndex = 14;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TimKiem.Location = new System.Drawing.Point(522, 46);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(79, 35);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Loc
            // 
            this.btn_Loc.BackColor = System.Drawing.Color.White;
            this.btn_Loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Loc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Loc.Location = new System.Drawing.Point(979, 46);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(79, 35);
            this.btn_Loc.TabIndex = 12;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(796, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(630, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã HD:";
            // 
            // FrmLichSuHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 770);
            this.Controls.Add(this.pane_LSHD);
            this.Name = "FrmLichSuHD";
            this.Text = "*";
            this.pane_LSHD.ResumeLayout(false);
            this.pane_LSHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pane_LSHD;
        private System.Windows.Forms.DataGridView dgrid_HoaDonCT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgrid_HoaDon;
        private System.Windows.Forms.DateTimePicker dtp_KetThuc;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DateTimePicker dtp_BatDau;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}