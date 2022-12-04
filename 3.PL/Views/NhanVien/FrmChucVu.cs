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

namespace _3.PL.Views.NhanVien
{
    public partial class FrmChucVu : Form
    {
        private IChucVuService _chucVuService;
        private string _maWhenClick;
        public FrmChucVu()
        {
            InitializeComponent();
            _chucVuService = new ChucVuService();
            txt_MaCv.Enabled = false;
            LoadDataCV();
        }

        private QlChucVuView GetDatafromGui()
        {
            QlChucVuView cv = new QlChucVuView();
            cv = new QlChucVuView()
            {
                Ma = txt_MaCv.Text,
                Ten = txt_TenCv.Text,
            };
            return cv;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var cv = _chucVuService.GetAll().FirstOrDefault(c => c.Ten.ToLower() == txt_TenCv.Text.ToLower().Trim());
            if (cv != null)
            {
                MessageBox.Show("Chức vụ này đã tồn tại");
            }
            else
            {
                MessageBox.Show(_chucVuService.add(GetDatafromGui()));
            }
            
            
        }

        private void txt_TenCv_TextChanged(object sender, EventArgs e)
        {
            txt_MaCv.Text = "CV0" + (_chucVuService.GetAll().Count +1);
        }

        public void LoadDataCV()
        {
            int stt = 1;
            dtgrid_ChucVu.ColumnCount = 3;
            dtgrid_ChucVu.Columns[0].Name = "STT";
            dtgrid_ChucVu.Columns[1].Name = "Mã Chức Vụ";
            dtgrid_ChucVu.Columns[2].Name = "Tên Chức Vụ";
            dtgrid_ChucVu.Rows.Clear();
            foreach (var x in _chucVuService.GetAll())
            {
                dtgrid_ChucVu.Rows.Add(stt++, x.Ma, x.Ten);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = GetDatafromGui();
            temp.Ma = _maWhenClick;
            MessageBox.Show(_chucVuService.update(temp));
            LoadDataCV();
        }

        private void dtgrid_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex == _chucVuService.GetAll().Count) return;
            _maWhenClick = dtgrid_ChucVu.Rows[rowIndex].Cells[1].Value.ToString();
            var cv = _chucVuService.GetAll().First(c => c.Ma == _maWhenClick);
            if (cv == null)
            {
                return;
            }
            txt_MaCv.Text = cv.Ma;
            txt_TenCv.Text = cv.Ten;
        }
    }
}
