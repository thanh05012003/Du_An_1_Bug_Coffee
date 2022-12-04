using System;
using System.Drawing;
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
            pr= new Products();
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
                flowLayoutPanel1.Controls.Add(new Products()
                {
                    Title = x.Ten,
                    Cost = Math.Round(x.Gia, 0).ToString(),
                    Icon = Image.FromFile(x.URL)
                });
            }
        }

        public void loadHD()
        {
            //dtg_hdNew.ColumnCount = 1;
            //dtg_hdNew.Columns[0].Name = "Ten";
            //dtg_hdNew.Rows.Add();
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            pane_HDCho.Visible = true;
        }

        private void btn_ThemVaoHD_Click(object sender, EventArgs e)
        {
            loadHD();
        }
    }
}
