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

namespace KOSMETIK.StrWindow
{
    /// <summary>
    /// Логика взаимодействия для HomeAdmin.xaml
    /// </summary>
    public partial class HomeAdmin : Window
    {
        public HomeAdmin(string fio)
        {
            InitializeComponent();
            FIOText.Text = fio;
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow autho = new MainWindow();
            autho.Show();
            this.Close();
        }
    }
}