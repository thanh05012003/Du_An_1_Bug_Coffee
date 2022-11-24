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
        public FrmChucVu()
        {
            InitializeComponent();
            _chucVuService = new ChucVuService();
            txt_MaCv.Enabled = false;
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
            MessageBox.Show(_chucVuService.add(GetDatafromGui()));
            
        }

        private void txt_TenCv_TextChanged(object sender, EventArgs e)
        {
            txt_MaCv.Text = "CV0" + (_chucVuService.GetAll().Count +1);
        }
    }
}
