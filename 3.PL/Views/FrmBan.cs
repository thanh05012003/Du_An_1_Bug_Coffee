using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        private IHoaDonService _hoaDonService;
        private string _maBanChuyen;

        public FrmBan()
        {
            InitializeComponent();
            _banService = new BanService();
            _hoaDonCtService = new HoaDonCTService();
            _hoaDonService = new HoaDonService();
            loadTable();
            loadBan();
        }

        public void loadBan()
        {
            cmb_Ban.Items.Clear();
            foreach (var x in _banService.GetAll())
            {
                cmb_Ban.Items.Add(x.Ten);
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
                    BorderRadius = 50,
                    ForeColor = Color.Black
                };
                btn.Text = x.Ten + "  " + (x.TrangThai == 1 ? "Còn trống" : "Có người");
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
                if (x.TrangThai == "Chờ pha chế" || x.TrangThai == "Chờ thanh toán");
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
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển");
            }
        }
    }
}
