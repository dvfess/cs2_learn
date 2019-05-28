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
        //1. Создать сущности Employee и Department и заполнить списки сущностей начальными данными.
        //2. Для списка сотрудников и списка департаментов предусмотреть визуализацию(отображение).
        //   Это можно сделать, например, с использованием ComboBox или ListView.
        //3. Предусмотреть редактирование сотрудников и департаментов. Должна быть возможность изменить
        //   департамент у сотрудника. Список департаментов для выбора можно выводить в ComboBox,
        //   и все это можно выводить на дополнительной форме.
        //4. Предусмотреть возможность создания новых сотрудников и департаментов. Реализовать это
        //   либо на форме редактирования, либо сделать новую форму.


    CommonDb db;

        public MainWindow()
        {
            InitializeComponent();
            db = new CommonDb(5, 100);
            this.DataContext = db;
        }

        private void cbDep_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbEmpl.ItemsSource = db.EmpDB.Where(
                w => w.DepID == (cbDep.SelectedValue as Department)?.DepID
                ) ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.DeleteDepartment((cbDep.SelectedValue as Department)?.DepID);
            cbDep.SelectedIndex = 0;
        }

        private void BtnMoveTo_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < lbEmpl.SelectedItems.Count; i++)
            {
                (lbEmpl.SelectedItems[i] as Employee).DepID = (cbMoveTo.SelectedItem as Department).DepID;
            }
        }

        private void BtnAddDep_Click(object sender, RoutedEventArgs e)
        {
            db.AddDerartment();
        }
    }
}
