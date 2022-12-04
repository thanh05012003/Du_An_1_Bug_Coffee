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
                Ma = txt_MaLSP.Text,
                Ten = txt_TenLSP.Text,
            };
            return lsp;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iloaiSanPhamServices.add(GetDatafromGui()));
        }

        private void txt_TenLSP_TextChanged(object sender, EventArgs e)
        {
            txt_MaLSP.Text = "LSP0" + (_iloaiSanPhamServices.GetAll().Count + 1);
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDatafromGui();
            temp.Ma = _maWhenClick;
            MessageBox.Show(_iloaiSanPhamServices.update(temp));
            LoadDataLSP();
        }

        private void dtgrid_LSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _iloaiSanPhamServices.GetAll().Count) return;
            _maWhenClick = dtgrid_LSP.Rows[rowIndex].Cells[1].Value.ToString();
            var lsp = _iloaiSanPhamServices.GetAll().First(c => c.Ma == _maWhenClick);
            if (lsp == null)
            {
                return;
            }
            txt_MaLSP.Text = lsp.Ma;
            txt_TenLSP.Text = lsp.Ten;
        }
    }
}
