using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.SanPham
{
    public partial class FrmLoaiSP : Form
    {
        private ILoaiSanPhamService _iloaiSanPhamServices;
        public FrmLoaiSP()
        {
            InitializeComponent();
            _iloaiSanPhamServices = new LoaiSanPhamService();
        }


        private QlLoaiSanPhamView GetDatafromGui()
        {
            QlLoaiSanPhamView lsp = new QlLoaiSanPhamView();
            lsp = new QlLoaiSanPhamView()
            {
                Ma = txt_MaLSP.Text,
                Ten = txt_TenLSP.Text,
            };
            return lsp;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iloaiSanPhamServices.add(GetDatafromGui()));
        }

        private void txt_TenLSP_TextChanged(object sender, EventArgs e)
        {
            txt_MaLSP.Text = "LSP0" + (_iloaiSanPhamServices.GetAll().Count + 1);
        }
    }
}
