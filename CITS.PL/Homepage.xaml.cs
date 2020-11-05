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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            var EmpList = new EmployeeList();
            EmpList.ShowDialog();
        }

        private void btnAttendance_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            var EmpAttendance = new Attendance();
            EmpAttendance.Show();
        }

        private void btnPayroll_Click(object sender, RoutedEventArgs e)
        {
            var EmpPayroll = new Payroll();
            EmpPayroll.Show();
        }

        
        private void btnManage_Click(object sender, RoutedEventArgs e)
        {
            var manageEmp = new ManageEmployee();
            manageEmp.Show();

        }

        private void btnReports_Click(object sender, RoutedEventArgs e)
        {
            var empReports = new Reports();
            empReports.Show();
        }
    }
}