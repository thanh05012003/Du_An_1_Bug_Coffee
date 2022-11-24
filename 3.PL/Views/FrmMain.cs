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
            lb_Time.Text = DateTime.Now.ToString();
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
            //this.pane_HoaDon.Tag = activeForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            lb_Time.Text = DateTime.Now.ToString();
            var nv = _nhanVienService.GetAll().FirstOrDefault(c =>
                c.Email.ToLower() == Properties.Settings.Default.Tk.Trim() &&
                c.MatKhau.ToLower() == Properties.Settings.Default.Mk.Trim());
            lb_UserName.Text = nv.Ten;
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
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }
    }
}
