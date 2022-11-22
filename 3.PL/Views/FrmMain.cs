using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using Timer = System.Windows.Forms.Timer;

namespace _3.PL.Views
{
    public partial class FrmMain : Form
    {
        private Form activeForm;
        private INhanVienService _nhanVienService;
        public FrmMain()
        {
            InitializeComponent();
           _nhanVienService = new NhanVienService();
           ;
        }


        private void Main_FormClosing(object sender, FormClosingEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            lb_Time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            var nv = _nhanVienService.GetAll().FirstOrDefault(c =>
                c.Email.ToLower() == Properties.Settings.Default.Tk &&
                c.MatKhau.ToLower() == Properties.Settings.Default.Mk);
            lb_UserName.Text = nv.Ten;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (childForm == null)
            {
                childForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.gr_CuaHang.Controls.Add(childForm);
            this.gr_CuaHang.Tag = activeForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPham(),sender);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.Tk = "";
                Properties.Settings.Default.Mk = "";
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhuyenMai(),sender);
        }

        private void lb_Time_Click(object sender, EventArgs e)
        {

        }
    }
}
