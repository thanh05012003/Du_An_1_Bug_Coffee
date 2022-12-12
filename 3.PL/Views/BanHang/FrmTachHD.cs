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

namespace _3.PL.Views
{
    public partial class FrmTachHD : Form
    {
        private IHoaDonCTService _hoaDonCTService;
        private IHoaDonService _HoaDonService;
        private INhanVienService _nhanVienService;
        private IBanService _banService;
        private ISanPhamService _sanPPhamService;
        private string _maSPWhenClick;
        private string _maHDWhenClick;
        private int SoLuong = 0;
        string maHd;
        public FrmTachHD()
        {
            InitializeComponent();
            _hoaDonCTService = new HoaDonCTService();
            _HoaDonService = new HoaDonService();
            _banService = new BanService();
            _sanPPhamService = new SanPhamService();
            _nhanVienService = new NhanVienService();
            loadHdTong();
            loadHdTach();
            LoadBan();
        }

        public void LoadBan()
        {
            cmb_BanTach.Items.Clear();
            foreach (var x in _banService.GetAll().Where(c =>c.TrangThai == 1))
            {
                cmb_BanTach.Items.Add(x.Ten);
            }
        }
        public void loadHdTong()
        {
            dtg_hdTong.ColumnCount = 5;
            dtg_hdTong.Columns[0].Name = "Mã";
            dtg_hdTong.Columns[1].Name = "Mã sp";
            dtg_hdTong.Columns[2].Name = "Tên";
            dtg_hdTong.Columns[3].Name = "Đơn giá";
            dtg_hdTong.Columns[4].Name = "Số lượng";
            dtg_hdTong.Columns["Mã"].Visible = false;
            dtg_hdTong.Rows.Clear();
            foreach (var hd in _HoaDonService.GetAll().Where(c => c.MaBan == Properties.Settings.Default.MaBan))
            {
                if (hd.TrangThai == "Chờ pha chế" || hd.TrangThai == "Chờ thanh toán")
                {
                    foreach (var x in _hoaDonCTService.GetAll().Where(c => c.MaHD == hd.Ma))
                    {
                        dtg_hdTong.Rows.Add(x.MaHD,x.MaSP, x.TenSp, x.DonGia, x.SoLuong);
                    }
                }
            }
        }
        public void loadHdTach()
        {
            if (_maSPWhenClick == null)
            {
                return;
            }
            dtg_hdTach.ColumnCount = 4;
            dtg_hdTach.Columns[0].Name = "Mã sp";
            dtg_hdTach.Columns[1].Name = "Tên";
            dtg_hdTach.Columns[2].Name = "Đơn giá";
            dtg_hdTach.Columns[3].Name = "Số lượng";
            dtg_hdTach.Rows.Clear();
            foreach (var x in _hoaDonCTService.GetAll().Where(c => c.MaHD == maHd))
            {
                dtg_hdTach.Rows.Add(x.MaSP, x.TenSp, x.DonGia, x.SoLuong);
            }
        }

        private void dtg_hdTong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          int rowIndex = e.RowIndex;
            if (rowIndex == _hoaDonCTService.GetAll().Where(c => c.MaHD == Properties.Settings.Default.MaHd).Count())
            {
                return;
            }
            
            _maHDWhenClick = dtg_hdTong.Rows[rowIndex].Cells[0].Value.ToString();
            _maSPWhenClick = dtg_hdTong.Rows[rowIndex].Cells[1].Value.ToString();
            var hdct = _hoaDonCTService.GetAll().FirstOrDefault(c => c.MaHD == _maHDWhenClick && c.MaSP == _maSPWhenClick);
            nud_SoLuong.Text = hdct.SoLuong.ToString();
            nud_SoLuong.Maximum = hdct.SoLuong;
        }


        private void btn_tachSP_Click(object sender, EventArgs e)
        {
            if (cmb_BanTach.Texts.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn bàn");
                return;
            }
            var ban = _banService.GetAll().FirstOrDefault(c => c.Ten == cmb_BanTach.Texts);
            var sp = _sanPPhamService.GetAll().FirstOrDefault(c => c.Ma == _maSPWhenClick);
            Random rd = new Random();
            var hd = _HoaDonService.GetAll().FirstOrDefault(c => c.Ma == _maHDWhenClick);

            QlHoaDonView getdata = new QlHoaDonView();
            getdata = new QlHoaDonView()
            {
                Ma = "HD" + (_HoaDonService.GetAll().Count + rd.Next(1000000)), // Tạo mã Random
                MaBan = ban.Ma,
                MaNV = hd.MaNV,
                NgayTao = DateTime.Now,
                TrangThai = hd.TrangThai
            };
            maHd = getdata.Ma;
            _HoaDonService.add(getdata);
            ban.TrangThai = 0;
            _banService.update(ban);
            foreach (var hdct in _hoaDonCTService.GetAll().Where(c => c.MaHD == _maHDWhenClick && c.MaSP == _maSPWhenClick))
            {
                QlHoaDonCTView dataHdCt = new QlHoaDonCTView()
                {
                    MaHD = getdata.Ma,
                    DonGia = sp.Gia,
                    MaSP = sp.Ma,
                    SoLuong = int.Parse(nud_SoLuong.Text),
                    TrangThai = hdct.TrangThai,
                };
                _hoaDonCTService.add(dataHdCt);
                if (nud_SoLuong.Text == hdct.SoLuong.ToString())
                {
                    _hoaDonCTService.delete(hdct);
                }
                else
                {
                    hdct.SoLuong -= int.Parse(nud_SoLuong.Text);
                    _hoaDonCTService.update(hdct);
                }
                MessageBox.Show("Thêm thành công");
            }

            loadHdTong();
            loadHdTach();
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thành công");
            this.Hide();
            loadHdTong();
            loadHdTach();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
