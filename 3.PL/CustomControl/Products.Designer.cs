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
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lb_Cost);
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Controls.Add(this.pbx_Icon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 187);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // lb_Cost
            // 
            this.lb_Cost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Cost.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Cost.Location = new System.Drawing.Point(17, 157);
            this.lb_Cost.Name = "lb_Cost";
            this.lb_Cost.Size = new System.Drawing.Size(107, 23);
            this.lb_Cost.TabIndex = 5;
            this.lb_Cost.Text = "label2";
            // 
            // lb_Title
            // 
            this.lb_Title.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Title.ForeColor = System.Drawing.Color.Black;
            this.lb_Title.Location = new System.Drawing.Point(3, 105);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lb_Title.Size = new System.Drawing.Size(139, 52);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "label1";
            // 
            // pbx_Icon
            // 
            this.pbx_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pbx_Icon.Image")));
            this.pbx_Icon.Location = new System.Drawing.Point(19, 7);
            this.pbx_Icon.Name = "pbx_Icon";
            this.pbx_Icon.Size = new System.Drawing.Size(105, 97);
            this.pbx_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Icon.TabIndex = 3;
            this.pbx_Icon.TabStop = false;
            this.pbx_Icon.Click += new System.EventHandler(this.pbx_Icon_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbx_Icon;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lb_Cost;
        public System.Windows.Forms.Label lb_Title;
    }
}
