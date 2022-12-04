using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace customs
{
    public partial class Products : UserControl
    {
        private Image _icon;
        private string _title;
        private string _cost;
 
       
        public Products()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => lb_Title.Text;
            set => lb_Title.Text = value;
        }

        public string Cost
        {
            get => lb_Cost.Text;
            set => lb_Cost.Text = value;
        }

        public Image? Icon
        {
            get => pbx_Icon.Image;
            set => pbx_Icon.Image = value;
        }

        public void pbx_Icon_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
           
        }

        private void Products_Click(object sender, EventArgs e)
        {

        }
    }
}
