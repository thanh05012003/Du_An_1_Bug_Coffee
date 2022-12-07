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
        private IVoucherService _voucherService;
        private string _maWhenClick;
        public FrmHDPhaChe()
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            _hoaDonCTService = new HoaDonCTService();
            _voucherService = new VoucherService();
            loadHoaDon();
        }

        public void loadHoaDon()
        {
            dgrid_HoaDon.ColumnCount = 5;
            dgrid_HoaDon.Columns[0].Name = "Mã HD";
            dgrid_HoaDon.Columns[1].Name = "Tên NV";
            dgrid_HoaDon.Columns[2].Name = "Ngày tạo";
            dgrid_HoaDon.Columns[3].Name = "Trạng thái";
            dgrid_HoaDon.Columns[4].Name = "Ghi chú";
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll())
            {
                if (x.TrangThai == "Chờ pha chế" || x.GhiChu =="Mang đi")
                {
                    dgrid_HoaDon.Rows.Add(x.Ma, x.TenNV, x.NgayTao,x.TrangThai,x.GhiChu);
                }
            }
        }

        public void LoadHdCT(string Ma)
        {
            dgrid_HoaDonCT.ColumnCount = 3;
            dgrid_HoaDonCT.Columns[0].Name = "Tên";
            dgrid_HoaDonCT.Columns[1].Name = "Số lượng";
            dgrid_HoaDonCT.Columns[2].Name = "Đơn giá";
            dgrid_HoaDonCT.Rows.Clear();
            foreach (var x in _hoaDonCTService.GetAll(Ma))
            {
                dgrid_HoaDonCT.Rows.Add(x.TenSp, x.SoLuong, x.DonGia);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
         
        }

        private void dgrid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _hoaDonService.GetAll().Where(c => (c.TrangThai == "Đã thanh toán" && c.GhiChu == "Mang đi") || c.TrangThai == "Chờ pha chế").Count())
            {
                return;
            }
            _maWhenClick =  dgrid_HoaDon.Rows[rowIndex].Cells[0].Value.ToString();
            if (_maWhenClick.Trim() != "")
            {
                dgrid_HoaDonCT.ColumnCount = 3;
                dgrid_HoaDonCT.Columns[0].Name = "Tên";
                dgrid_HoaDonCT.Columns[1].Name = "Số lượng";
                dgrid_HoaDonCT.Columns[2].Name = "Đơn giá";
                dgrid_HoaDonCT.Rows.Clear();
                foreach (var x in _hoaDonCTService.GetAll().Where(c =>c.MaHD == _maWhenClick.Trim()))
                {
                    dgrid_HoaDonCT.Rows.Add(x.TenSp, x.SoLuong, x.DonGia);
                }
            }
        }
    }
}
