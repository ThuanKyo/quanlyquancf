using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCafe.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
        private string name;
        private string status;
        private int id;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public Table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = (string)row["name"];
            this.Status = (string)row["status"];
        }
    }
}
