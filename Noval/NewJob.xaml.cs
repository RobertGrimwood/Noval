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

namespace Noval
{
    /// <summary>
    /// Interaction logic for NewJob.xaml
    /// </summary>
    public partial class NewJob : Window
    {
        public NewJob()
        {
            
            InitializeComponent();
            JobNoBox.Text = MainWindow.jobCount.ToString();
            MainWindow.companyName[MainWindow.jobCount] = CompanyNameBox.Text;

            MainWindow.jobTitle[MainWindow.jobCount] = JobTitleBox.Text;
            MainWindow.jobLocation[MainWindow.jobCount] = JobLocationBox.Text;
            MainWindow.salaryPay[MainWindow.jobCount] = SalaryBox.Text;
            MainWindow.applyDate[MainWindow.jobCount] = ApplyDatePicker.Text;
            MainWindow.notes[MainWindow.jobCount] = NotesBox.Text;
            save
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.jobCount++;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
