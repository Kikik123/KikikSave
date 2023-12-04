using KOSMETIK.Model;
using KOSMETIK.StrWindow;
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

namespace KOSMETIK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<User> userObj;
        public string UserFIO;
        public MainWindow()
        {
            InitializeComponent();
            userObj = KosmetikEntities.GetContext().User.ToList();
        }
        public void Btn_Click1(object sender, RoutedEventArgs e)
        {
            var currentUsers = userObj.Where(user => user.UserLogin == logtxt.Text && user.UserPassword == pass.Password).FirstOrDefault();
            if (currentUsers != null)
            {
                UserFIO = currentUsers.UserSurname + " " + currentUsers.UserName + " " + currentUsers.UserPatronymic + " ";
                HomeAdmin a = new HomeAdmin(UserFIO);
                HomeManagerClientGuest mcg = new HomeManagerClientGuest(UserFIO);
                if (currentUsers.UserRole == 1)
                {
                    a.Show();
                    a.FrmMain.Navigate(new AdminProduct());
                }
                else
                {
                    mcg.Show();
                    mcg.FrmMain2.Navigate(new Products());
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите правильный логин и пароль",
                    "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Btn_Click_Guest(object sender, RoutedEventArgs e)
        {
            UserFIO = "Гость ";
            HomeManagerClientGuest mcg = new HomeManagerClientGuest(UserFIO);
            mcg.Show();
            mcg.FrmMain2.Navigate(new Products());
            this.Close();
        }
    }
}

