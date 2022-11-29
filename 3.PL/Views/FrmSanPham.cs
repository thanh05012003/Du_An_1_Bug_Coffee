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

namespace _3.PL.Views
{
    public partial class FrmSanPham : Form
    {
        private ISanPhamService _iSanPhamServices;
        private string _maWhenClick;
        private QlSanPhamView _qlSanPhamView;
        public FrmSanPham()
        {
            InitializeComponent();
            _iSanPhamServices = new SanPhamService();
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {

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
                dgrid_QLSanPham.Rows.Add(stt++, x.Ma, x.Ten, x.Gia, x.MoTa, x.MaLsp, x.TrangThai);
            }
        }

    }
}
