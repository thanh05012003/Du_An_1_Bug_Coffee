using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmLichSuHD : Form
    {
        private IHoaDonService _ihoaDonServices;
        private IHoaDonCTService _ihoaDonCTServices;
        private ISanPhamService _isanPhamServices;
        public FrmLichSuHD()
        {
            InitializeComponent();
            _ihoaDonServices = new HoaDonService();
            _ihoaDonCTServices = new HoaDonCTService();
            _isanPhamServices = new SanPhamService();
            LoadHoaDon();
            LoadHoaDonCT();
        }

        public void LoadHoaDon()
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 8;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "Mã HĐ";
            dgrid_HoaDon.Columns[2].Name = "Mã Khách Hàng";
            dgrid_HoaDon.Columns[3].Name = "Mã Nhân Viên";
            dgrid_HoaDon.Columns[4].Name = "Ngày Tạo";
            dgrid_HoaDon.Columns[5].Name = "Mã Voucher";
            dgrid_HoaDon.Columns[6].Name = "Trạng Thái";
            dgrid_HoaDon.Columns[7].Name = "Ghi Chú";
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in _ihoaDonServices.GetAll())
            {
                dgrid_HoaDon.Rows.Add(stt++,x.Ma,x.MaKH,x.MaNV,x.NgayTao,x.MaVC,x.TrangThai,x.GhiChu);
            }
        }

        public void LoadHoaDonCT()
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 6;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "Mã HĐ";
            dgrid_HoaDon.Columns[2].Name = "Mã Sản Phẩm";
            dgrid_HoaDon.Columns[3].Name = "Số Lượng";
            dgrid_HoaDon.Columns[4].Name = "Đơn Giá";
            dgrid_HoaDon.Columns[5].Name = "Mã Bàn";
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in _ihoaDonCTServices.GetAll())
            {
                dgrid_HoaDon.Rows.Add(stt++, x.MaHD, x.MaSP, x.SoLuong,x.DonGia);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 8;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "Mã HĐ";
            dgrid_HoaDon.Columns[2].Name = "Mã Khách Hàng";
            dgrid_HoaDon.Columns[3].Name = "Mã Nhân Viên";
            dgrid_HoaDon.Columns[4].Name = "Ngày Tạo";
            dgrid_HoaDon.Columns[5].Name = "Mã Voucher";
            dgrid_HoaDon.Columns[6].Name = "Trạng Thái";
            dgrid_HoaDon.Columns[7].Name = "Ghi Chú";
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in _ihoaDonServices.GetAll())
            {
                dgrid_HoaDon.Rows.Add(stt++, x.Ma, x.MaKH, x.MaNV, x.NgayTao, x.MaVC, x.TrangThai, x.GhiChu);
            }
            int value;
            if (txt_TimKiem.Text != "")
            {
                if (int.TryParse(txt_TimKiem.Text, out value))
                {
                    var items = _ihoaDonServices.GetAll().Where(x => x.Ma.ToString().Contains(value.ToString()));
                    if (items.Any())
                    {
                        foreach (var x in items)
                        {
                            dgrid_HoaDon.Rows.Add(x.Ma, x.MaKH, x.MaNV, x.NgayTao,x.MaVC, x.TrangThai,x.GhiChu);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã hóa đơn tương ứng");
                        LoadHoaDon();
                    }
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn phải là số");
                    LoadHoaDon();
                }
            }
        }
    }
}
