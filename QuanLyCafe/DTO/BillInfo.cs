using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int status)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Status = status;
        }
        private int status;
        private int foodID;
        private int billID;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Status { get => status; set => status = value; }
        public BillInfo(DataRow row)
        {
            this.ID = (int) row["id"];
            this.BillID = (int) row["idbill"];;
            this.FoodID = (int) row["idfood"];
            this.Status = (int)row["total"];
        }  
    }
}
