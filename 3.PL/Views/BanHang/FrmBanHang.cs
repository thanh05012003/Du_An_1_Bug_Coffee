using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace _3.PL.Views
{
<<<<<<<< HEAD:3.PL/Views/BanHang/FrmBanHang.cs
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
========
    public partial class FrmGiaoHang : Form
    {
        public FrmGiaoHang()
>>>>>>>> 1fff07ceffbd26f6c31ab999b357db1829241eb5:3.PL/Views/BanHang/FrmGiaoHang.cs
        {
            InitializeComponent();
        }
=======
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
>>>>>>> 1fff07ceffbd26f6c31ab999b357db1829241eb5
    }
}
