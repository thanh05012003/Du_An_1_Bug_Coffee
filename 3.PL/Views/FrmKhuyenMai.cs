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
        public FrmKhuyenMai()
        {
            _voucherService = new VoucherService();
            InitializeComponent();

        }
        public void loadDataKM()
        {

        }
        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
