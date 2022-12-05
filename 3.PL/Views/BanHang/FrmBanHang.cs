using System;
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
        private string _maSPWhenClick;
        private string _maHDWhenClick;
        private int i = 0;


        public FrmBanHang()
        {
            InitializeComponent();
            _sanPhamService = new SanPhamService();
            _hoaDonService = new HoaDonService();
            _banService = new BanService();
            _khachHangService = new KhachHangService();
            _nhanVienService = new NhanVienService();
            _loaiSanPhamService = new LoaiSanPhamService();
            loadSp();
            LoadLoaiSP();
            LoadBan();
            LoadHoTenKH();
            ShowHdCho();
            showBtnHdcho();
        }

        #region Method
        public QlHoaDonView HoaDonCho()
        {
            QlHoaDonView lstHdView = new QlHoaDonView();
            var NV = _nhanVienService.GetAll().FirstOrDefault(c => c.SDT == Properties.Settings.Default.Tk);
            if (NV != null)
            {
                lstHdView = new QlHoaDonView()
                {
                    Ma = "HD00" + (_hoaDonService.GetAll().Count + 1),
                    MaNV = NV.Ma,
                    TrangThai = "Chờ order",
                    NgayTao = DateTime.Now,
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
                    Text = Math.Round(x.Gia, 0).ToString(),
                };
                products.Controls.Add(lb_Cost);
                products.Tag = x;
                products.Click += btn_Click_1;
                flowLayoutPanel1.Controls.Add(products);
            }
        }
        //public void ShowBill(string ma)
        //{
        //    List<QlSanPhamView> listBillInfo = _sanPhamService.GetAll(ma);
        //    dgrid_HoaDon.Rows.Clear();
        //    foreach (var item in listBillInfo)
        //    {
        //        dgrid_HoaDon.ColumnCount = 6;
        //        dgrid_HoaDon.Columns[0].Name = "Mã Sản phẩm";
        //        dgrid_HoaDon.Columns[1].Name = "Tên sản phẩm";
        //        dgrid_HoaDon.Columns[2].Name = "Đơn giá";
        //        dgrid_HoaDon.Columns[3].Name = "Số lượng";
        //        dgrid_HoaDon.Columns[4].Name = "Thành tiền";
        //        dgrid_HoaDon.Columns[5].Name = "Ghi chú";
        //        dgrid_HoaDon.Rows.Clear();
        //        foreach (var x in listBillInfo)
        //        {
        //            dgrid_HoaDon.Rows.Add(x.Ma, x.Ten, Math.Round(x.Gia, 0));
        //        }
        //    }
        //}
        private Panel pane;
        public void ShowBill(string ma)
        {
            foreach (var x in _sanPhamService.GetAll(ma))
            {
                pane = new Panel()
                {
                    Dock = DockStyle.Top,
                    Location = new Point(3, 3),
                    Size = new Size(666, 46),
                    Name = "pane_Hdct"
                };
                Label lb = new Label()
                {
                    AutoSize = true,
                    Text = x.Ma,
                    Location = new Point(11, 9),
                    Size = new Size(50, 20),
                };
                pane.Controls.Add(lb);
                Label lb2 = new Label()
                {
                    //AutoSize = true,
                    Text = x.Ten,
                    Location = new Point(67, 9),
                    Size = new Size(123, 26),

                };
                pane.Controls.Add(lb2);
                Label lb3 = new Label()
                {
                    AutoSize = true,
                    Text = Math.Round(x.Gia, 0).ToString("C0"),
                    Location = new Point(193, 9),
                    Size = new Size(50, 20),
                };
                pane.Controls.Add(lb3);
                NumericUpDown nb = new NumericUpDown()
                {
                    Location = new Point(271, 6),
                    Size = new Size(86, 27),
                    Text = "1",
                };
                pane.Controls.Add(nb);
                Label lb4 = new Label()
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(376, 9),
                    Size = new System.Drawing.Size(50, 20),
                    Text = (int.Parse(nb.Text) * x.Gia).ToString("C0"),
                };
                pane.Controls.Add(lb4);
                TextBox tb = new TextBox()
                {
                    Location = new System.Drawing.Point(471, 6),
                    Size = new System.Drawing.Size(88, 27),
                };
                pane.Controls.Add(tb);
                Button btn = new Button()
                {
                    Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    Location = new System.Drawing.Point(584, 5),
                    Size = new System.Drawing.Size(76, 29),
                    Text = "X",
                };
                pane.Controls.Add(btn);
                pane.Tag = x;
                btn.Tag = x;
                btn.Click += Btn_Click;
                flp_HdChoCt.Tag = x;
                //flp_HdChoCt.Click += btn_Click_1;
                flp_HdChoCt.Controls.Add(pane);
            }
        }


        private void Btn_Click(object? sender, EventArgs e)
        {
            //_maSPWhenClick = ((sender as Button).Tag as QlSanPhamView).Ma;
            //flp_HdChoCt.Controls.Remove(pane);
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
            i += 1;
            _maSPWhenClick = ((sender as Panel).Tag as QlSanPhamView).Ma;
            ShowBill(_maSPWhenClick);
        }
        public void btn_Click_Hd(object sender, EventArgs e)
        {
            _maHDWhenClick = ((sender as Button).Tag as QlHoaDonView).Ma;
        }
        private void btn_GiaoHang_Click(object sender, EventArgs e)
        {
            FrmGiaoHang frm = new FrmGiaoHang();
            frm.ShowDialog();
        }
        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_hoaDonService.add(HoaDonCho()));
            ShowHdCho();
            showBtnHdcho();
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

        #endregion

    }
}
