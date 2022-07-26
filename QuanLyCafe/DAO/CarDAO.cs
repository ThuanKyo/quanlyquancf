using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class CarDAO
    {
        private static CarDAO instance;

        public static CarDAO Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new CarDAO();
                return CarDAO.instance;
            }
            private set
            {
                CarDAO.instance = value;
            }
        }
        private CarDAO() { }
    public List<Cartegor> GetListCartegory()
        {
            List<Cartegor> list = new List<Cartegor>();
            string query = "Select * from CATEGORY";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach( DataRow item in data.Rows)
            {
                Cartegor car = new Cartegor(item);
                list.Add(car);
            }
            return list;
        }
    }
}
