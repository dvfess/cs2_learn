using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class CommonDb
    {
        public ObservableCollection<Department> DepDB { get; set; }
        public ObservableCollection<Employee> EmpDB { get; set; }
        static Random rnd = new Random();

        public CommonDb(int depAmount, int empAmount)
        {
            DepDB = new ObservableCollection<Department>();
            EmpDB = new ObservableCollection<Employee>();

            for (int i = 0; i < depAmount; i++)
            {
                DepDB.Add(new Department(i, $"Департамент {i}"));
            }

            for (int i = 0; i < empAmount; i++)
            {
                EmpDB.Add(new Employee(rnd.Next(DepDB.Count()), $"Имя {i}", $"Фамилия {i}"));
            }
        }
    }
}
