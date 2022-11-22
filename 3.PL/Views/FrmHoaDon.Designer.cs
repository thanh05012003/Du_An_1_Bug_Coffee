namespace _3.PL.Views
{
    partial class FrmHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LichSu = new System.Windows.Forms.Button();
            this.btn_PhaChe = new System.Windows.Forms.Button();
            this.pane_HoaDon = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_LichSu);
            this.panel1.Controls.Add(this.btn_PhaChe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 45);
            this.panel1.TabIndex = 0;
            // 
            // btn_LichSu
            // 
            this.btn_LichSu.BackColor = System.Drawing.Color.White;
            this.btn_LichSu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_LichSu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_LichSu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_LichSu.Location = new System.Drawing.Point(109, 0);
            this.btn_LichSu.Name = "btn_LichSu";
            this.btn_LichSu.Size = new System.Drawing.Size(109, 45);
            this.btn_LichSu.TabIndex = 3;
            this.btn_LichSu.Text = "Lịch sử HD";
            this.btn_LichSu.UseVisualStyleBackColor = false;
            this.btn_LichSu.Click += new System.EventHandler(this.btn_LichSu_Click);
            // 
            // btn_PhaChe
            // 
            this.btn_PhaChe.BackColor = System.Drawing.Color.White;
            this.btn_PhaChe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_PhaChe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PhaChe.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PhaChe.Location = new System.Drawing.Point(0, 0);
            this.btn_PhaChe.Name = "btn_PhaChe";
            this.btn_PhaChe.Size = new System.Drawing.Size(109, 45);
            this.btn_PhaChe.TabIndex = 2;
            this.btn_PhaChe.Text = "HD Pha chế";
            this.btn_PhaChe.UseVisualStyleBackColor = false;
            this.btn_PhaChe.Click += new System.EventHandler(this.btn_PhaChe_Click);
            // 
            // pane_HoaDon
            // 
            this.pane_HoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pane_HoaDon.Location = new System.Drawing.Point(0, 32);
            this.pane_HoaDon.Name = "pane_HoaDon";
            this.pane_HoaDon.Size = new System.Drawing.Size(1323, 828);
            this.pane_HoaDon.TabIndex = 1;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 860);
            this.Controls.Add(this.pane_HoaDon);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pane_HoaDon;
        private System.Windows.Forms.Button btn_LichSu;
        private System.Windows.Forms.Button btn_PhaChe;
    }
}