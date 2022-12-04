namespace _3.PL.Views
{
    partial class FrmBan
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThanhToan = new CustomControls.RJControls.CSButton();
            this.dgrid_TTSp = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TTSp)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(892, 847);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(892, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 340);
            this.panel1.TabIndex = 1;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ThanhToan.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_ThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThanhToan.BorderRadius = 0;
            this.btn_ThanhToan.BorderSize = 0;
            this.btn_ThanhToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.btn_ThanhToan.Location = new System.Drawing.Point(0, 252);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(431, 88);
            this.btn_ThanhToan.TabIndex = 0;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.TextColor = System.Drawing.Color.White;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // dgrid_TTSp
            // 
            this.dgrid_TTSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_TTSp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_TTSp.Location = new System.Drawing.Point(892, 0);
            this.dgrid_TTSp.Name = "dgrid_TTSp";
            this.dgrid_TTSp.RowHeadersWidth = 51;
            this.dgrid_TTSp.RowTemplate.Height = 29;
            this.dgrid_TTSp.Size = new System.Drawing.Size(431, 507);
            this.dgrid_TTSp.TabIndex = 2;
            // 
            // FrmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 847);
            this.Controls.Add(this.dgrid_TTSp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmBan";
            this.Text = "FrmBan";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TTSp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrid_TTSp;
        private CustomControls.RJControls.CSButton btn_ThanhToan;
    }
}