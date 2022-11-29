﻿using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PL.Views.BanHang;
using _3.PL.Views.ThongKe;

namespace _3.PL.Views
{
    public partial class FrmMain : Form
    {
        private INhanVienService _nhanVienService;
        public FrmMain()
        {
            InitializeComponent();
           _nhanVienService = new NhanVienService();
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
            lb_Time.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
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
            lb_Time.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            var nv = _nhanVienService.GetAll().FirstOrDefault(c =>
                c.SDT.ToLower() == Properties.Settings.Default.Tk.Trim() &&
                c.MatKhau.ToLower() == Properties.Settings.Default.Mk.Trim());
            lb_UserName.Text = nv.Ten + " - " + nv.TenCv;
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

        public void setColor(object btn)
        {
            var count = 1;
           
            if (count == 0)
            {
                btn = Color.MediumSlateBlue;
                count = 1;
            }
            else
            {
                btn = Color.MediumSpringGreen;
                count = 0;
            }
        }

     

        private void btn_SanPham_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSanPham(), sender);
        }

        private void btn_HoaDon_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDon(), sender);
        }

        private void btn_ThongKe_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe(), sender);
        }

        private void btn_KhuyenMai_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhuyenMai(), sender);
        }

        private void btn_NhanVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien(), sender);
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBanHang(),sender);
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}