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
    public partial class FrmHDPhaChe : Form
    {
        private IHoaDonService _hoaDonService;
        private IHoaDonCTService _hoaDonCTService;
        public FrmHDPhaChe()
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            _hoaDonCTService = new HoaDonCTService();
            loadHoaDon();
            LoadHdCT();
        }

        public void loadHoaDon()
        {
            dgrid_HoaDon.ColumnCount = 5;
            dgrid_HoaDon.Columns[0].Name = "Mã HD";
            dgrid_HoaDon.Columns[1].Name = "Tên KH";
            dgrid_HoaDon.Columns[2].Name = "Tên NV";
            dgrid_HoaDon.Columns[3].Name = "Ngày tạo";
            dgrid_HoaDon.Columns[4].Name = "Voucher";
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll())
            {
                dgrid_HoaDon.Rows.Add(x.Ma);
            }
        }

        public void LoadHdCT()
        {
            dgrid_HoaDonCT.ColumnCount = 3;
            dgrid_HoaDonCT.Columns[0].Name = "Tên";
            dgrid_HoaDonCT.Columns[1].Name = "Số lượng";
            dgrid_HoaDonCT.Columns[2].Name = "Đơn giá";
            dgrid_HoaDonCT.Rows.Clear();
            foreach (var x in _hoaDonCTService.GetAll())
            {
                dgrid_HoaDonCT.Rows.Add(x.TenSp,x.SoLuong,x.DonGia);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            LoadHdCT();
        }
    }
}
