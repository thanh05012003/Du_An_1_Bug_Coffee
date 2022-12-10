namespace _3.PL.Views
{
    partial class FrmHDPhaChe
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
            this.pane_HDPC = new System.Windows.Forms.Panel();
            this.dgrid_HoaDon = new System.Windows.Forms.DataGridView();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.dgrid_HoaDonCT = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pane_HDPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonCT)).BeginInit();
            this.SuspendLayout();
            // 
            // pane_HDPC
            // 
            this.pane_HDPC.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pane_HDPC.Controls.Add(this.dgrid_HoaDon);
            this.pane_HDPC.Controls.Add(this.btn_XacNhan);
            this.pane_HDPC.Controls.Add(this.dgrid_HoaDonCT);
            this.pane_HDPC.Controls.Add(this.label2);
            this.pane_HDPC.Controls.Add(this.label1);
            this.pane_HDPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pane_HDPC.Location = new System.Drawing.Point(0, 0);
            this.pane_HDPC.Name = "pane_HDPC";
            this.pane_HDPC.Size = new System.Drawing.Size(1305, 770);
            this.pane_HDPC.TabIndex = 8;
            // 
            // dgrid_HoaDon
            // 
            this.dgrid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_HoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgrid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDon.Location = new System.Drawing.Point(33, 127);
            this.dgrid_HoaDon.Name = "dgrid_HoaDon";
            this.dgrid_HoaDon.RowHeadersWidth = 51;
            this.dgrid_HoaDon.RowTemplate.Height = 29;
            this.dgrid_HoaDon.Size = new System.Drawing.Size(559, 440);
            this.dgrid_HoaDon.TabIndex = 29;
            this.dgrid_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDon_CellClick);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.White;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XacNhan.Location = new System.Drawing.Point(564, 623);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(150, 64);
            this.btn_XacNhan.TabIndex = 4;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // dgrid_HoaDonCT
            // 
            this.dgrid_HoaDonCT.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgrid_HoaDonCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDonCT.Location = new System.Drawing.Point(688, 127);
            this.dgrid_HoaDonCT.Name = "dgrid_HoaDonCT";
            this.dgrid_HoaDonCT.RowHeadersWidth = 51;
            this.dgrid_HoaDonCT.RowTemplate.Height = 29;
            this.dgrid_HoaDonCT.Size = new System.Drawing.Size(559, 440);
            this.dgrid_HoaDonCT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(820, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hóa Đơn Chi Tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn";
            // 
            // FrmHDPhaChe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 770);
            this.Controls.Add(this.pane_HDPC);
            this.Name = "FrmHDPhaChe";
            this.Text = "HD Pha chế";
            this.pane_HDPC.ResumeLayout(false);
            this.pane_HDPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonCT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pane_HDPC;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.DataGridView dgrid_HoaDonCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrid_HoaDon;
    }
}