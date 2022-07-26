using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCafe.DAO;
using System.Globalization;

namespace QuanLyCafe
{
    public partial class frm_DATBAN : Form
    {
        public frm_DATBAN()
        {
            InitializeComponent();
            loadTable();
            loadCartegory();
        }
        #region Method;
        void loadTable()
        {
            List<Table> tableList = TableDAO.Instance.loadTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() 
                { 
                    Width = TableDAO.TableWidth,
                    Height = TableDAO.TableHeight
                };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        btn.ForeColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.LightYellow;
                        btn.ForeColor = Color.Red;
                        break;
                }
                flpTable.Controls.Add(btn);

            }
        }
        void loadCartegory()
        {
            List<Cartegor> list = CarDAO.Instance.GetListCartegory();
            cb_danhmuc.DataSource = list;
            cb_danhmuc.DisplayMember = "Name";

        }
        void loadFood(int id)
        {
            List<Food> list = FoodDAO.Instance.GetFoodByCarId(id);
            cb_tenmon.DataSource = list;
            cb_tenmon.DisplayMember = "Name";
        }
        void ShowBill (int id)
        {
            lsvBILL.Items.Clear();
            List<QuanLyCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach(QuanLyCafe.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBILL.Items.Add(lsvItem);
            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            txt_TotalPrice.Text = totalPrice.ToString("c", cultureInfo);
        }
        #endregion;
        #region Events;
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBILL.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void cb_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Cartegor selected = cb.SelectedItem as Cartegor;
            id = selected.ID;
            loadFood(id);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            Table table = lsvBILL.Tag as Table;
           
            int idBill = BillADO.Instance.GeTUnCheckBillIDByTableID(table.Id);
            int idFood = (cb_tenmon.SelectedItem as Food).ID;
            int count = (int)nbd_soluong.Value;
            if(idBill == -1)
            {
                BillADO.Instance.InsertBill(table.Id);
                BillInfoDAO.Instance.InsertBillInfo(BillADO.Instance.GetMaxIDBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count); 
            }
            ShowBill(table.Id);
        }


        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            Table table = lsvBILL.Tag as Table;

            int idBill = BillADO.Instance.GeTUnCheckBillIDByTableID(table.Id);
            if (idBill != -1)
            {
                if(MessageBox.Show("Bạn có chắc thanh toán cho bàn "+ table.Name, "Thông báo", MessageBoxButtons.OKCancel)== System.Windows.Forms.DialogResult.OK)
                {
                    BillADO.Instance.CheckOut(idBill);
                    ShowBill(table.Id);
                }
            }
        }

        #endregion

    }
}
