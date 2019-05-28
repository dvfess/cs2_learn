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
        private static int DepartmentsIndex = 0;
        private static int EmploeesIndex = 0;
        private readonly Department Deleted = new Department(DepartmentsIndex++, "Удалённые");
        static Random rnd = new Random();

        public CommonDb(int depAmount, int empAmount)
        {
            DepDB = new ObservableCollection<Department>();
            EmpDB = new ObservableCollection<Employee>();

            DepDB.Add(Deleted);

            for (int i = 0; i < depAmount; i++)
            {
                DepDB.Add(new Department(DepartmentsIndex, $"Департамент {DepartmentsIndex}"));
                DepartmentsIndex++;
            }

            for (int i = 0; i < empAmount; i++)
            {
                EmpDB.Add(new Employee(rnd.Next(1, DepDB.Count()), $"Имя {i}", $"Фамилия {i}"));
                EmploeesIndex++;
            }
        }

        public void DeleteDepartment(int? id)
        {
            if (id == Deleted.DepID) return;
            for (int i = 0; i < EmpDB.Count(); i++)
                if (EmpDB[i].DepID == id) EmpDB[i].DepID = DepDB[DepDB.IndexOf(Deleted)].DepID;

            for (int i = 0; i < DepDB.Count(); i++)
                if (DepDB[i].DepID == id) DepDB.RemoveAt(i);
        }

        public void AddDerartment()
        {
            DepDB.Add(new Department(DepartmentsIndex, $"Департамент {DepartmentsIndex++}"));
            DepartmentsIndex++;
        }
    }
}
