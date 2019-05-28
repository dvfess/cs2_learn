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
        public string Name { get; set; }

        public Employee(int depid, string name)
        {
            DepID = depid;
            Name = name;
        }
    }
}
