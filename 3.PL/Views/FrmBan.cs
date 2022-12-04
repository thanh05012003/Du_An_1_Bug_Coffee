using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using CustomControls.RJControls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _3.PL.Views
{
    public partial class FrmBan : Form
    {
        private IBanService _banService;
        IHoaDonCTService _hoaDonCtService;
        public FrmBan()
        {
            InitializeComponent();
            _banService = new BanService();
            _hoaDonCtService = new HoaDonCTService();
            loadTable();
        }

        public void loadTable()
        {
            List <QlBanView> listtable = _banService.GetAll();
            foreach (var x in listtable)
            {
                Button btn = new Button() {Size = new System.Drawing.Size(280, 280), };
                btn.Text = x.Ten + "  " + (x.TrangThai == 1 ? "Còn trống" : "Có người");
                btn.Click += btn_Click;
                btn.Tag = x;
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
            List<QlHoaDonCTView> listBillInfo = _hoaDonCtService.GetAll(ma);
            dgrid_TTSp.Rows.Clear();
            foreach (var item in listBillInfo)
            {
                dgrid_TTSp.ColumnCount = 3;
                dgrid_TTSp.Columns[0].Name = "Ten";
                dgrid_TTSp.Columns[1].Name = "Số lượng";
                dgrid_TTSp.Columns[2].Name = "Đơn giá";
                dgrid_TTSp.Rows.Clear();
                foreach (var x in listBillInfo)
                {
                    dgrid_TTSp.Rows.Add(x.TenSp, x.SoLuong, x.DonGia,0);
                }
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            string MaBan = ((sender as Button).Tag as QlBanView).Ma;
            ShowBill(MaBan);
        }
    }
}
