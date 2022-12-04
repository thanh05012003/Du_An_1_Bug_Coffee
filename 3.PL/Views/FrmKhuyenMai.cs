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
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FrmKhuyenMai : Form
    {
        private IVoucherService _voucherService;
        private string _maWhenClick;
        public FrmKhuyenMai()
        {
            _voucherService = new VoucherService();
            InitializeComponent();
            loadDataKM();
            rb_hoatDong.Checked = true;

        }
        public void loadDataKM()
        {
            int stt = 1;
            dtg_showKM.ColumnCount = 8;
            dtg_showKM.Columns[0].Name = "STT";
            dtg_showKM.Columns[1].Name = "Mã KM";
            dtg_showKM.Columns[2].Name = "Tên KM";
            dtg_showKM.Columns[3].Name = "Ngày bắt đầu";
            dtg_showKM.Columns[4].Name = "Ngày kết thúc";
            dtg_showKM.Columns[5].Name = "Trạng thái";
            dtg_showKM.Columns[6].Name = "Giảm giá";
            dtg_showKM.Columns[7].Name = "Mô tả";
            dtg_showKM.Rows.Clear();

            foreach (var x in _voucherService.GetAll())
            {
                dtg_showKM.Rows.Add(stt++, x.Ma, x.Ten, x.NgayBatDau, x.NgayKetThuc,
                    (x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"), x.GiamGia, x.MoTa);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            QlVoucherView vc = new QlVoucherView();
            if (tbt_MaKM.Text.Trim() == "" || tbt_TenKM.Text.Trim() == "" || date_ngayKT.Value < date_ngayBD.Value || tbt_sale.Text.Trim() == "" || tbt_moTa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
            else
            {
                vc = new QlVoucherView()
                {
                    Ma = tbt_MaKM.Text,
                    Ten = tbt_TenKM.Text,
                    NgayBatDau = date_ngayBD.Value,
                    NgayKetThuc = date_ngayKT.Value,
                    TrangThai = rb_hoatDong.Checked ? 1 : 0,
                    GiamGia = int.Parse(tbt_sale.Text),
                    MoTa = tbt_moTa.Text
                };
                _voucherService.add(vc);
            }
            loadDataKM();
        }

        private void dtg_showKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _voucherService.GetAll().Count)
            {
                return; 
            }
            _maWhenClick = dtg_showKM.Rows[rowIndex].Cells[1].Value.ToString();
            var vc = _voucherService.GetAll().FirstOrDefault(c => c.Ma == _maWhenClick);
            if (vc != null)
            {
                tbt_MaKM.Text = vc.Ma;
                tbt_TenKM.Text = vc.Ten;
                tbt_moTa.Text = vc.MoTa;
                tbt_sale.Text = vc.GiamGia.ToString();
                date_ngayBD.Value = vc.NgayBatDau.Value;
                date_ngayKT.Value = vc.NgayKetThuc.Value;
                if (vc.TrangThai == 1)
                {
                    rb_hoatDong.Checked = true; 
                }
                else
                {
                    rb_khongHD.Checked = true;
                }
            }
        }
    }
}
