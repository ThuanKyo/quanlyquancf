using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCafe.DTO;


namespace QuanLyCafe.DAO
{
    public class BillADO
    {
        private static BillADO instance;

        public static BillADO Instance
        {
            get
            {
                if (instance == null) 
                    instance = new BillADO();
                return BillADO.instance;
            }
            private set
            {
                BillADO.instance = value;
            }
        }
        private BillADO()
        {

        }
        public void CheckOut(int id)
        {
            string query = "UPDATE dbo.BILL SET status = 1 WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int GeTUnCheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BILL WHERE idtable =" + id + " AND status= 0");
            if(data.Rows.Count > 0)
            {
                Bill Bill = new Bill(data.Rows[0]);
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idtable", new object[] { id});
        }
        public int GetMaxIDBill()
        {
            try
            {

                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
    }
}
