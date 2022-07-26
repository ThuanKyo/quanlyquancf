using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        { 
            get
            {
                if(instance == null)
                {
                    instance = new MenuDAO();
                }
                return MenuDAO.instance;
            }
            private set
            {
                MenuDAO.instance = value;
            }
        }
        
        private MenuDAO()
        {

        }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> list = new List<Menu>();
            string sql = "SELECT f.name, bi.total,f.price, f.price*bi.total AS totlePrice FROM dbo.BILLINFO AS bi, dbo.BILL AS b, dbo.FOOD AS f WHERE bi.idbill = b.id AND bi.idfood = f.id AND b.status = 0 AND b.idtable =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            foreach(DataRow item in data.Rows) {
                Menu menu = new Menu(item);
                list.Add(menu);
            }
            return list;
        }
    }
}
