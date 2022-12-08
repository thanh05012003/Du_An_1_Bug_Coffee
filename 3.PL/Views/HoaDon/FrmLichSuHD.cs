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
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmLichSuHD : Form
    {
        private IHoaDonService _ihoaDonServices;
        private IHoaDonCTService _ihoaDonCTServices;
        private IKhachHangService _khachHangService;
        private string _maHdWhenClick;
        public FrmLichSuHD()
        {
            InitializeComponent();
            _ihoaDonServices = new HoaDonService();
            _ihoaDonCTServices = new HoaDonCTService();
           _khachHangService = new KhachHangService();
            LoadHoaDon();
            LoadHoaDonCT(null);
        }

        public void LoadHoaDon()
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 8;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "Mã HĐ";
            dgrid_HoaDon.Columns[2].Name = "Tên Khách Hàng";
            dgrid_HoaDon.Columns[3].Name = "Mã Nhân Viên";
            dgrid_HoaDon.Columns[4].Name = "Ngày Tạo";
            dgrid_HoaDon.Columns[5].Name = "Mã Voucher";
            dgrid_HoaDon.Columns[6].Name = "Trạng Thái";
            dgrid_HoaDon.Columns[7].Name = "Ghi Chú";
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in _ihoaDonServices.GetAll())
            {
                if (x.TrangThai == "Đã thanh toán")
                {
                    dgrid_HoaDon.Rows.Add(stt++, x.Ma, x.TenKH, x.MaNV, x.NgayTao, x.MaVC, x.TrangThai, x.GhiChu);
                }
            }
        }

        public void LoadHoaDonCT(string input)
        {
            int stt = 1;
            dgrid_HoaDonCT.ColumnCount = 6;
            dgrid_HoaDonCT.Columns[0].Name = "STT";
            dgrid_HoaDonCT.Columns[1].Name = "Mã HĐ";
            dgrid_HoaDonCT.Columns[2].Name = "Mã Sản Phẩm";
            dgrid_HoaDonCT.Columns[3].Name = "Số Lượng";
            dgrid_HoaDonCT.Columns[4].Name = "Đơn Giá";
            dgrid_HoaDonCT.Columns[5].Name = "Mã Bàn";
            dgrid_HoaDonCT.Rows.Clear();
            foreach (var x in _ihoaDonCTServices.GetAll().Where(c =>c.MaHD == input))
            {
                foreach (var c in _ihoaDonServices.GetAll().Where(c =>c.Ma == x.MaHD))
                {
                    dgrid_HoaDonCT.Rows.Add(stt++, x.MaHD, x.TenSp, x.SoLuong,x.DonGia.ToString("C0"),c.MaBan);
                }
                
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 8;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "Mã HĐ";
            dgrid_HoaDon.Columns[2].Name = "Tên Khách Hàng";
            dgrid_HoaDon.Columns[3].Name = "Mã Nhân Viên";
            dgrid_HoaDon.Columns[4].Name = "Ngày Tạo";
            dgrid_HoaDon.Columns[5].Name = "Mã Voucher";
            dgrid_HoaDon.Columns[6].Name = "Trạng Thái";
            dgrid_HoaDon.Columns[7].Name = "Ghi Chú";
            dgrid_HoaDon.Rows.Clear();
            foreach (var x in _ihoaDonServices.GetAll().Where(c => c.Ma == txt_TimKiem.Text))
            {
                dgrid_HoaDon.Rows.Add(stt++, x.Ma, x.TenKH, x.MaNV, x.NgayTao, x.MaVC, x.TrangThai, x.GhiChu);

            }
        }

        private void dgrid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _ihoaDonServices.GetAll().Count)
            {
                return;
            }

            try
            {
                _maHdWhenClick = dgrid_HoaDon.Rows[rowIndex].Cells[1].Value.ToString();
            }
            catch (Exception exception)
            {
               return;
            }
            LoadHoaDonCT(_maHdWhenClick);
            decimal tongtien = 0;
            foreach (var x in _ihoaDonCTServices.GetAll().Where(c => c.MaHD == _maHdWhenClick))
            {
                foreach (var c in _ihoaDonServices.GetAll().Where(c =>c.Ma == x.MaHD))
                {
                    lbl_MaHD.Text = c.Ma;
                    lbl_KhachHang.Text = c.MaKH;
                    lbl_TGTao.Text = c.NgayTao.Value.ToString("dd-MM-yyyy HH:mm:ss");
                    tongtien += (x.DonGia * x.SoLuong);
                }
               
            }
            lbl_TongTienSP.Text = tongtien.ToString("C0");
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            var hd = _ihoaDonServices.GetAll().FirstOrDefault(c => c.Ma == _maHdWhenClick);
            if (hd != null)
            {
                hd.TrangThai = "Chờ pha chế";
                hd.GhiChu = "Khôi phục hoá đơn vì "+ txt_GhiChu.Text;
                _ihoaDonServices.update(hd);
                MessageBox.Show("Khôi phục thành công");
                LoadHoaDon();
                LoadHoaDonCT(null);
            }
        }
    }
}
