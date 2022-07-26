using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class frm_QUANLY : Form
    {
        public frm_QUANLY()
        {
            InitializeComponent();
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From CATEGORY", conn);
            da.Fill(dt);
            conn.Close();
            cbb_iddm.DataSource = dt;
            cbb_iddm.DisplayMember = "name";
            cbb_iddm.ValueMember = "id";
            
        }
        void loaddataDM()
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand comm = new SqlCommand();
            comm = conn.CreateCommand();
            comm.CommandText = "Select * from CATEGORY";
            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);
            dt_dm.DataSource = dt;
        }
        void loaddataFOOD()
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand comm = new SqlCommand();
            comm = conn.CreateCommand();
            comm.CommandText = "Select *From FOOD";
            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);
            dt_food.DataSource = dt;
        }
        void loadTable()
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand comm = new SqlCommand();
            comm = conn.CreateCommand();
            comm.CommandText = "Select *From TABLEORDER";
            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);
            dtgv_ban.DataSource = dt;
        }
        void loaddataTKMK()
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoikn);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand comm = new SqlCommand();
            comm = conn.CreateCommand();
            comm.CommandText = "Select * from ACCOUNT";
            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);
            dt_acc.DataSource = dt;
        }
        private void dt_acc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dt_acc.CurrentRow.Index;
            txt_tk.Text = dt_acc.Rows[i].Cells[0].Value.ToString();
            txt_mk.Text = dt_acc.Rows[i].Cells[1].Value.ToString();

        }
        private void btn_them_Click(object sender, EventArgs e)
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

            string sql = "Insert Into ACCOUNT Values ('" + txt_tk.Text + "', '" + txt_mk.Text + "', '" + cvnew + "')";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            

            if (kq >= 1)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else MessageBox.Show("Thêm tài khoản thất bại!");
            loaddataTKMK();
        }

        private void btn_sua_Click(object sender, EventArgs e)
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

            string sql = "Update ACCOUNT set password = '" + txt_mk.Text.Trim() + "', type = '" + cvnew + "' WHERE username = '" + txt_tk.Text.Trim() + "' ";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Sửa tài khoản thành công!");
            }
            else MessageBox.Show("Sửa tài khoản thất bại!");
            loaddataTKMK();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);

            string sql = "Delete ACCOUNT WHERE username = '" + txt_tk.Text.Trim() + "' ";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Xoá tài khoản thành công!");
            }
            else MessageBox.Show("Xoá tài khoản thất bại!");
            loaddataTKMK();
        }



        private void btn_show_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";
            using (SqlConnection sqlConn = new SqlConnection(chuoiketnoi))
            {
                sqlConn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM CATEGORY", sqlConn);
                DataTable dttb1 = new DataTable();
                sqlDa.Fill(dttb1);
                dt_dm.DataSource = dttb1;
                txt_iddanhmuc.Text = "";
                txt_tendm.Text = "";
            }

        }

        private void btn_themdm_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);

            string sql = "Insert Into CATEGORY Values (N'" + txt_tendm.Text + "')";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Thêm danh mục thành công!");
            }
            else MessageBox.Show("Thêm danh mục thất bại!");
            loaddataDM();


        }

        private void dt_dm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dt_dm.CurrentRow.Index;
            txt_iddanhmuc.Text = dt_dm.Rows[i].Cells[0].Value.ToString();
            txt_tendm.Text = dt_dm.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_suadm_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);

            string sql = "Update CATEGORY set name = N'" + txt_tendm.Text + "' Where id = '"+txt_iddanhmuc.Text+"'";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Sửa danh mục thành công!");
            }
            else MessageBox.Show("Sửa danh mục thất bại!");
            loaddataDM();
        }

        private void btn_xoadm_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);

            string sql = "Delete CATEGORY WHERE id = '" + txt_iddanhmuc.Text + "' ";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Xoá danh mục thành công!");
            }
            else MessageBox.Show("Xoá danh mục thất bại!");
            loaddataDM();
        }

        private void frm_QUANLY_Load(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);

            conn.Open();
            loaddataDM();
            loaddataFOOD();
            loaddataTKMK();
            loadTable();
        }

        private void btn_themtd_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);


            string sql = "Insert Into FOOD Values ( N'" + txt_tenmon.Text + "', '" + cbb_iddm.SelectedValue + "', '" + txt_gia.Text + "')";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Thêm thực đơn thành công!");
            }
            else MessageBox.Show("Thêm thực đơn thất bại!");
            loaddataFOOD();
        }

        private void dt_food_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dt_food.CurrentRow.Index;
            txt_idmon.Text = dt_food.Rows[i].Cells[0].Value.ToString();
            txt_tenmon.Text = dt_food.Rows[i].Cells[1].Value.ToString();
            txt_iddanhmuc.Text = dt_food.Rows[i].Cells[2].Value.ToString();
            txt_gia.Text = dt_food.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_suatd_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);


            string sql = "Update FOOD set name = N'" + txt_tenmon.Text + "', idcategory = '" + cbb_iddm.SelectedValue + "', price = '" + txt_gia.Text + "' where id = '"+txt_idmon.Text+"'";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Sửa thực đơn thành công!");
            }
            else MessageBox.Show("Sửa thực đơn thất bại!");
            loaddataFOOD();
        }

        private void btn_xoatd_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);


            string sql = "Delete FOOD where id = '"+txt_idmon.Text+"'";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Xoá thực đơn thành công!");
            }
            else MessageBox.Show("Xoá thực đơn thất bại!");
            loaddataFOOD();
        }

        private void btn_refreshtd_Click(object sender, EventArgs e)
        {
            string text = "";
            txt_idmon.Text = text;
            txt_tenmon.Text = text;
            cbb_iddm.Text = text;
            txt_gia.Text = text;
            loaddataFOOD();
        }

        private void dt_dm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dt_dm.CurrentRow.Index;
            txt_iddanhmuc.Text = dt_dm.Rows[i].Cells[0].Value.ToString();
            txt_tendm.Text = dt_dm.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_dx_Click(object sender, EventArgs e)
        {
            frm_login flogin = new frm_login();
            flogin.Show();
            this.Hide();
        }

        private void txt_themban_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);


            string sql = "Insert Into TABLEORDER Values ( N'" + txt_tenban.Text + "', N'" + txt_trangthai.Text + "')";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Thêm bàn thành công!");
            }
            else MessageBox.Show("Thêm bàn thất bại!");
            loadTable();
        }

        private void txt_suaban_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);


            string sql = "Update TABLEORDER set name = N'" + txt_tenban.Text + "', status = N'" + txt_trangthai.Text + "' where id = '"+txt_idban.Text+"'";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Sửa bàn thành công!");
            }
            else MessageBox.Show("Sửa bàn thất bại!");
            loadTable();
        }

        private void txt_xoaban_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CS403\QuanLyCafe\QuanLyCafe\QLCFDTB.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(chuoiketnoi);


            string sql = "Delete TABLEORDER where id = '"+txt_idban.Text+"'";

            SqlCommand comm = new SqlCommand(sql, conn);

            conn.Open();

            int kq = comm.ExecuteNonQuery();

            conn.Close();

            if (kq >= 1)
            {
                MessageBox.Show("Xoá bàn thành công!");
            }
            else MessageBox.Show("Xoá bàn thất bại!");
            loadTable();
        }

        private void txt_rfban_Click(object sender, EventArgs e)
        {
            txt_trangthai.Text = "";
            txt_idban.Text = "";
            txt_tenban.Text = "";
        }

        private void dtgv_ban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgv_ban.CurrentRow.Index;
            txt_idban.Text = dtgv_ban.Rows[i].Cells[0].Value.ToString();
            txt_tenban.Text = dtgv_ban.Rows[i].Cells[1].Value.ToString();
            txt_trangthai.Text = dtgv_ban.Rows[i].Cells[2].Value.ToString();
        }
    }
}
