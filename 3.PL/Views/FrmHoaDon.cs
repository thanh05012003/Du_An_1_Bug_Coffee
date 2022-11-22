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
    public partial class FrmHoaDon : Form
    {
        private Form activeForm;
        public FrmHoaDon()
        {
            InitializeComponent();
            OpenChildForm(new FrmHDPhaChe(), null);
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
            this.pane_HoaDon.Controls.Add(childForm);
            //this.pane_HoaDon.Tag = activeForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_LichSu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLichSuHD(),sender);
        }

        private void btn_PhaChe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHDPhaChe(),sender);
        }
    }
}
