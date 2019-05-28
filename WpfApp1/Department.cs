using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Department
    {
        public int DepID { get; set; }
        /// <summary>
        /// Наименование департамента.
        /// </summary>
        public string Name { get; set; }

        public Department(int depid, string name)
        {
            DepID = depid;
            Name = name;
        }
    }
}
