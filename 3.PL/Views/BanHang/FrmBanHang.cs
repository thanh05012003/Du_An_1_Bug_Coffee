using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using customs;

namespace _3.PL.Views.BanHang
{
    public partial class FrmBanHang : Form
    {
        private ISanPhamService _sanPhamService;
        private Products pr;
        public FrmBanHang()
        {
            InitializeComponent();
            _sanPhamService = new SanPhamService();
            pane_HDCho.Visible = false;
            loadSp();
        }


        //private void btn_Tach_Click(object sender, EventArgs e)
        //{
        //    FrmTachHD frm = new FrmTachHD();
        //    frm.ShowDialog();
        //}

        //private void btn_giaoHang_Click(object sender, EventArgs e)
        //{
        //    FrmGiaoHang frm = new FrmGiaoHang();
        //    frm.ShowDialog();
        //}



        public void loadSp()
        {

            foreach (var x in _sanPhamService.GetAll())
            
            { 
                if (x.URL != null) {
                    flowLayoutPanel1.Controls.Add(pr = new Products()
                    {
                        Title = x.Ten,
                        Cost = Math.Round(x.Gia, 0).ToString(),
                        Icon = Image.FromFile(x.URL)
                    });
                }else
                {
                    flowLayoutPanel1.Controls.Add(pr = new Products()
                    {
                        Title = x.Ten,
                        Cost = Math.Round(x.Gia, 0).ToString(),
                    });
                }
            }

        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            pane_HDCho.Visible = true;
        }
      

    }
}
