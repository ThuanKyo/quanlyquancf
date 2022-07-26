using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyCafe
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        int i = 0;

        private void btn_dn_Click(object sender, EventArgs e)
        {
            int cvnew = 0;
            string cv = cbb_cv.Text;
            if (cv == "Nhân viên")
            {
                cvnew = 0;
            }
            else
            {
                cvnew = 1;
            }

            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);

            string sql = "Select *From ACCOUNT WHERE username = '" + txt_tk.Text.Trim() + "' AND password = '" + txt_mk.Text.Trim() + "' AND type = '" + cvnew + "'";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader dt = comm.ExecuteReader();

            if (dt.Read())
            {
                if (cvnew == 1)
                {
                    MessageBox.Show("Admin Đã Đăng Nhập Thành Công!");
                    frm_QUANLY fQL = new frm_QUANLY();
                    fQL.Show();
                    this.Hide();
                }
                else if (cvnew == 0)
                {
                    MessageBox.Show("Nhân Viên Đã Đăng Nhập Thành Công!");
                    frm_Home fHome = new frm_Home();
                    fHome.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại!");
                i++;
                if (i == 3)
                {
                    MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần, ứng dụng sẽ thoát!");
                    Application.Exit();
                }
            }
            conn.Close();
        }
    }
}
