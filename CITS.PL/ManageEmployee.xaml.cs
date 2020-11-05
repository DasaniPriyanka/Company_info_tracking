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
using System.Windows.Shapes;

namespace CITS.PL
{
    /// <summary>
    /// Interaction logic for ManageEmployee.xaml
    /// </summary>
    public partial class ManageEmployee : Window
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            var addEmp = new AddEmployee();
            addEmp.Show();
        }

        private void btnUpdateEmployee_Click(object sender, RoutedEventArgs e)
        {
            var updateEmp = new UpdateEmployee();
            updateEmp.Show();
        }
    }
}
