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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
            lb_EmailFail.Visible = false;
            lb_MatKhauFail.Visible = false;
        }

        public void CheckEmail()
        {
            if (txt_Email.Text.Trim() == "")
            {
                lb_EmailFail.Visible = true;
                lb_EmailFail.Text = "Không được để trống email";
                
            }

        }
        public void CheckMatKhau()
        {
            if (txt_MatKhau.Text.Trim() == "")
            {
                lb_MatKhauFail.Visible = true;
                lb_MatKhauFail.Text = "Không được để trống mật khẩu";
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
           CheckEmail();
           CheckMatKhau();
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
