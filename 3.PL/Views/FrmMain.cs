using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using _3.PL.Views.BanHang;


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
            if (Properties.Settings.Default.Tk == "admin")
            {
                lb_UserName.Text = "admin";
            }else if (nv!=null)
            {
                lb_UserName.Text = nv.Ten + " - " + nv.TenCv;
            }
            
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
            OpenChildForm(new FrmDT_SP(), sender);
        }

        private void btn_KhuyenMai_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhuyenMai(), sender);
        }

        private void btn_NhanVien_Click_1(object sender, EventArgs e)
        {
            if (lb_UserName.Text.ToLower() == "admin")
            {
                OpenChildForm(new FrmNhanVien(), sender);
            }
            var nv = _nhanVienService.GetAll().FirstOrDefault(c =>
                c.SDT.ToLower() == Properties.Settings.Default.Tk.Trim());
            if (nv == null) 
            {
                return;
            }
            if (nv.MaCV == "CV01")
            {
                OpenChildForm(new FrmNhanVien(),sender);
              
            }
            else
            {
                MessageBox.Show("Bạn không có quyền mở chức năng này");
            }
        }

        public void btn_TrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBan(),sender);
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            if (lb_UserName.Text == "admin")
            {
                MessageBox.Show("Bạn đang đăng nhập bằng tài khoản admin. Bạn không thể mở chức năng này!");
            }
            else
            {
                OpenChildForm(new FrmBanHang(),sender);
            }
            
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (lb_UserName.Text == "admin")
            {
                MessageBox.Show("Bạn đang đăng nhập bằng tài khoản admin. Bạn không thể mở chức năng này!");
            }
            else
            {
                FrmDoiPass frm = new FrmDoiPass();
                frm.ShowDialog();
            }
        }

        private void btn_Themban_Click(object sender, EventArgs e)
        {
            IBanService _banService = new BanService();
            int soban = 1;
            QlBanView ban = new QlBanView()
            {
                Ma = "B00" + (_banService.GetAll().Count + 1),
                Ten = "Bàn " + (_banService.GetAll().Count + 1),
                TrangThai = 1,
            };
            if (_banService.GetAll().Count >= 9)
            {
                ban.Ma = "B0" + (_banService.GetAll().Count + 1);
            }
            DialogResult dlg =
                MessageBox.Show($"Bạn đang có {_banService.GetAll().Count} bàn, bạn có chắc muốn thêm bàn nữa không?","Xác nhận",MessageBoxButtons.OKCancel);
            if (dlg == DialogResult.OK)
            {
                MessageBox.Show(_banService.add(ban));
                OpenChildForm(new FrmBan(),sender);
            }
            
        }
    }
}
