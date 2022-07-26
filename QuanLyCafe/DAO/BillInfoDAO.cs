using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;

namespace QuanLyCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        { 
            get
            {
                if(instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
            private set
            {
                BillInfoDAO.instance = value;
            }
        }
        private BillInfoDAO()
        {

        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> list = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.BILLINFO where idBill =" + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                list.Add(info);
            }
            return list;
        }
        public void InsertBillInfo(int idbill, int idfood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @total", new object[] { idbill, idfood, count });
        }
    }
}
