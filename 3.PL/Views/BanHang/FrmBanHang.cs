using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;

namespace _3.PL.Views.BanHang
{
    public partial class FrmBanHang : Form
    {
        private ISanPhamService _sanPhamService;
        private IHoaDonService _hoaDonService;
        private IBanService _banService;
        private IKhachHangService _khachHangService;
        private INhanVienService _nhanVienService;
        private ILoaiSanPhamService _loaiSanPhamService;
        private IHoaDonCTService _hoaDonCTService;
        private string _maSPWhenClick = "";
        private string _maHDWhenClick = "";
    


        public FrmBanHang()
        {
            InitializeComponent();
            _sanPhamService = new SanPhamService();
            _hoaDonService = new HoaDonService();
            _banService = new BanService();
            _khachHangService = new KhachHangService();
            _nhanVienService = new NhanVienService();
            _loaiSanPhamService = new LoaiSanPhamService();
            _hoaDonCTService = new HoaDonCTService();
            loadSp();
            LoadLoaiSP();
            LoadBan();
            LoadHoTenKH();
            ShowHdCho();
            showBtnHdcho();
            LoadHdChoCT();
        }

        #region Method

        public void LoadHdChoCT()
        {
            dgrid_HdChoCT.ColumnCount = 6;
            dgrid_HdChoCT.Columns[0].Name = "Mã SP";
            dgrid_HdChoCT.Columns[1].Name = "Tên SP";
            dgrid_HdChoCT.Columns[2].Name = "Đơn giá";
            dgrid_HdChoCT.Columns[3].Name = "Số lượng";
            dgrid_HdChoCT.Columns[4].Name = "Thành tiền";
            dgrid_HdChoCT.Columns[5].Name = "Ghi chú";
            dgrid_HdChoCT.Rows.Clear();
            foreach (var x in _hoaDonCTService.GetAll().Where(c =>c.MaHD == _maHDWhenClick))
            {
                foreach (var a in _hoaDonService.GetAll().Where(c =>c.Ma == x.MaHD))
                {
                    if (a.TrangThai.ToLower() == "chờ order")
                    {
                        dgrid_HdChoCT.Rows.Add(x.MaSP, x.TenSp, x.DonGia, x.SoLuong, (x.SoLuong * x.DonGia));
                    }
                }
                
            }
        }
        public QlHoaDonCTView GetDataHdCtfromGui()
        {
            QlHoaDonCTView HoaDonCt = new QlHoaDonCTView();
            HoaDonCt = new QlHoaDonCTView()
            {
                MaHD = _maHDWhenClick,
                MaSP = _maSPWhenClick,
                SoLuong = int.Parse(nud_SoLuong.Text),
                DonGia = decimal.Parse(txt_DonGiaSP.Text),
            };
            return HoaDonCt;
        }
        public QlHoaDonView HoaDonCho()
        {
            QlHoaDonView lstHdView = new QlHoaDonView();
            var NV = _nhanVienService.GetAll().FirstOrDefault(c => c.SDT == Properties.Settings.Default.Tk);
            var table = _banService.GetAll().FirstOrDefault(c => c.Ten == cbb_Ban.Text);
            if (NV != null)
            {
                lstHdView = new QlHoaDonView()
                {
                    Ma = "HD00" + (_hoaDonService.GetAll().Count + 1),
                    MaNV = NV.Ma,
                    TrangThai = "Chờ order",
                    NgayTao = DateTime.Now,
                    MaBan = table.Ma,
                };
            }

            return lstHdView;
        }
        public void LoadBan()
        {
            cbb_Ban.Items.Clear();
            foreach (var x in _banService.GetAll())
            {
                cbb_Ban.Items.Add(x.Ten);
            }
            cbb_Ban.SelectedIndex = 0;
        }

        public void LoadHoTenKH()
        {
            cbb_TenKH.Items.Clear();
            foreach (var x in _khachHangService.GetAll())
            {
                cbb_TenKH.Items.Add(x.Ten);
            }
        }

        public void LoadLoaiSP()
        {
            cbb_loaiSP.Items.Clear();
            foreach (var x in _loaiSanPhamService.GetAll())
            {
                cbb_loaiSP.Items.Add(x.Ten);
            }
        }

        public void loadSp() //load thông tin sản phẩm
        {
            List<QlSanPhamView> lstsp = _sanPhamService.GetAll();
            foreach (var x in lstsp)
            {
                Panel products = new Panel()
                {
                    Size = new System.Drawing.Size(142, 187),
                    BackColor = Color.DarkOliveGreen
                };
                Panel icon = new Panel()
                {
                    Dock = DockStyle.Top,
                    BackgroundImage = Image.FromFile(x.URL),
                    BackgroundImageLayout = ImageLayout.Zoom,
                };
                icon.Tag = x;
                icon.Click += btn_Click_1;
                products.Controls.Add(icon);
                Label lb = new Label()
                {
                    Padding = new Padding(8, 8, 0, 0),
                    Size = new Size(139, 52),
                    Font = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    ForeColor = Color.Black,
                    Location = new Point(3, 105),
                    Text = x.Ten
                };
                products.Controls.Add(lb);
                Label lb_Cost = new Label()
                {
                    Font = new Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold,
                        System.Drawing.GraphicsUnit.Point),
                    ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
                    Location = new Point(17, 157),
                    Size = new Size(107, 23),
                    Text = Math.Round(x.Gia, 0).ToString("C0"),
                };
                products.Controls.Add(lb_Cost);
                products.Tag = x;
                products.Click += btn_Click_1;
                flowLayoutPanel1.Controls.Add(products);
            }
        }
        public void ShowBill(string ma)
        {
            var sp = _sanPhamService.GetAll().FirstOrDefault(c =>c.Ma == ma);
            txt_TenSP.Text = sp.Ten;
            txt_DonGiaSP.Text = Math.Round(sp.Gia, 0).ToString();
        }


        public void showBtnHdcho()
        {
            flp_HoaDon.Controls.Clear();
            foreach (var x in _hoaDonService.GetAll())
            {
                if (x.TrangThai == "Chờ order")
                {
                    Button btn = new Button()
                    {
                        Text = x.Ma,
                        Height = 35
                    };
                    btn.Tag = x;
                    btn.Click += btn_Click_Hd;
                    flp_HoaDon.Controls.Add(btn);
                }
            }
        }
        public void ShowHdCho()
        {
            dtg_hdCho.ColumnCount = 5;
            dtg_hdCho.Columns[0].Name = "Mã HD";
            dtg_hdCho.Columns[1].Name = "Tên NV";
            dtg_hdCho.Columns[2].Name = "Ngày tạo";
            dtg_hdCho.Columns[3].Name = "Trạng thái";
            dtg_hdCho.Columns[4].Name = "Ghi chú";
            dtg_hdCho.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll())
            {
                if (x.TrangThai == "Chờ order")
                {
                    dtg_hdCho.Rows.Add(x.Ma, x.TenNV, x.NgayTao, x.TrangThai, x.GhiChu);
                }
            }
        }

        #endregion

        #region Event
        //lấy ra mã sản phẩm khi click vào ảnh
        void btn_Click_1(object sender, EventArgs e)
        {
            _maSPWhenClick = ((sender as Panel).Tag as QlSanPhamView).Ma;
            ShowBill(_maSPWhenClick);
        }
        public void btn_Click_Hd(object sender, EventArgs e)
        {
            _maHDWhenClick = ((sender as Button).Tag as QlHoaDonView).Ma;
            LoadHdChoCT();
        }
        private void btn_GiaoHang_Click(object sender, EventArgs e)
        {
            FrmGiaoHang frm = new FrmGiaoHang();
            frm.ShowDialog();
        }
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            frm.ShowDialog();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var nv = _khachHangService.GetAll().FirstOrDefault(c =>c.SDT == txt_SDT.Text.Trim());
            if (nv!=null)
            {
                cbb_TenKH.Text = nv.Ten;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng này");
            }
        }

        private void btn_ThemHD_Click_1(object sender, EventArgs e)
        {
            if (cbb_Ban.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn");
            }
            else
            {
                var temp = HoaDonCho();
                _maHDWhenClick = temp.Ma;
                MessageBox.Show(_hoaDonService.add(temp));
                showBtnHdcho();
                ShowHdCho();
            }
           
        }
        #endregion

        private void btn_ThemSp_Click(object sender, EventArgs e)
        {
            var sp = _hoaDonCTService.GetAll().FirstOrDefault(c => c.MaSP == _maSPWhenClick && c.MaHD == _maHDWhenClick);
            if (_maHDWhenClick.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn hoá đơn");
            }
            else
            {
                if (sp != null) // nếu click thêm 1 sản phẩm đã tồn tại trong hoá đơn thì sẽ cập nhật lại số lượng
                {
                    var htct = _hoaDonCTService.GetAll().FirstOrDefault(c => c.MaHD == _maHDWhenClick);
                    var temp = GetDataHdCtfromGui();
                    temp.SoLuong = int.Parse(nud_SoLuong.Text) + htct.SoLuong;
                    MessageBox.Show(_hoaDonCTService.update(temp));
                    LoadHdChoCT();
                }
                else
                {
                    MessageBox.Show(_hoaDonCTService.add(GetDataHdCtfromGui()));
                    LoadHdChoCT();
                }
            }
            
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            var temp = HoaDonCho();
            temp.Ma = _maHDWhenClick;
            temp.TrangThai = "đã order";
            MessageBox.Show(_hoaDonService.update(temp));
            ShowHdCho();
            LoadHdChoCT();
            showBtnHdcho();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            LoadHdChoCT();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
