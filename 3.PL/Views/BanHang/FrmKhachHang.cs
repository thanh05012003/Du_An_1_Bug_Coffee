using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.BanHang
{
    public partial class FrmKhachHang : Form
    {
        private IKhachHangService _KhachHangService;
        private string _maWhenClick;
        public FrmKhachHang()
        {
            InitializeComponent();
            _KhachHangService = new KhachHangService();
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
            foreach (var x in _KhachHangService.GetAll())
            {
                dgrid_TTKhachHang.Rows.Add(x.Ma, x.Ten, x.SDT, x.DiemTL/*,x.DiaChi*/);
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
                //DiaChi = txt_DiaChi.Texts
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
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
                else if (txt_DiemTl.Texts.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống điểm tích lũy");
                }
                else
                {
                    MessageBox.Show(_KhachHangService.add(GetDataFromGui()));
                    LoadDataKH();
                }
            }
        }

        private void dgrid_TTKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _KhachHangService.GetAll().Count)
            {
                return;
            }
            _maWhenClick = dgrid_TTKhachHang.Rows[rowIndex].Cells[1].Value.ToString();
            var KhachHangView = _KhachHangService.GetAll().FirstOrDefault(c => c.Ma == _maWhenClick);
            txt_MaKH.Texts = KhachHangView.Ma;
            txt_HoTen.Texts = KhachHangView.Ten;
            txt_SDT.Texts = KhachHangView.SDT;
            txt_DiemTl.Texts = KhachHangView.DiemTL.ToString();
            //txt_DiaChi.Text = KhachHangView.DiaChi;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
