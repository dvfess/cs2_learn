using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CommonDb db;

        public MainWindow()
        {
            InitializeComponent();
            db = new CommonDb(30, 500);
            this.DataContext = db;
        }

        private void cbDep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbEmpl.ItemsSource = db.EmpDB.Where(
                w => w.DepID == (cbDep.SelectedValue as Department)?.DepID
                ) ;
            //listEmpl.ItemsSource = data.EmployeesDb.Where(
            //    w => w.DepartamentId == (cmbDept.SelectedValue as Department)?.DepartmentId
            //    );
        }
    }
}
