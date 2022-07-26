using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    class Food
    {
        public  Food(int id, string name, int cartegoryID, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CartegoryID = cartegoryID;
            this.Price = price;
        }
        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CartegoryID = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private float price;
        private int cartegoryID;
        private string name;
        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CartegoryID { get => cartegoryID; set => cartegoryID = value; }
        public float Price { get => price; set => price = value; }
    }
}
