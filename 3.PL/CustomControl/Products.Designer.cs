namespace customs
{
    partial class Products
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Cost = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pbx_Icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Cost);
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Controls.Add(this.pbx_Icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 187);
            this.panel1.TabIndex = 0;
            // 
            // lb_Cost
            // 
            this.lb_Cost.AutoSize = true;
            this.lb_Cost.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_Cost.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Cost.ForeColor = System.Drawing.Color.White;
            this.lb_Cost.Location = new System.Drawing.Point(19, 151);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(59, 23);
            this.lb_Cost.TabIndex = 5;
            this.lb_Cost.Text = "label2";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Title.ForeColor = System.Drawing.Color.White;
            this.lb_Title.Location = new System.Drawing.Point(19, 121);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(59, 23);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "label1";
            // 
            // pbx_Icon
            // 
            this.pbx_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Icon.Image")));
            this.pbx_Icon.Location = new System.Drawing.Point(19, 12);
            this.pbx_Icon.Name = "pbx_Icon";
            this.pbx_Icon.Size = new System.Drawing.Size(105, 97);
            this.pbx_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Icon.TabIndex = 3;
            this.pbx_Icon.TabStop = false;
            this.pbx_Icon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(142, 187);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Cost;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.PictureBox pbx_Icon;
    }
}
