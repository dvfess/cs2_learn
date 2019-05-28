using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Employee
    {
        public int DepID { get; set; }
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int depid, string name, string last)
        {
            DepID = depid;
            FirstName = name;
            LastName = last;
        }
    }
}
