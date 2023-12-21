using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Department
    {
        private int idphongban;

        public int Idphongban
        {
            get { return idphongban; }
            set { idphongban = value; }
        }
        private string tenphongban;

        public string Tenphongban
        {
            get { return tenphongban; }
            set { tenphongban = value; }
        }
        public Department(int idphongban, string tenphongban)
        {
            this.idphongban = idphongban;
            this.tenphongban = tenphongban;
        }
    }
}
