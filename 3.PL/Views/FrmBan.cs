using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Views.BanHang;
using CustomControls.RJControls;

namespace _3.PL.Views
{
    public partial class FrmBan : Form
    {
        private IBanService _banService;
        private IHoaDonCTService _hoaDonCtService;
        private INhanVienService _nhanVienService;
        private IHoaDonService _hoaDonService;
        private string _maBanChuyen;
        private string _maHdWhenClick;
        private ISanPhamService _sanPhamService;
        private ILoaiSanPhamService _loaiSanPhamService;

        public FrmBan()
        {
            InitializeComponent();
            _banService = new BanService();
            _hoaDonCtService = new HoaDonCTService();
            _hoaDonService = new HoaDonService();
            _sanPhamService = new SanPhamService();
            _loaiSanPhamService = new LoaiSanPhamService();
            _nhanVienService = new NhanVienService();
            loadTable();
            loadChuyenBan();
            LoadGopBan();
            loadSP(null);
            loadLoaiSanPham();
        }

        public void loadLoaiSanPham()
        {
            cmb_LoaiSanPham.Items.Clear();
            foreach (var x in _loaiSanPhamService.GetAll())
            {
                cmb_LoaiSanPham.Items.Add(x.Ten);
            }
        }
        public void loadSP(string ma)
        {
            cmb_SanPham.Items.Clear();
            foreach (var x in _sanPhamService.TimKiem(ma))
            {
               cmb_SanPham.Items.Add(x.Ten);
            }
        }
        public void loadChuyenBan()
        {
            cmb_Ban.Items.Clear();
            foreach (var x in _banService.GetAll().Where(c =>c.TrangThai == 1))
            {
                cmb_Ban.Items.Add(x.Ten);
            }
        }

        public void LoadGopBan()
        {
            cmb_GopBan.Items.Clear();
            foreach (var x in _banService.GetAll().Where(c => c.TrangThai == 0))
            {
                cmb_GopBan.Items.Add(x.Ten);
            }
        }

        public void loadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List <QlBanView> listtable = _banService.GetAll();
            foreach (var x in listtable)
            {
                CSButton btn = new CSButton()
                {
                    Size = new System.Drawing.Size(243, 243),
                    BorderRadius = 120,
                    ForeColor = Color.Black
                };
                btn.Text = x.Ten/* + "  " + (x.TrangThai == 1 ? "Còn trống" : "Có người")*/;
                btn.Tag = x;
                btn.Click += btn_Click;
                switch (x.TrangThai)
                {
                    case 1:
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.OrangeRed;
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        void ShowBill(string ma)
        {
            dgrid_TTSp.Rows.Clear();
            dgrid_TTSp.ColumnCount = 3;
            dgrid_TTSp.Columns[0].Name = "Tên";
            dgrid_TTSp.Columns[1].Name = "Số lượng";
            dgrid_TTSp.Columns[2].Name = "Đơn giá";
            dgrid_TTSp.Rows.Clear();
            foreach (var x in _hoaDonService.GetAll(ma))
            {
                if (x.TrangThai == "Chờ pha chế" || x.TrangThai == "Chờ thanh toán")
                {
                    dgrid_TTSp.Rows.Add(x.TenSP, x.Soluong, Math.Round(x.DonGia, 0));
                    Properties.Settings.Default.MaHd = x.Ma;
                    Properties.Settings.Default.MaBan = x.MaBan;
                }
                if (x.TrangThai == "Đã thanh toán")
                {
                    dgrid_TTSp.Rows.Clear();
                }
            }
        }

        public void btn_Click(object sender, EventArgs e)
        {
             var _maBanWhenClick = ((sender as CSButton).Tag as QlBanView).Ma;
            //Properties.Settings.Default.MaBan = _maBanWhenClick;
            Properties.Settings.Default.MaBan = _maBanWhenClick;
            _maBanChuyen = _maBanWhenClick;
            ShowBill(_maBanWhenClick);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan frm = new FrmThanhToan();
            frm.ShowDialog();
        }

        private void btn_ChuyenBan_Click(object sender, EventArgs e)
        {
            var maban = _banService.GetAll().FirstOrDefault(c => c.Ten == cmb_Ban.Text);
            var banchuyen = _banService.GetAll().FirstOrDefault(c => c.Ma == _maBanChuyen);
            if (banchuyen == null) { MessageBox.Show("Vui lòng chọn bàn muốn chuyển"); return; }
            if (cmb_Ban.Text.Trim() != "")
            {
                if (maban.Ma == banchuyen.Ma)
                {
                    MessageBox.Show("Bạn đang ở bàn này");
                    return;
                }
                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc muốn chuyển từ {banchuyen.Ten} qua {maban.Ten} không ?",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    foreach (var c in _hoaDonService.GetAll().Where(c => c.MaBan == _maBanChuyen))
                    {
                        if (c.TrangThai == "Chờ pha chế" || c.TrangThai == "Chờ thanh toán")
                        {
                            c.MaBan = maban.Ma;
                            _hoaDonService.update(c);
                            maban.TrangThai = 0;
                            _banService.update(maban);
                            banchuyen.TrangThai = 1;
                            _banService.update(banchuyen);
                        }
                    }

                    MessageBox.Show("Chuyển bàn thành công");
                }
                loadTable();
                loadChuyenBan();
                _maBanChuyen = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển");
            }
        }

        private void btn_TachHd_Click(object sender, EventArgs e)
        {
            if (_maBanChuyen == null)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn tách");
                return;
            }
            var Ban = _banService.GetAll().FirstOrDefault(c => c.Ma == _maBanChuyen);
            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn tách hoá đơn {Ban.Ten.ToUpper()} không ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                FrmTachHD frm = new FrmTachHD();
                frm.ShowDialog();
            }
        }

        private void btn_GopBan_Click(object sender, EventArgs e)
        {
            if (cmb_GopBan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn bàn muốn gộp");
                return;
            }

            var BanGop = _banService.GetAll().FirstOrDefault(c => c.Ten == cmb_GopBan.Text);
            var banchuyen = _banService.GetAll().FirstOrDefault(c => c.Ma == _maBanChuyen);
            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc muốn gộp {banchuyen.Ten} với {BanGop.Ten} không ?",
                "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                foreach (var c in _hoaDonService.GetAll().Where(c => c.MaBan == _maBanChuyen))
                {
                    if (c.TrangThai == "Chờ pha chế" || c.TrangThai == "Chờ thanh toán")
                    {
                        c.MaBan = BanGop.Ma;
                        _hoaDonService.update(c);
                        BanGop.TrangThai = 0;
                        _banService.update(BanGop);
                        banchuyen.TrangThai = 1;
                        _banService.update(banchuyen);
                    }
                }

                MessageBox.Show("Chuyển bàn thành công");
            }
        }

        public QlHoaDonCTView getDataSPfromGui()
        {
            //sản phẩm khi chọn trên cmb
            var sp = _sanPhamService.GetAll().FirstOrDefault(c => c.Ten == cmb_SanPham.Texts);
            QlHoaDonCTView lstHdCt;
            lstHdCt = new QlHoaDonCTView()
            {
                MaHD = _maHdWhenClick,
                MaSP = sp.Ma,
                DonGia = sp.Gia,
                SoLuong = int.Parse(nud_SoLuong.Text),
                TrangThai = ""
            };
            return lstHdCt;
        }
        public QlHoaDonView HoaDonCho()
        {
            QlHoaDonView lstHdView = new QlHoaDonView();
            var NV = _nhanVienService.GetAll().FirstOrDefault(c => c.SDT == Properties.Settings.Default.Tk);
            if (NV != null)
            {
                Random rd = new Random();
                lstHdView = new QlHoaDonView()
                {
                    Ma = "HD" + ((_hoaDonService.GetAll().Count + rd.Next(1000000))),
                    MaNV = NV.Ma,
                    TrangThai = "Chờ pha chế",
                    NgayTao = DateTime.Now,
                };
            }

            return lstHdView;
        }
        private void btn_ThemMon_Click_1(object sender, EventArgs e)
        {
            if (cmb_SanPham.Texts.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
                return;
            }
            var nv = _nhanVienService.GetAll().FirstOrDefault(c => c.SDT == Properties.Settings.Default.Tk);
            if (nv.MaCV == "CV02"|| nv == null)
            {
                MessageBox.Show("Bạn không có quyền thêm sản phẩm");
                return;
            }
            
            var ban = _banService.GetAll().FirstOrDefault(c =>c.Ma == _maBanChuyen);
            if (ban.TrangThai == 0) // nếu bàn có người
            {
                foreach (var c in _hoaDonService.GetAll().Where(c => c.MaBan == _maBanChuyen))
                {
                    //var c = _hoaDonService.GetAll().FirstOrDefault(c => c.MaBan == _maBanChuyen);
                    if (c.TrangThai == "Chờ pha chế" || c.TrangThai == "Chờ thanh toán")
                    {
                        DialogResult dlg = MessageBox.Show($"Bạn có muốn thêm sản phẩm vào {ban.Ten} không?",
                            "xác nhận", MessageBoxButtons.OKCancel);
                        if (dlg == DialogResult.OK)
                        {
                            var tempsp = getDataSPfromGui();
                            var hd = _hoaDonService.GetAll().FirstOrDefault(a => a.Ma == c.Ma);
                            var hdct = _hoaDonCtService.GetAll()
                                .FirstOrDefault(x => x.MaHD == c.Ma && x.MaSP == tempsp.MaSP);
                            if (hdct != null) // cập nhật lại số lượng nếu đã tồn tại
                            {
                                tempsp.MaHD = c.Ma;
                                tempsp.MaSP = hdct.MaSP;
                                tempsp.SoLuong = hdct.SoLuong + int.Parse(nud_SoLuong.Text);
                                tempsp.TrangThai = $"Thêm {nud_SoLuong.Text}";
                                MessageBox.Show(_hoaDonCtService.update(tempsp));
                                //cập nhật lại trạng thái hoá đơn để pha chế làm
                                hd.TrangThai = "Chờ pha chế";
                                _hoaDonService.update(hd);
                                ShowBill(c.MaBan);
                            }
                            else // thêm sản phẩm vào hoá đơn ( thêm vào bàn có người )
                            {
                                tempsp.TrangThai = "";
                                tempsp.MaHD = c.Ma;
                                _hoaDonCtService.add(tempsp);
                                hd.TrangThai = "Chờ pha chế";
                                _hoaDonService.update(hd);
                                ShowBill(c.Ma);
                            }
                        }
                    }
                }
            }else
            {
                var temp = HoaDonCho();             //
                _maHdWhenClick = temp.Ma;                      //
                temp.MaBan = ban.Ma;
                temp.TrangThai = "Chờ pha chế";                // tạo hoá đơn khi ấn thêm món ( nếu bàn còn trống )
                _hoaDonService.add(temp);                      //

                var tempsp = getDataSPfromGui();  // thêm sản phẩm sau khi tạo hoá đơn
                tempsp.TrangThai = "";
                _hoaDonCtService.add(tempsp);                  //

                ban.TrangThai = 0;                               //
                _banService.update(ban);                         // update lại trạng thái bàn khi sau thêm hoá đơn
                MessageBox.Show("Thêm sản phẩm thành công");

                loadTable();                                     // load lại trạng thái bàn sau khi thêm hoá đơn
                ShowBill(ban.Ma);
            }
        }
        
        private void cmb_LoaiSanPham_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            var lsp = _loaiSanPhamService.GetAll().FirstOrDefault(c => c.Ten == cmb_LoaiSanPham.Texts);
            loadSP(lsp.Ma);
        }
    }
}
