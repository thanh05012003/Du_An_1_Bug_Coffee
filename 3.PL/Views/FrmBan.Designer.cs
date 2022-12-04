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
            this.dgrid_TTSp = new System.Windows.Forms.DataGridView();
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
            // dgrid_TTSp
            // 
            this.dgrid_TTSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_TTSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_TTSp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_TTSp.Location = new System.Drawing.Point(892, 0);
            this.dgrid_TTSp.Name = "dgrid_TTSp";
            this.dgrid_TTSp.RowHeadersWidth = 51;
            this.dgrid_TTSp.RowTemplate.Height = 29;
            this.dgrid_TTSp.Size = new System.Drawing.Size(431, 847);
            this.dgrid_TTSp.TabIndex = 1;
            // 
            // FrmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 847);
            this.Controls.Add(this.dgrid_TTSp);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmBan";
            this.Text = "FrmBan";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_TTSp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgrid_TTSp;
    }
}