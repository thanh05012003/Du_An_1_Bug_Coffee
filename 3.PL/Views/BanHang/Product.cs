using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.BanHang
{
    public partial class Product : Form
    {
        private Image _icon;
        private string _title;
        private string _cost;
        public Product()
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
    }
}
