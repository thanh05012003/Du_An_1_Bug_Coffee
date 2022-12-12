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

namespace _3.PL.Views
{
    public partial class FrmDT_SP : Form
    {
        private IHoaDonCTService _hoaDonCTService;
        private IHoaDonService _hoaDonService;
        private int HdBanDay = 0;
        private int HdGiaoDay = 0;
        private int HdBanMon = 0;
        private int HdGiaoMon = 0;
        private int HdBanCs = 0;
        private int HdGiaoCs = 0;
        private int HdBanYear = 0;
        private int HdGiaoYear = 0;
        private decimal tongTien = 0;
        private decimal tongTienThang = 0;
        private decimal tongTienNam = 0;
        private decimal tongCs = 0;
        public FrmDT_SP()
        {
            InitializeComponent();
            _hoaDonCTService = new HoaDonCTService();
            _hoaDonService = new HoaDonService();
            loadThongKeNgay();
            LoadThongKeThang();
            LoadThongKeNam();
        }

        public void loadThongKeNgay()
        {
            tongTien = 0;
            foreach (var x in _hoaDonCTService.GetAll())
            {
                foreach (var c in _hoaDonService.GetAll().Where(c =>c.Ma == x.MaHD))
                {
                    if (c.NgayTao.Value.ToString("d") == DateTime.Now.Date.ToString("d"))
                    {
                        if (c.TrangThai == "Đã thanh toán")
                        {
                            tongTien += (x.DonGia * x.SoLuong);
                            HdBanDay = _hoaDonService.GetAll().Where(c =>c.MaBan!=null && c.NgayTao.Value.ToString("d") == DateTime.Now.ToString("d")).Count();
                            HdGiaoDay = _hoaDonService.GetAll().Where(c => c.MaBan == null && c.NgayTao.Value.ToString("d") == DateTime.Now.ToString("d")).Count();
                        }
                    }
                }
            }
            lbl_VndToday.Text = tongTien.ToString("C0");
            lbl_BanToday.Text = HdBanDay.ToString();
            lbl_GiaoToday.Text = HdGiaoDay.ToString();
        }

        public bool Check()
        {
            if (dtp_denNgay.Value < dtp_tuNgay.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }
            else
            {
                return true;
            }

            return false;
        }
        public void loadThongKeTuyChon()
        {
            foreach (var x in _hoaDonCTService.GetAll())
            {
                foreach (var c in _hoaDonService.GetAll().Where(c => c.Ma == x.MaHD))
                {
                    if (c.NgayTao.Value >= dtp_tuNgay.Value && c.NgayTao.Value <= dtp_denNgay.Value)
                    {
                        if (c.TrangThai == "Đã thanh toán")
                        {
                            tongCs += (x.DonGia * x.SoLuong);
                            HdBanCs = _hoaDonService.GetAll().Where(c => c.MaBan != null && (c.NgayTao.Value >= dtp_tuNgay.Value && c.NgayTao.Value <= dtp_denNgay.Value)).Count();
                            HdGiaoCs = _hoaDonService.GetAll().Where(c => c.MaBan == null && (c.NgayTao.Value >= dtp_tuNgay.Value && c.NgayTao.Value <= dtp_denNgay.Value)).Count();
                        }
                    }
                    else
                    {
                        if (dtp_tuNgay.Value == dtp_denNgay.Value && dtp_tuNgay.Value.ToString("d") == c.NgayTao.Value.ToString("d"))
                        {
                            tongCs += (x.DonGia * x.SoLuong);
                            HdBanCs = _hoaDonService.GetAll().Where(c => c.MaBan != null).Count();
                            HdGiaoCs = _hoaDonService.GetAll().Where(c => c.MaBan == null).Count();
                        }
                    }
                }
            }
            lbl_Customs.Text = tongCs.ToString("C0");
            tongCs = 0;
            lbl_BanCs.Text = HdBanCs.ToString();
            lbl_GiaoCs.Text = HdGiaoCs.ToString();
        }
        public void LoadThongKeThang()
        {
            
            foreach (var x in _hoaDonCTService.GetAll())
            {
                foreach (var c in _hoaDonService.GetAll().Where(c => c.Ma == x.MaHD))
                {
                    if (c.TrangThai == "Đã thanh toán")
                    {
                        if (c.NgayTao.Value.Month.ToString() == DateTime.Now.Month.ToString())
                        {
                            tongTienThang += (x.DonGia * x.SoLuong);
                            HdBanMon = _hoaDonService.GetAll().Where(c => c.MaBan != null && (c.NgayTao.Value.Month.ToString() == DateTime.Now.Month.ToString())).Count();
                            HdGiaoMon = _hoaDonService.GetAll().Where(c => c.MaBan == null && (c.NgayTao.Value.Month.ToString() == DateTime.Now.Month.ToString())).Count();
                        }
                    }
                }
            }

            lbl_TkMonth.Text = tongTienThang.ToString("C0");
            lbl_BanMonth.Text = HdBanMon.ToString();
            lbl_GiaoMonth.Text = HdGiaoMon.ToString();
        }
        public void LoadThongKeNam()
        {

            foreach (var x in _hoaDonCTService.GetAll())
            {
                foreach (var c in _hoaDonService.GetAll().Where(c => c.Ma == x.MaHD))
                {
                    if (c.TrangThai == "Đã thanh toán")
                    {
                        if (c.NgayTao.Value.Year.ToString() == DateTime.Now.Year.ToString())
                        {
                            tongTienNam += (x.DonGia * x.SoLuong);
                            HdBanYear = _hoaDonService.GetAll().Where(c => c.MaBan != null && (c.NgayTao.Value.Year.ToString() == DateTime.Now.Year.ToString())).Count();
                            HdGiaoYear = _hoaDonService.GetAll().Where(c => c.MaBan == null && (c.NgayTao.Value.Year.ToString() == DateTime.Now.Year.ToString())).Count();
                        }
                    }
                }
            }

            lb_TkNam.Text = tongTienNam.ToString("C0");
            lb_TaiQuanYear.Text = HdBanYear.ToString();
            lb_MangDiYear.Text = HdGiaoYear.ToString();
        }

        private void btn_Chọn_Click_1(object sender, EventArgs e)
        {
            if (Check())
            {
                loadThongKeTuyChon();
            }
            
        }
    }
}
