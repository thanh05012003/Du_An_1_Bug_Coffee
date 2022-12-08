using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;


namespace _3.PL.Views.BanHang
{
    public partial class FrmThanhToan : Form
    {
        private IKhachHangService _KhachHangService;
        private IHoaDonCTService _HoaDonCTService;
        private IHoaDonService _HoaDonService;
        private decimal tongtien = 0;
        private decimal tienHang = 0;
        private decimal giamGia;
        private string _maVoucher;
        private QlKhachHangView _QlKhachHangView;
        private IBanService _BanService;
        private IVoucherService _voucherService;

        public FrmThanhToan()
        {
            InitializeComponent();
            _KhachHangService = new KhachHangService();
            _HoaDonCTService = new HoaDonCTService();
            _HoaDonService = new HoaDonService();
            _QlKhachHangView = new QlKhachHangView();
            _BanService = new BanService();
            _voucherService = new VoucherService();
            LoadThanhToan();
            loadVoucher();
        }


        public void loadVoucher()
        {
            foreach (var x in _voucherService.GetAll())
            {
                cmb_Voucher.Items.Add(x.Ten);
            }
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            frm.ShowDialog();
        }

        public void LoadThanhToan()
        {
            foreach (var x in _HoaDonCTService.GetAll().Where(c => c.MaHD == Properties.Settings.Default.MaHd))
            {
                tongtien += (x.DonGia * x.SoLuong);
                tienHang += (x.DonGia * x.SoLuong);
            }

            lb_TongTien.Text = tongtien.ToString("C0");
        }


        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thanh toán không ?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                var hd = _HoaDonService.GetAll().FirstOrDefault(c =>
                    c.MaBan == Properties.Settings.Default.MaBan && c.Ma == Properties.Settings.Default.MaHd ||
                    c.Ma == Properties.Settings.Default.MaHd);
                var ban = _BanService.GetAll().FirstOrDefault(c => c.Ma == Properties.Settings.Default.MaBan);
                if (ban != null)
                {
                    ban.TrangThai = 1;
                    _BanService.update(ban);
                }

                if (hd != null)
                {
                    if (hd.TrangThai == "Chờ pha chế")
                    {
                        hd.MaKH = _QlKhachHangView.Ma;
                        hd.MaVC = _maVoucher;
                        hd.TrangThai = "Đã thanh toán";
                        hd.GhiChu = "Chờ pha chế";
                        _HoaDonService.update(hd);
                        MessageBox.Show("Thanh toán thành công");
                        this.Close();
                    }
                    else
                    {
                        hd.MaKH = _QlKhachHangView.Ma;
                        hd.TrangThai = "Đã thanh toán";
                        hd.MaVC = _maVoucher;
                        _HoaDonService.update(hd);
                        MessageBox.Show("Thanh toán thành công");
                        Properties.Settings.Default.MaBan = "";
                        this.Close();
                    }
                }
            }
        }

        private void btn_SearchKH_Click(object sender, EventArgs e)
        {
            _QlKhachHangView = _KhachHangService.GetAll().FirstOrDefault(c => c.SDT == txt_SDT.Texts.Trim());
            if (txt_SDT.Texts.Trim() != "")
            {
                if (_QlKhachHangView != null)
                {
                    txt_TenKhachHang.Texts = _QlKhachHangView.Ten;
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


        private void txt_TienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void cbx_DoiDiem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_DoiDiem.Checked)
            {
                txt_DiemTl.Texts = _QlKhachHangView.DiemTL.ToString();
                giamGia = _QlKhachHangView.DiemTL;
                lb_GiamGia.Text = giamGia.ToString("C0");
            }
            else
            {
                txt_DiemTl.Texts = "";
                lb_TongTien.Text = tongtien.ToString("C0");
                lb_GiamGia.Text = "";
            }
        }

        public void getdata()
        {
            if (cbx_DoiDiem.Checked)
            {
                txt_DiemTl.Texts = _QlKhachHangView.DiemTL.ToString();
                giamGia = _QlKhachHangView.DiemTL;
                lb_GiamGia.Text = giamGia.ToString("C0");
            }
            else
            {
                txt_DiemTl.Texts = "";
                lb_TongTien.Text = tongtien.ToString("C0");
                giamGia = 0;
                lb_GiamGia.Text = "";
            }

            try
            {
                var voucher = _voucherService.GetAll().FirstOrDefault(c => c.Ten == cmb_Voucher.Texts);
                if (voucher != null)
                {
                    _maVoucher = voucher.Ma;
                    giamGia += (tongtien / 100 * voucher.GiamGia);
                    lb_GiamGia.Text = giamGia.ToString("C0");
                }

                if (txt_TienKhachDua.Texts.Trim() == "") return;
                var tientralai = (decimal.Parse(txt_TienKhachDua.Texts) - tongtien + giamGia);
                Lb_TienTraLai.Text = tientralai.ToString("C0");
            }
            catch (Exception exception)
            {
                return;
            }

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            getdata();
        }

        public void XuatHoaDon()
        {
            //Bước 1: Nạp file mẫu
            string pa = @"C:\Users\ADMIN\Desktop\Du_An_1_Bug_Coffee\3.PL\Template\HoaDon_TheBugCoffee1.doc";
            Document HoaDon = new Document(pa);
            string tenTep = "";
            foreach (var x in _HoaDonService.GetAll(Properties.Settings.Default.MaHd))
            {
                //Bước 2: Điền các thông tin cố định
                HoaDon.MailMerge.Execute(new[] { "BAN_X" }, new[] { x.TenBan });
                HoaDon.MailMerge.Execute(new[] { "Ngay_Tao" }, new[] { x.NgayTao.Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Ten_Nv" }, new[] { x.TenNV });
                HoaDon.MailMerge.Execute(new[] { "Gio_Ra" }, new[] { DateTime.Now.ToString("hh:mm:ss") });
                HoaDon.MailMerge.Execute(new[] { "Tien_Hang" }, new[] { tienHang.ToString("C0") });
                HoaDon.MailMerge.Execute(new[] { "Giam_Gia" }, new[] { giamGia.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Ten_Kh" }, new[] { txt_TenKhachHang.Texts });
                HoaDon.MailMerge.Execute(new[] { "Ma_hd" }, new[] { x.Ma });

                string path = @"C:\Users\ADMIN\Desktop\HoaDon"; // đường dẫn folder
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path); // tạo folder ( Hoá đơn) mới nếu chưa có
                Random rd = new Random();
                tenTep = $"{path}\\{$"{rd.Next(1000) + x.Ma}.docx"}";

                //Bước 3: Điền thông tin lên bảng
                Table ThongTinSanPham = HoaDon.GetChild(NodeType.Table, 0, true) as Table;//Lấy bảng thứ 1 trong file mẫu
                int HangHienTai = 1;
                ThongTinSanPham.InsertRows(HangHienTai, HangHienTai, 1);
                for (int i = 1; i <= _HoaDonCTService.GetAll(Properties.Settings.Default.MaHd).Count - 1; i++)
                {
                    ThongTinSanPham.PutValue(HangHienTai, 0, (1).ToString());//Cột STT
                    ThongTinSanPham.PutValue(HangHienTai, 1, x.TenSP);//Cột mặt hàng
                    ThongTinSanPham.PutValue(HangHienTai, 2, x.Soluong.ToString());//Cột số lượng
                    ThongTinSanPham.PutValue(HangHienTai, 3, x.DonGia.ToString("C0"));//Cột đơn giá
                    HangHienTai++;
                }
            }
            HoaDon.Save(tenTep);
        }
        private void btn_XuatHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc xuất hoá không ?", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                XuatHoaDon();
                MessageBox.Show("Xuất hoá đơn thành công");
            }
        }

    }
}
