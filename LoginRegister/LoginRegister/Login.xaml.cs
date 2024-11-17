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
using LoginRegister.ServiceReference1;

namespace LoginRegister
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        Service1Client service;
        private NavigationService navSrv;
        public Login()
        {
            InitializeComponent();
            this.Loaded += Login_Loaded;

            service = new Service1Client();
        }
        private void Login_Loaded(object sender, RoutedEventArgs e)
        {
            this.navSrv = this.NavigationService;
            this.navSrv.Navigating += NavSrv_Navigating; ;
        }

        private void NavSrv_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back)
                e.Cancel = true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (cmb.SelectedValue == student2)
            {
                MainPage.student = service.Login(this.textBox.Text, passwordBox.Password);
                 if(MainPage.student!=null)
               {
                    //    textBlock.Visibility = Visibility.Hidden;  //  מיותר
                    NavigationService nav = NavigationService.GetNavigationService(this);
                    nav.Navigate(new MainPage());

                }
                else
                {
                    textBlock.Visibility = Visibility.Visible;
                    textBlock.Text = "שם משתמש או הסיסמא לא נכונים, נסה שנית";
                }


            }
            else if(cmb.SelectedValue == housekeeper2)
            {
                HouseKeeperPage.housekeeper = service.Login1(this.textBox.Text, passwordBox.Password);
                if (HouseKeeperPage.housekeeper != null)
                {
                    NavigationService nav = NavigationService.GetNavigationService(this);
                    nav.Navigate(new HouseKeeperPage());
                }
                else
                {
                    textBlock.Visibility = Visibility.Visible;
                    textBlock.Text = "שם משתמש או הסיסמא לא נכונים, נסה שנית";
                }
            }
            else
            {
                textBlock.Visibility = Visibility.Visible;
                textBlock.Text = "תבחר בבקשה תלמיד או אב בית";
            }
           
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)  // fill the correct UName & Password
        {
            this.textBox.Text = "054545455";
            this.passwordBox.Password = "Itay_12";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new LoginOrRegister());
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = "054845455";
            this.passwordBox.Password = "Yossi_12";
        }
    }
}
