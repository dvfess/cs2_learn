using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Employee: INotifyPropertyChanged
    {
        public int depID;
        public int DepID { get => depID;
            set {
                depID = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.depID)));
            } }
        public int EmpID { get; set; }
        public string firstName;
        public string FirstName
        {
            get => firstName;

            set
            {
                firstName = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.FirstName)));
            }

        }
        public string LastName { get; set; }

        public Employee(int depid, string name, string last)
        {
            DepID = depid;
            FirstName = name;
            LastName = last;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
