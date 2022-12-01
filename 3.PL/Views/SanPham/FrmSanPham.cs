using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Views.SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class FrmSanPham : Form
    {
        private ISanPhamService _iSanPhamServices;
        private ILoaiSanPhamService _iloaiSanPhamServices;
        private string _maWhenClick;
        private QlSanPhamView _qlSanPhamView;
        public FrmSanPham()
        {
            InitializeComponent();
            _iSanPhamServices = new SanPhamService();
            _iloaiSanPhamServices = new LoaiSanPhamService();
            LoadDataSP();
            LoadDataLSP();
            LoadDataLoaiSP();
            LoadDataTrangThai();
            rdb_DangBan.Checked = true;
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

        }

        public void LoadDataLSP()
        {
            foreach (var x in _iloaiSanPhamServices.GetAll())
            {
                cbx_MaLoaiSP.Items.Add(x.Ma+ "-" + x.Ten);
            }
        }

        public void LoadDataLoaiSP()
        {
            foreach (var x in _iloaiSanPhamServices.GetAll())
            {
                cbx_Lsp.Items.Add(x.Ten);
            }
        }

        public void LoadDataTrangThai()
        {
            foreach (var x in _iSanPhamServices.GetAll())
            {
                cbx_TrangThai.Items.Add(x.TrangThai);
            }
        }

        private void LoadDataSP()
        {
            int stt = 1;
            dgrid_QLSanPham.ColumnCount = 7;
            dgrid_QLSanPham.Columns[0].Name = "STT";
            dgrid_QLSanPham.Columns[1].Name = "Mã Sản Phẩm";
            dgrid_QLSanPham.Columns[2].Name = "Tên Sản Phẩm";
            dgrid_QLSanPham.Columns[3].Name = "Giá bán";
            dgrid_QLSanPham.Columns[4].Name = "Mô Tả";
            dgrid_QLSanPham.Columns[5].Name = "Mã Loại Sản Phẩm";
            dgrid_QLSanPham.Columns[6].Name = "Trạng Thái";
            dgrid_QLSanPham.Rows.Clear();
            foreach (var x in _iSanPhamServices.GetAll())
            {
                dgrid_QLSanPham.Rows.Add(stt++, x.Ma, x.Ten, x.Gia, x.MoTa, x.MaLsp, x.TrangThai == 1 ? "Đang Bán" : "Ngưng Bán",x.TenLoaiSp);
            }
        }

        private QlSanPhamView GetDatafromGui()
        {
            QlSanPhamView sp = new QlSanPhamView();
            var lsp = _iloaiSanPhamServices.GetAll().FirstOrDefault(c => c.Ma.ToLower() + "-" + c.Ten.ToLower() == cbx_MaLoaiSP.Text.ToLower());
            if (lsp != null)
            {
                sp = new QlSanPhamView()
                {
                    Ma = txt_MaSanPham.Text,
                    Ten = txt_TenSanPham.Text,
                    Gia = Convert.ToDecimal(txt_GiaBan.Text),
                    MoTa = txt_Mota.Text,
                    MaLsp = lsp.Ma,
                    TrangThai = rdb_DangBan.Checked ? 1 : 0,    
                };
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }

            return sp;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn cập nhật sản phẩm này không ? ", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iSanPhamServices.add(GetDatafromGui()));
                LoadDataSP();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }

        private void dgrid_QLSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _iSanPhamServices.GetAll().Count)
            {
                return;
            }
            _maWhenClick = dgrid_QLSanPham.Rows[rowIndex].Cells[1].Value.ToString();
            var _sanphamView = _iSanPhamServices.GetAll().FirstOrDefault(c => c.Ma == _maWhenClick);
            txt_MaSanPham.Text = _sanphamView.Ma;
            txt_TenSanPham.Text = _sanphamView.Ten;
            txt_GiaBan.Text = _sanphamView.Gia.ToString();
            txt_Mota.Text = _sanphamView.MoTa;
            cbx_MaLoaiSP.Text = _sanphamView.MaLsp + "-" + _sanphamView.TenLoaiSp;
            if(_sanphamView.TrangThai == 1)
            {
                rdb_DangBan.Checked = true;
            }
            else
            {
                rdb_NgungBan.Checked = true;
            }

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var temp = GetDatafromGui();
            temp.Ma = _maWhenClick;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn cập nhật sản phẩm này không ? ", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iSanPhamServices.update(temp));
                LoadDataSP();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            int stt = 1;
            dgrid_QLSanPham.ColumnCount = 7;
            dgrid_QLSanPham.Columns[0].Name = "STT";
            dgrid_QLSanPham.Columns[1].Name = "Mã Sản Phẩm";
            dgrid_QLSanPham.Columns[2].Name = "Tên Sản Phẩm";
            dgrid_QLSanPham.Columns[3].Name = "Giá bán";
            dgrid_QLSanPham.Columns[4].Name = "Mô Tả";
            dgrid_QLSanPham.Columns[5].Name = "Mã Loại Sản Phẩm";
            dgrid_QLSanPham.Columns[6].Name = "Trạng Thái";
            dgrid_QLSanPham.Rows.Clear();
            var sanpham = _iSanPhamServices.GetAll()
                .Where(c => c.Ma.ToLower().StartsWith(txt_TimKiem.Text.ToLower()) || c.Ten.ToLower().StartsWith(txt_TimKiem.Text.ToLower()));
            foreach (var x in sanpham)
            {
                dgrid_QLSanPham.Rows.Add(stt++, x.Ma, x.Ten, x.Gia, x.MoTa, x.MaLsp, x.TrangThai == 1 ? "Đang Bán" : "Ngưng Bán", x.TenLoaiSp);
            }
        }

        private void btn_AddLSP_Click(object sender, EventArgs e)
        {
            FrmLoaiSP frm = new FrmLoaiSP();
            frm.ShowDialog();
            LoadDataLSP();
        }
    }
}
