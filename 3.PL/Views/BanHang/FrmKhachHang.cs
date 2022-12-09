using System;
using System;
using System.CodeDom.Compiler;
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

namespace _3.PL.Views.BanHang
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangService _khachHangService;
        private string _maWhenClick;
        public FrmKhachHang()
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            LoadDataKH();
            txt_MaKH.Enabled = false;
        }
        public void LoadDataKH()
        {
            int stt = 1;
            dgrid_TTKhachHang.ColumnCount = 5;
            dgrid_TTKhachHang.Columns[0].Name = "Mã KH";
            dgrid_TTKhachHang.Columns[1].Name = "Tên KH";
            dgrid_TTKhachHang.Columns[2].Name = "SĐT";
            dgrid_TTKhachHang.Columns[3].Name = "Điểm TL";
            dgrid_TTKhachHang.Columns[4].Name = "Địa Chỉ";
            dgrid_TTKhachHang.Rows.Clear();
            foreach (var x in _khachHangService.GetAll())
            {
                dgrid_TTKhachHang.Rows.Add(x.Ma, x.Ten, x.SDT, x.DiemTL, x.DiaChi);
            }
        }

        private QlKhachHangView GetDataFromGui()
        {
            QlKhachHangView kh = new QlKhachHangView();
            return kh = new QlKhachHangView()
            {
                Ma = txt_MaKH.Texts,
                Ten = txt_HoTen.Texts,
                SDT = txt_SDT.Texts,
                DiemTL = int.Parse(txt_DiemTl.Texts),
                DiaChi = txt_DiaChi.Texts
            };
        }


        private void dgrid_TTKhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var rowindex = e.RowIndex;
            if (rowindex ==_khachHangService.GetAll().Count)
            {
                return;
            }
           _maWhenClick = dgrid_TTKhachHang.Rows[rowindex].Cells[0].Value.ToString();
            var rd = _khachHangService.GetAll().FirstOrDefault(c => c.Ma.ToLower() == _maWhenClick.ToLower());
            txt_MaKH.Texts = rd.Ma;
            txt_HoTen.Texts = rd.Ten;
            txt_SDT.Texts = rd.SDT;
            txt_DiemTl.Texts = rd.DiemTL.ToString();
            txt_DiaChi.Texts = rd.DiaChi;
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            var kh = _khachHangService.GetAll().FirstOrDefault(c =>c.SDT == txt_SDT.Texts.Trim());
            DialogResult dialog = MessageBox.Show("Bạn có muốn thêm khách hàng này không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (txt_MaKH.Texts.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống mã");
                }
                else if (txt_HoTen.Texts.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống họ tên");
                }
                else if (txt_SDT.Texts.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống sđt");
                }
                else if (kh !=null)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại");
                }
                else
                {
                    MessageBox.Show(_khachHangService.add(GetDataFromGui()));
                    LoadDataKH();
                }
            }
        }

        private void txt_DiemTl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var temp = GetDataFromGui();
            temp.Ma = _maWhenClick;
            MessageBox.Show(_khachHangService.update(temp));
        }

        private void txt_HoTen__TextChanged(object sender, EventArgs e)
        {
            txt_MaKH.Texts = "KH00" + (_khachHangService.GetAll().Count + 1);
        }
    }
}
