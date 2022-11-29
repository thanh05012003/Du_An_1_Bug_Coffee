using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Utilities;

namespace _3.PL.Views
{
    public partial class FrmLogin : Form
    {
        private Utility _utility;
        INhanVienService _nhanVienService;
        public FrmLogin()
        {
            InitializeComponent();
            _utility = new Utility();
            _nhanVienService = new NhanVienService();
            txt_MatKhau.PasswordChar = true;
        }

        public void Check()
        {
            var login = _nhanVienService.GetAll().FirstOrDefault(c =>
                c.SDT.ToLower() == txt_TaiKhoan.Texts.ToLower().Trim() &&
                c.MatKhau.ToLower() == txt_MatKhau.Texts.ToLower().Trim());
            if (txt_TaiKhoan.Texts.Trim() == "")
            {
                txt_TaiKhoan.PlaceholderColor = Color.Red;
                txt_TaiKhoan.PlaceholderText = "Không được để trống";
            }
            else
            {
                if (txt_MatKhau.Texts.Trim() == "")
                {
                    txt_MatKhau.PlaceholderColor = Color.Red;
                    txt_MatKhau.PlaceholderText = "Không được để trống";
                }
                else
                {
                    if (txt_MatKhau.Texts.Length < 8)
                    {
                        txt_MatKhau.Texts = "";
                        txt_MatKhau.PlaceholderColor = Color.Red;
                        txt_MatKhau.PlaceholderText = "mật khẩu phải nhiều hơn 8 kí tự";
                    }
                    else
                    {
                        if (login == null)
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                        }
                        else
                        {
                            Properties.Settings.Default.Tk = txt_TaiKhoan.Texts;
                            Properties.Settings.Default.Mk = txt_MatKhau.Texts;
                            FrmMain main = new FrmMain();
                            main.Show();
                            this.Hide();
                        }
                    }
                }

            }

        }



        private void cb_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Show.Checked)
            {
                txt_MatKhau.PasswordChar = false;
            }
            else
            {
                txt_MatKhau.PasswordChar = true;
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }


        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            Check();
        }
    }
}
