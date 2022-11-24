using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views.ThongKe
{
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
            OpenChildForm(new FrmDT_SP(),null);
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
            this.pane_ThongKe.Controls.Add(childForm);
            //this.pane_HoaDon.Tag = activeForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btn_GiaoCa_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGiaoCa(), sender);
        }

        private void btn_DT_SP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDT_SP(), sender);
        }
    }
}
