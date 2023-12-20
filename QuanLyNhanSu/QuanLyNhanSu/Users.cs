using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public string admin { get; set; }

        public Users () { }

        public Users (int idU, string nameU, string passU, string emailU, string adminU)
        {
            this.id = idU;
            this.name = nameU;
            this.pass = passU;
            this.email = emailU;
            this.admin = adminU;
        }
    }
}
