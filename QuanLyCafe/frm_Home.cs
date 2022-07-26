using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frm_Home : Form
    {
        public static frm_Home trangchu;
        public frm_Home()
        {
            InitializeComponent();
            trangchu = this;
        }
        frm_DATBAN ban = new frm_DATBAN();
        frm_QUANLY quanly = new frm_QUANLY();
        private bool bban = false, bquanly = false;
        private void MNT_BANAN_Click(object sender, EventArgs e)
        {
            if(bquanly == true)
            {
                bquanly = false;
                quanly.Hide();
                bban = true;
                ban.TopLevel = false;
                pictureBox1.Controls.Add(ban);
                ban.FormBorderStyle = FormBorderStyle.None;
                ban.Show();
            }
            else
            {
                bban = true;
                ban.TopLevel = false;
                pictureBox1.Controls.Add(ban);
                ban.FormBorderStyle = FormBorderStyle.None;
                ban.Show();
            }
        }

        private void MNT_QUANLY_Click(object sender, EventArgs e)
        {
            if (bban == true)
            {
                bban = false;
                ban.Hide();
                bquanly = true;
                quanly.TopLevel = false;
                pictureBox1.Controls.Add(quanly);
                quanly.FormBorderStyle = FormBorderStyle.None;
                quanly.Show();
            }
            else
            {
                bquanly = true;
                quanly.TopLevel = false;
                pictureBox1.Controls.Add(quanly);
                quanly.FormBorderStyle = FormBorderStyle.None;
                quanly.Show();
            }
        }

        private void MNT_DANGXUAT_Click(object sender, EventArgs e)
        {
            this.Hide();
            // frm_Home h = new frm_Home();
            // h.ShowDialog();
            // Application.Exit();
        }

    }
}