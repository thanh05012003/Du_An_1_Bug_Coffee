namespace _3.PL.Views.ThongKe
{
    partial class FrmThongKe
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
            this.pane_ThongKe = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dtp_KTXuat = new System.Windows.Forms.DateTimePicker();
            this.dtp_BDXuat = new System.Windows.Forms.DateTimePicker();
            this.btn_XuatTK = new System.Windows.Forms.Button();
            this.btn_GiaoCa = new System.Windows.Forms.Button();
            this.btn_DT_SP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pane_ThongKe
            // 
            this.pane_ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pane_ThongKe.Location = new System.Drawing.Point(0, 70);
            this.pane_ThongKe.Name = "pane_ThongKe";
            this.pane_ThongKe.Size = new System.Drawing.Size(1323, 774);
            this.pane_ThongKe.TabIndex = 4;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(943, 46);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(50, 24);
            this.label32.TabIndex = 62;
            this.label32.Text = "Đến:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(943, 4);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 24);
            this.label31.TabIndex = 61;
            this.label31.Text = "Từ:";
            // 
            // dtp_KTXuat
            // 
            this.dtp_KTXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_KTXuat.Location = new System.Drawing.Point(1008, 43);
            this.dtp_KTXuat.Name = "dtp_KTXuat";
            this.dtp_KTXuat.Size = new System.Drawing.Size(124, 27);
            this.dtp_KTXuat.TabIndex = 60;
            // 
            // dtp_BDXuat
            // 
            this.dtp_BDXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_BDXuat.Location = new System.Drawing.Point(1008, 4);
            this.dtp_BDXuat.Name = "dtp_BDXuat";
            this.dtp_BDXuat.Size = new System.Drawing.Size(124, 27);
            this.dtp_BDXuat.TabIndex = 59;
            // 
            // btn_XuatTK
            // 
            this.btn_XuatTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_XuatTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatTK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XuatTK.Location = new System.Drawing.Point(1155, 4);
            this.btn_XuatTK.Margin = new System.Windows.Forms.Padding(0);
            this.btn_XuatTK.Name = "btn_XuatTK";
            this.btn_XuatTK.Size = new System.Drawing.Size(120, 66);
            this.btn_XuatTK.TabIndex = 58;
            this.btn_XuatTK.Text = "Xuất TK";
            this.btn_XuatTK.UseVisualStyleBackColor = false;
            // 
            // btn_GiaoCa
            // 
            this.btn_GiaoCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_GiaoCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GiaoCa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_GiaoCa.Location = new System.Drawing.Point(227, 4);
            this.btn_GiaoCa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_GiaoCa.Name = "btn_GiaoCa";
            this.btn_GiaoCa.Size = new System.Drawing.Size(180, 66);
            this.btn_GiaoCa.TabIndex = 57;
            this.btn_GiaoCa.Text = "Giao ca";
            this.btn_GiaoCa.UseVisualStyleBackColor = false;
            this.btn_GiaoCa.Click += new System.EventHandler(this.btn_GiaoCa_Click_1);
            // 
            // btn_DT_SP
            // 
            this.btn_DT_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_DT_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DT_SP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DT_SP.Location = new System.Drawing.Point(23, 4);
            this.btn_DT_SP.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DT_SP.Name = "btn_DT_SP";
            this.btn_DT_SP.Size = new System.Drawing.Size(180, 66);
            this.btn_DT_SP.TabIndex = 56;
            this.btn_DT_SP.Text = "Doanh thu - Sản phẩm";
            this.btn_DT_SP.UseVisualStyleBackColor = false;
            this.btn_DT_SP.Click += new System.EventHandler(this.btn_DT_SP_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 70);
            this.panel1.TabIndex = 63;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 847);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.dtp_KTXuat);
            this.Controls.Add(this.dtp_BDXuat);
            this.Controls.Add(this.btn_XuatTK);
            this.Controls.Add(this.btn_GiaoCa);
            this.Controls.Add(this.btn_DT_SP);
            this.Controls.Add(this.pane_ThongKe);
            this.Controls.Add(this.panel1);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pane_ThongKe;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker dtp_KTXuat;
        private System.Windows.Forms.DateTimePicker dtp_BDXuat;
        private System.Windows.Forms.Button btn_XuatTK;
        private System.Windows.Forms.Button btn_GiaoCa;
        private System.Windows.Forms.Button btn_DT_SP;
        private System.Windows.Forms.Panel panel1;
    }
}