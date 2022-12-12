namespace _3.PL.Views
{
    partial class FrmTachHD
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
            this.dtg_hdTong = new System.Windows.Forms.DataGridView();
            this.dtg_hdTach = new System.Windows.Forms.DataGridView();
            this.btn_tachSP = new System.Windows.Forms.Button();
            this.btn_xacNhan = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.cmb_BanTach = new CustomControls.RJControls.CSComboBox();
            this.nud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdTach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_hdTong
            // 
            this.dtg_hdTong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_hdTong.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtg_hdTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hdTong.Location = new System.Drawing.Point(12, 31);
            this.dtg_hdTong.Name = "dtg_hdTong";
            this.dtg_hdTong.RowHeadersWidth = 51;
            this.dtg_hdTong.RowTemplate.Height = 29;
            this.dtg_hdTong.Size = new System.Drawing.Size(655, 188);
            this.dtg_hdTong.TabIndex = 0;
            this.dtg_hdTong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hdTong_CellClick);
            // 
            // dtg_hdTach
            // 
            this.dtg_hdTach.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtg_hdTach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hdTach.Location = new System.Drawing.Point(12, 318);
            this.dtg_hdTach.Name = "dtg_hdTach";
            this.dtg_hdTach.RowHeadersWidth = 51;
            this.dtg_hdTach.RowTemplate.Height = 29;
            this.dtg_hdTach.Size = new System.Drawing.Size(655, 188);
            this.dtg_hdTach.TabIndex = 1;
            // 
            // btn_tachSP
            // 
            this.btn_tachSP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_tachSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tachSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tachSP.Location = new System.Drawing.Point(36, 237);
            this.btn_tachSP.Name = "btn_tachSP";
            this.btn_tachSP.Size = new System.Drawing.Size(214, 66);
            this.btn_tachSP.TabIndex = 2;
            this.btn_tachSP.Text = "Tách sản phẩm";
            this.btn_tachSP.UseVisualStyleBackColor = false;
            this.btn_tachSP.Click += new System.EventHandler(this.btn_tachSP_Click);
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xacNhan.Location = new System.Drawing.Point(213, 578);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(153, 67);
            this.btn_xacNhan.TabIndex = 3;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = false;
            this.btn_xacNhan.Click += new System.EventHandler(this.btn_xacNhan_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Huy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Huy.Location = new System.Drawing.Point(372, 578);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(89, 67);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            // 
            // cmb_BanTach
            // 
            this.cmb_BanTach.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_BanTach.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_BanTach.BorderSize = 1;
            this.cmb_BanTach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_BanTach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_BanTach.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_BanTach.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_BanTach.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_BanTach.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_BanTach.Location = new System.Drawing.Point(372, 225);
            this.cmb_BanTach.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_BanTach.Name = "cmb_BanTach";
            this.cmb_BanTach.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_BanTach.Size = new System.Drawing.Size(250, 38);
            this.cmb_BanTach.TabIndex = 4;
            this.cmb_BanTach.Texts = "";
            // 
            // nud_SoLuong
            // 
            this.nud_SoLuong.Location = new System.Drawing.Point(533, 276);
            this.nud_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SoLuong.Name = "nud_SoLuong";
            this.nud_SoLuong.Size = new System.Drawing.Size(89, 27);
            this.nud_SoLuong.TabIndex = 5;
            this.nud_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SoLuong.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(412, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng";
            // 
            // FrmTachHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(679, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_SoLuong);
            this.Controls.Add(this.cmb_BanTach);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.btn_tachSP);
            this.Controls.Add(this.dtg_hdTach);
            this.Controls.Add(this.dtg_hdTong);
            this.Name = "FrmTachHD";
            this.Text = "TachHD";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdTach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_hdTong;
        private System.Windows.Forms.DataGridView dtg_hdTach;
        private System.Windows.Forms.Button btn_tachSP;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Button btn_Huy;
        private CustomControls.RJControls.CSComboBox cmb_BanTach;
        private System.Windows.Forms.NumericUpDown nud_SoLuong;
        private System.Windows.Forms.Label label1;
    }
}