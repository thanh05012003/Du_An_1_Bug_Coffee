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
        private IBanService _banService;
        private string _maWhenClick;
        private string _maSPWhenClick;
        private string _mahdctWhenClick;
        public FrmHDPhaChe()
        {
            InitializeComponent();
            _hoaDonService = new HoaDonService();
            _hoaDonCTService = new HoaDonCTService();
            _voucherService = new VoucherService();
            _banService = new BanService();
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
                if (x.TrangThai == "Chờ pha chế" || x.GhiChu == "Mang đi" && x.TrangThai != "Hoàn thành" || x.GhiChu == "Chờ pha chế" )
                {
                    dgrid_HoaDon.Rows.Add(x.Ma, x.TenNV, x.NgayTao,x.TrangThai,x.GhiChu);
                }
            }
        }


        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (_mahdctWhenClick ==null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
            DialogResult dlg = MessageBox.Show("Xác nhận đã hoàn thành món này", "xác nhận", MessageBoxButtons.OKCancel);
            if ( dlg == DialogResult.OK)
            {
                var hdct = _hoaDonCTService.GetAll().Where(x => x.MaHD == _mahdctWhenClick && x.MaSP == _maSPWhenClick).FirstOrDefault();
                hdct.MaHD = _mahdctWhenClick;
                hdct.MaSP = _maSPWhenClick;
                hdct.TrangThai = "Hoàn thành";
                MessageBox.Show(_hoaDonCTService.update(hdct));
                loadHdCt();
                loadHoaDon();
            }
        }

        public void loadHdCt()
        {
            dgrid_HoaDonCT.ColumnCount = 6;
            dgrid_HoaDonCT.Columns[0].Name = "Mã";
            dgrid_HoaDonCT.Columns[1].Name = "Mã sp";
            dgrid_HoaDonCT.Columns[2].Name = "Tên";
            dgrid_HoaDonCT.Columns[3].Name = "Số lượng";
            dgrid_HoaDonCT.Columns[4].Name = "Đơn giá";
            dgrid_HoaDonCT.Columns[5].Name = "Trạng thái";
            dgrid_HoaDonCT.Columns["Mã"].Visible = false;
            dgrid_HoaDonCT.Columns["Mã sp"].Visible = false;
            dgrid_HoaDonCT.Rows.Clear();
            foreach (var x in _hoaDonCTService.GetAll().Where(c =>c.MaHD == _maWhenClick))
            {
                dgrid_HoaDonCT.Rows.Add(x.MaHD,x.MaSP,x.TenSp, x.SoLuong, x.DonGia,x.TrangThai);
            }
        }

        private void dgrid_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _hoaDonService.GetAll().Where(c => (c.TrangThai == "Đã thanh toán" && c.GhiChu == "Mang đi") || c.TrangThai == "Chờ pha chế"|| (c.TrangThai == "Đã thanh toán" && c.GhiChu == "Chờ pha chế")).Count())
            {
                return;
            }
            try
            {
                _maWhenClick = dgrid_HoaDon.Rows[rowIndex].Cells[0].Value.ToString();
               
            }
            catch (Exception exception)
            {
               return;
            }
            if (_maWhenClick != null)
            {
                loadHdCt(); 
            }
        }

        private void dgrid_HoaDonCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _hoaDonCTService.GetAll().Where(c =>c.MaHD == _maWhenClick).Count())
            {
                return;
            }

            try
            {
                _maSPWhenClick = dgrid_HoaDonCT.Rows[rowIndex].Cells[1].Value.ToString();
                _mahdctWhenClick = dgrid_HoaDonCT.Rows[rowIndex].Cells[0].Value.ToString();
            }
            catch (Exception exception)
            {
               return;
            }
        }

        private void btn_XacNhan_Click_1(object sender, EventArgs e)
        {
            if (_maWhenClick == null)
            {
                MessageBox.Show("Vui lòng chọn hoá đơn");
                return;
            }
            DialogResult dlg = MessageBox.Show("Xác nhận đã hoàn thành đơn này", "xác nhận", MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {
                var hd = _hoaDonService.GetAll().Where(x => x.Ma == _maWhenClick ).FirstOrDefault();
                if (hd.TrangThai == "Mang đi")
                {
                    hd.GhiChu = "Chờ thanh toán";
                }
                else if (hd.TrangThai == "Chờ pha chế" && hd.GhiChu == "Mang đi")
                {
                    hd.TrangThai = "Hoàn thành";
                }
                else if (hd.TrangThai == "Chờ pha chế")
                {
                    hd.TrangThai = "Chờ thanh toán";
                }
                else if (hd.GhiChu == "Chờ pha chế")
                {
                    hd.GhiChu = "Hoàn thành";
                }
                MessageBox.Show(_hoaDonService.update(hd));
                loadHdCt();
                loadHoaDon();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Xác nhận xoá món này", "xác nhận", MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {

                var x = _hoaDonCTService.GetAll().FirstOrDefault(c => c.MaHD.Contains(_maWhenClick));
                
                var hd = _hoaDonService.GetAll().FirstOrDefault(c => c.Ma == _maWhenClick);
                if (x == null)
                {
                    if (hd.MaBan != null)
                    {
                        var ban = _banService.GetAll().FirstOrDefault(c => c.Ma == hd.MaBan);
                        ban.TrangThai = 1;
                        _banService.update(ban);
                    }
                    _hoaDonService.delete(hd);
                    MessageBox.Show("Xoá thành công");
                    loadHdCt();
                    loadHoaDon();
                    return;
                };
                
                var hdct = _hoaDonCTService.GetAll().Where(x => x.MaHD == _mahdctWhenClick && x.MaSP == _maSPWhenClick).FirstOrDefault();
                MessageBox.Show(_hoaDonCTService.delete(hdct));

                loadHdCt();
                loadHoaDon();
            }
        }
    }
}
