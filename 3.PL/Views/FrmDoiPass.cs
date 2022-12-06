using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmDoiPass : Form
    {
        private INhanVienService _inhanVienServices;
        public FrmDoiPass()
        {
            InitializeComponent();
            this.CenterToScreen();
            _inhanVienServices = new NhanVienService();
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            var mk = _inhanVienServices.GetAll().FirstOrDefault(c => c.MatKhau == txt_MatKhauCu.Texts && c.SDT.ToLower() == Properties.Settings.Default.Tk);
            if (mk == null)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");

            }
            else if (txt_MatKhauMoi.Texts.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự");

            }
            else if (txt_NhapLaiMk.Texts != txt_NhapLaiMk.Texts)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi mật khẩu không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var mkmoi = _inhanVienServices.GetAll().FirstOrDefault();
                    mkmoi.MatKhau = txt_MatKhauMoi.Texts;
                    _inhanVienServices.update(mkmoi);
                    MessageBox.Show("Đổi mật khẩu thành công.");
                }
                this.Close();
            }
        }
    }
}
