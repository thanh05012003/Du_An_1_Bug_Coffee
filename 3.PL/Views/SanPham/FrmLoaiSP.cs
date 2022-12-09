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

namespace _3.PL.Views.SanPham
{
    public partial class FrmLoaiSP : Form
    {
        private ILoaiSanPhamService _iloaiSanPhamServices;
        private string _maWhenClick;
        public FrmLoaiSP()
        {
            InitializeComponent();
            _iloaiSanPhamServices = new LoaiSanPhamService();
            txt_MaLSP.Enabled = false;
            LoadDataLSP();
        }


        private QlLoaiSanPhamView GetDatafromGui()
        {
            QlLoaiSanPhamView lsp = new QlLoaiSanPhamView();
            lsp = new QlLoaiSanPhamView()
            {
                Ma = txt_MaLSP.Texts,
                Ten = txt_TenLSP.Texts,
            };
            return lsp;
        }


        public void LoadDataLSP()
        {
            int stt = 1;
            dtgrid_LSP.ColumnCount = 3;
            dtgrid_LSP.Columns[0].Name = "STT";
            dtgrid_LSP.Columns[1].Name = "Mã Loại Sản Phẩm";
            dtgrid_LSP.Columns[2].Name = "Tên Sản Phẩm";
            dtgrid_LSP.Rows.Clear();
            foreach (var x in _iloaiSanPhamServices.GetAll())
            {
                dtgrid_LSP.Rows.Add(stt++, x.Ma, x.Ten);
            }
        }


        private void dtgrid_LSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _iloaiSanPhamServices.GetAll().Count) return;
            try
            {
                _maWhenClick = dtgrid_LSP.Rows[rowIndex].Cells[1].Value.ToString();
            }
            catch (Exception exception)
            {
                return;
            }
            var lsp = _iloaiSanPhamServices.GetAll().First(c => c.Ma == _maWhenClick);
            if (lsp == null)
            {
                return;
            }
            txt_MaLSP.Texts = lsp.Ma;
            txt_TenLSP.Texts = lsp.Ten;
        }


        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            var temp = GetDatafromGui();
            temp.Ma = _maWhenClick;
            MessageBox.Show(_iloaiSanPhamServices.update(temp));
            LoadDataLSP();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            var lsp = _iloaiSanPhamServices.GetAll().FirstOrDefault(c => c.Ten.ToLower() == txt_TenLSP.Texts.ToLower());
            if (lsp != null)
            {
                MessageBox.Show("Loại sản phẩm này đã tồn tại");
            }
            else
            {
                MessageBox.Show(_iloaiSanPhamServices.add(GetDatafromGui()));
                LoadDataLSP();
            }
        }

        private void txt_TenLSP__TextChanged(object sender, EventArgs e)
        {
            txt_MaLSP.Texts = "LSP0" + (_iloaiSanPhamServices.GetAll().Count + 1);
        }
    }
}
