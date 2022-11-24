namespace _3.PL.Views
{
    partial class TachHD
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdTong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdTach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_hdTong
            // 
            this.dtg_hdTong.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtg_hdTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hdTong.Location = new System.Drawing.Point(12, 31);
            this.dtg_hdTong.Name = "dtg_hdTong";
            this.dtg_hdTong.RowHeadersWidth = 51;
            this.dtg_hdTong.RowTemplate.Height = 29;
            this.dtg_hdTong.Size = new System.Drawing.Size(655, 188);
            this.dtg_hdTong.TabIndex = 0;
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
            this.btn_tachSP.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_tachSP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tachSP.Location = new System.Drawing.Point(247, 235);
            this.btn_tachSP.Name = "btn_tachSP";
            this.btn_tachSP.Size = new System.Drawing.Size(214, 66);
            this.btn_tachSP.TabIndex = 2;
            this.btn_tachSP.Text = "Tách sản phẩm";
            this.btn_tachSP.UseVisualStyleBackColor = false;
            // 
            // btn_xacNhan
            // 
            this.btn_xacNhan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_xacNhan.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xacNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xacNhan.Location = new System.Drawing.Point(232, 524);
            this.btn_xacNhan.Name = "btn_xacNhan";
            this.btn_xacNhan.Size = new System.Drawing.Size(153, 67);
            this.btn_xacNhan.TabIndex = 3;
            this.btn_xacNhan.Text = "Xác nhận";
            this.btn_xacNhan.UseVisualStyleBackColor = false;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Huy.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Huy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Huy.Location = new System.Drawing.Point(391, 524);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(89, 67);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            // 
            // TachHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(679, 617);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_xacNhan);
            this.Controls.Add(this.btn_tachSP);
            this.Controls.Add(this.dtg_hdTach);
            this.Controls.Add(this.dtg_hdTong);
            this.Name = "TachHD";
            this.Text = "TachHD";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdTong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hdTach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_hdTong;
        private System.Windows.Forms.DataGridView dtg_hdTach;
        private System.Windows.Forms.Button btn_tachSP;
        private System.Windows.Forms.Button btn_xacNhan;
        private System.Windows.Forms.Button btn_Huy;
    }
}