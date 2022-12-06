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

namespace _3.PL.Views.BanHang
{
    public partial class FrmThanhToan : Form
    {
        IKhachHangService _KhachHangService;
        public FrmThanhToan()
        {
            InitializeComponent();
            _KhachHangService = new KhachHangService();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            frm.ShowDialog();
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btn_SearchKH_Click(object sender, EventArgs e)
        {
            var kh = _KhachHangService.GetAll().FirstOrDefault(c => c.SDT == txt_SDT.Texts.Trim());
            if (txt_SDT.Texts.Trim() !="")
            {
                if (kh!=null)
                {
                    lb_TenKH.Text = kh.Ten;
                    lb_DiaChi.Text = kh.DiaChi;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
