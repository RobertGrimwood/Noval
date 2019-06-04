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
    /// Interaction logic for PreviousJobs.xaml
    /// </summary>
    public partial class PreviousJobs : Window
    {
        int jobCountStore = MainWindow.jobCount;
       

        public PreviousJobs()
        {
            
            
            InitializeComponent();
            JobNoBlock.Text = MainWindow.jobCount.ToString();
            CompanyNameBlock.Text = MainWindow.companyName[MainWindow.jobCount];
            JobTitleBlock.Text = MainWindow.jobTitle[MainWindow.jobCount];
            JobLocationBlock.Text = MainWindow.jobLocation[MainWindow.jobCount];
            SalaryBlock.Text = MainWindow.salaryPay[MainWindow.jobCount];
            ApplyDateBlock.Text = MainWindow.applyDate[MainWindow.jobCount];
            NotesBlock.Text = MainWindow.notes[MainWindow.jobCount];
        }

        private void SubtractClick(object sender, RoutedEventArgs e)
        {
            MainWindow.jobCount--;
            if(MainWindow.jobCount < 0)
            {
                MainWindow.jobCount = 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.jobCount++;
            if (MainWindow.jobCount > jobCountStore)
            {
                MainWindow.jobCount = jobCountStore;
            }
        }
    }
}
