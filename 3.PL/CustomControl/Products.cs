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
        public event EventHandler onSelct = null;
        public event EventHandler Click = null;
        private ISanPhamService _sanPhamService;
        public SanPham sp;
        public Products()
        {
            InitializeComponent();
            _sanPhamService = new SanPhamService();
            Size = new System.Drawing.Size(142, 187);
        
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

        private void pbx_Icon_Click(object sender, EventArgs e)
        {
            onSelct?.Invoke(this, e);
            var spv = _sanPhamService.GetAll().FirstOrDefault(c => c.Ten == lb_Title.Text);
             sp = new SanPham()
            {
                Ten = spv.Ten,
                Gia = spv.Gia,
                Ma = spv.Ma,
                MaLsp = spv.MaLsp,
                MoTa = spv.MoTa
            };
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            onSelct?.Invoke(this, e);
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
