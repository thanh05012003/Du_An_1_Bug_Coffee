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
        string tenTep = "";
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
            foreach (var hd in _HoaDonService.GetAll().Where(c =>c.MaBan == Properties.Settings.Default.MaBan))
            {
                if (hd.TrangThai == "Chờ pha chế" || hd.TrangThai == "Chờ thanh toán")
                {
                    foreach (var x in _HoaDonCTService.GetAll().Where(c => c.MaHD == hd.Ma))
                    {
                        tongtien += (x.DonGia * x.SoLuong);
                        tienHang += (x.DonGia * x.SoLuong);
                    }
                }
               
            }

            lb_TongTien.Text = tongtien.ToString("C0");
        }

        public void thanhToan()
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
                        var kh = _KhachHangService.GetAll().FirstOrDefault(c => c.SDT == txt_SDT.Texts);
                        if (kh != null)
                        {
                            kh.DiemTL = (kh.DiemTL + 1000);
                            _KhachHangService.update(kh);
                        }

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
                        var kh = _KhachHangService.GetAll().FirstOrDefault(c => c.SDT == txt_SDT.Texts);
                        if (kh != null)
                        {
                            kh.DiemTL = (kh.DiemTL + 1000);
                            _KhachHangService.update(kh);
                        }

                        this.Close();
                    }
                }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {  
            DialogResult dr = MessageBox.Show("Bạn có muốn thanh toán không ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DialogResult dlg = MessageBox.Show("Bạn có muốn xuất hoá đơn không ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    XuatHoaDon();
                    thanhToan();
                }
                else
                {
                    thanhToan();
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
            var x = _HoaDonService.GetAll().FirstOrDefault(c =>c.Ma == Properties.Settings.Default.MaHd);
            //Bước 2: Điền các thông tin cố định
            var ban = _BanService.GetAll().FirstOrDefault(c => c.Ma == x.MaBan);
           
            if (ban==null)
            {
                HoaDon.MailMerge.Execute(new[] { "BAN_X" }, new[] { "" });
            }
            else
            {
                HoaDon.MailMerge.Execute(new[] { "BAN_X" }, new[] { ban.Ten });
            }
            HoaDon.MailMerge.Execute(new[] { "Ngay_Tao" }, new[] { x.NgayTao.Value.ToString() });
            HoaDon.MailMerge.Execute(new[] { "Ten_Nv" }, new[] { x.TenNV });
            HoaDon.MailMerge.Execute(new[] { "Gio_Ra" }, new[] { DateTime.Now.ToString("hh:mm:ss") });
            HoaDon.MailMerge.Execute(new[] { "Tien_Hang" }, new[] { tienHang.ToString("C0") });
            HoaDon.MailMerge.Execute(new[] { "Giam_Gia" }, new[] { giamGia.ToString("C0") });
            HoaDon.MailMerge.Execute(new[] { "Ten_Kh" }, new[] { txt_TenKhachHang.Texts });
            HoaDon.MailMerge.Execute(new[] { "Ma_hd" }, new[] { x.Ma });
            HoaDon.MailMerge.Execute(new[] { "Tong_Tien" }, new[] { (tongtien - giamGia).ToString("C0") });
            string path = $@"C:\Users\ADMIN\Desktop\HoaDon"; // đường dẫn folder có tên hoá đơn
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path); // tạo folder ( Hoá đơn) mới nếu chưa có
            Random rd = new Random();
            string filename = $"{rd.Next(1000) + x.Ma}";
           tenTep = $@"{path}\{filename}.docx";
           
            //Bước 3: Điền thông tin lên bảng
            Table ThongTinSanPham =
                HoaDon.GetChild(NodeType.Table, 0, true) as Table; //Lấy bảng thứ 1 trong file mẫu
            int HangHienTai = 1;
            int i = _HoaDonCTService.GetAll().Where(c =>c.MaHD == x.Ma).Count();
            foreach (var c in _HoaDonCTService.GetAll().Where(c =>c.MaHD == x.Ma))
            {
                ThongTinSanPham.InsertRows(HangHienTai, HangHienTai, 1);
                ThongTinSanPham.PutValue(HangHienTai, 0, (i--).ToString()); //Cột STT
                ThongTinSanPham.PutValue(HangHienTai, 1, c.TenSp); //Cột mặt hàng
                ThongTinSanPham.PutValue(HangHienTai, 2, c.SoLuong.ToString()); //Cột số lượng
                ThongTinSanPham.PutValue(HangHienTai, 3, c.DonGia.ToString("C0")); //Cột đơn giá
            }
            HoaDon.Save(tenTep);
            MessageBox.Show("Xuất hoá đơn thành công");
        }

        private void btn_XuatHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có xuất hoá đơn không ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                XuatHoaDon();
            }
        }
    }
}