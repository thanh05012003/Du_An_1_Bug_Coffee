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
        public FrmBan()
        {
            InitializeComponent();
            _banService = new BanService();
            _hoaDonCtService = new HoaDonCTService();
            _hoaDonService = new HoaDonService();
            loadTable();
        }

        public void loadTable()
        {
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
            foreach (var x in _hoaDonService.GetAll(ma).Where(c =>c.MaBan == ma))
            {
                dgrid_TTSp.Rows.Add(x.TenSP,x.Soluong,Math.Round(x.DonGia,0));
            }
        }

        public void btn_Click(object sender, EventArgs e)
        {
            string MaBan = ((sender as CSButton).Tag as QlBanView).Ma;
            ShowBill(MaBan);
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan frm = new FrmThanhToan();
            frm.ShowDialog();
        }
    }
}
