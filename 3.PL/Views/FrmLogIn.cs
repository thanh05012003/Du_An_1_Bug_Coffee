using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3.PL.Utilities;

namespace _3.PL.Views
{
    public partial class FrmLogin : Form
    {
        private Utility _utility;
        public FrmLogin()
        {
            InitializeComponent();
            _utility = new Utility();
            lb_EmailFail.Visible = false;
            lb_MatKhauFail.Visible = false;
        }

        public void Check()
        {
            if (txt_Email.Text.Trim() == "")
            {
                lb_EmailFail.Visible = true;
                lb_EmailFail.Text = "Không được để trống email";
            }
            else
            {
                if (!_utility.IsValidEmail(txt_Email.Text))
                {
                    lb_EmailFail.Visible = true;
                    lb_EmailFail.Text = "Email sai định dạng";
                }
            }
            
            if (txt_MatKhau.Text.Trim() == "")
            {
                lb_MatKhauFail.Visible = true;
                lb_MatKhauFail.Text = "Không được để trống mật khẩu";
            }
            else
            {
                if (txt_MatKhau.Text.Length < 8)
                {
                    lb_MatKhauFail.Visible = true;
                    lb_MatKhauFail.Text = "Mật khẩu phải nhiều hơn 8 kí tự";
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
    }
}
