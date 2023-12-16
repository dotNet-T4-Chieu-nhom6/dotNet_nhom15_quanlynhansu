using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ListEmployee
    {
        private static List<Employee> instance;

        public static List<Employee> Instance
        {
            get
            {
                if (instance == null)
                    instance = new List<Employee>();
                return ListEmployee.instance;
            }
            set { ListEmployee.instance = value; }
        }
        private List<Employee> listEmp;

        public List<Employee> ListEmp
        {
            get { return listEmp; }
            set { listEmp = value; }
        }
        public ListEmployee()
        {
            listEmp = new List<Employee>();
            listEmp.Add(new Employee("Nguyễn Văn A", new DateTime(1999, 12, 3), "Lạc Long Quân", "nva@gmail.com", "Nam", 0799356582, "Đại học", "IT", 101, "FE-Dev", 5000, "FE", "ON", 200));
        }
    }
}
