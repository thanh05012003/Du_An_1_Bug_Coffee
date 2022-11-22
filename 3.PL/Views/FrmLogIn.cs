using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Utilities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            lb_EmailFail.Visible = false;
            lb_MatKhauFail.Visible = false;
        }

        public void Check()
        {
            var login = _nhanVienService.GetAll().FirstOrDefault(c =>
                c.Email.ToLower() == txt_Email.Text.ToLower().Trim() &&
                c.MatKhau.ToLower() == txt_MatKhau.Text.ToLower().Trim());
            if (txt_Email.Text.Trim() == "")
            {
                lb_EmailFail.Visible = true;
                lb_EmailFail.Text = "Không được để trống email";
            }
            else
            {
                if (txt_MatKhau.Text.Trim() == "")
                {
                    lb_MatKhauFail.Visible = true;
                    lb_MatKhauFail.Text = "Không được để trống mật khẩu";
                }
                else
                {
                    if (!_utility.IsValidEmail(txt_Email.Text))
                    {
                        lb_EmailFail.Visible = true;
                        lb_EmailFail.Text = "Email sai định dạng";
                    }
                    else
                    {
                        if (txt_MatKhau.Text.Length < 8)
                        {
                            lb_MatKhauFail.Visible = true;
                            lb_MatKhauFail.Text = "Mật khẩu phải nhiều hơn 8 kí tự";
                        }
                        else
                        {
                            if (login == null)
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                            }
                            else
                            {
                                Properties.Settings.Default.Tk = txt_Email.Text.ToLower().Trim();
                                Properties.Settings.Default.Mk = txt_MatKhau.Text.ToLower().Trim();
                                FrmMain main = new FrmMain();
                                main.Show();
                                this.Hide();
                            }
                        }
                    }
                }

            }

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            lb_EmailFail.Visible = false;
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            lb_MatKhauFail.Visible = false;
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
    }
}
