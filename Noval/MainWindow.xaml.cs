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

namespace Noval
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// version 1.0.0
    public partial class MainWindow : Window
    {
        static string[] jobTitle = new string[512];
        static string[] companyName = new string[512];
        static string[] jobLocation = new string[512];
        static string[] salaryPay = new string[512];
        static string[] notes = new string[512];
        static string[] applyDate = new string[512];
        static int jobCount;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void FileExit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
