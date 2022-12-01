using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customs;

namespace _3.PL.Views.BanHang
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
        }


        private void btn_Tach_Click(object sender, EventArgs e)
        {
            FrmTachHD frm = new FrmTachHD();
            frm.ShowDialog();
        }

        private void btn_giaoHang_Click(object sender, EventArgs e)
        {
            FrmGiaoHang frm = new FrmGiaoHang();
            frm.ShowDialog();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {

        }
        private string path = @"C:\Users\ADMIN\Downloads\icons8-name-48.png";
        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Products()
            {
                Title = "Cafe",
                Cost = "1000",
                Icon = Image.FromFile(path)
            });
        }
    }
}
