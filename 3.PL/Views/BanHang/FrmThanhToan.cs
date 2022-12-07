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
using _2.BUS.ViewModels;

namespace _3.PL.Views.BanHang
{
    public partial class FrmThanhToan : Form
    {
        private IKhachHangService _KhachHangService;
        private IHoaDonCTService _HoaDonCTService;
        private IHoaDonService _HoaDonService;
        private decimal tongtien = 0;
        private QlKhachHangView _QlKhachHangView;
        private IBanService _BanService;
        public FrmThanhToan()
        {
            InitializeComponent();
            _KhachHangService = new KhachHangService();
            _HoaDonCTService = new HoaDonCTService();
            _HoaDonService = new HoaDonService();
            _QlKhachHangView = new QlKhachHangView();
            _BanService = new BanService();
            loadTenKH();
        }

        public void loadTenKH()
        {
            foreach (var x in _KhachHangService.GetAll())
            {
                cmb_TenKh.Items.Add(x.Ten);
            }
        }
        public QlKhachHangView getDataformGui()
        {
            QlKhachHangView kh = new QlKhachHangView()
            {

            };
            return kh;
        }
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            frm.ShowDialog();
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
           
            foreach (var x in _HoaDonCTService.GetAll().Where(c =>c.MaHD == Properties.Settings.Default.MaHd))
            {
                tongtien += (x.DonGia * x.SoLuong);
            }
            lb_TongTien.Text = tongtien.ToString("C0");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            var hd = _HoaDonService.GetAll().FirstOrDefault(c => c.MaBan == Properties.Settings.Default.MaBan || c.Ma == Properties.Settings.Default.MaHd);
            var ban = _BanService.GetAll().FirstOrDefault(c => c.Ma == Properties.Settings.Default.MaBan);
            hd.TrangThai = "Đã thanh toán";
            if (ban !=null)
            {
                ban.TrangThai = 1;
                _BanService.update(ban);
            }
            if (hd!=null)
            {
                hd.MaKH = _QlKhachHangView.Ma;
                _HoaDonService.update(hd);
                MessageBox.Show("Thanh toán thành công");
                this.Close();
            }
        }

        private void btn_SearchKH_Click(object sender, EventArgs e)
        {
           _QlKhachHangView = _KhachHangService.GetAll().FirstOrDefault(c => c.SDT == txt_SDT.Texts.Trim());
            if (txt_SDT.Texts.Trim() !="")
            {
                if (_QlKhachHangView!=null)
                {
                    cmb_TenKh.Texts = _QlKhachHangView.Ten;
                    lb_DiaChi.Text = _QlKhachHangView.DiaChi;
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

        private void txt_TienKhachDua__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_TienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_TienKhachDua_Leave(object sender, EventArgs e)
        {
            var tientralai = (decimal.Parse(txt_TienKhachDua.Texts) - tongtien);
            Lb_TienTraLai.Text = Math.Round(tientralai, 0).ToString();
        }

        private void txt_TienKhachDua_Enter(object sender, EventArgs e)
        {
            //var tientralai = (decimal.Parse(txt_TienKhachDua.Texts) - tongtien);
            //Lb_TienTraLai.Text = Math.Round(tientralai, 0).ToString();
        }

        private void txt_TienKhachDua_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
