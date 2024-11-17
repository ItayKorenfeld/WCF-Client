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
    /// Interaction logic for HouseKeeperPage.xaml
    /// </summary>
    public partial class HouseKeeperPage : Page
    {
        private List<ServiceReference1.Problems> problemlist = new List<ServiceReference1.Problems>();

        Service1Client service;
        public static HouseKeeper housekeeper;
        public static Frame Frame;
        public static Problems p;
        public HouseKeeperPage()
        {
            InitializeComponent();
            txtb2.Text = "Hi " + housekeeper.FirstName + " " + housekeeper.LastName;
            service = new Service1Client();
            problemlist = service.SelectAllProblemsSameSchoolh(housekeeper);
            lstv.ItemsSource = problemlist;
            //foreach(var x in problemlist)
            //{
            //    cmb.Items.Add(x.Id.ToString());
            //}

        }
        private void frame_Navigating(object sender, NavigatingCancelEventArgs e)  // לא חובה. נותן שליטה בקוד במצב של דפדוף
        {
            if (Frame != null && Frame.Content != null && // if Self-Navigation 
                Frame.Content.GetType() == e.Content.GetType())
            {
                e.Cancel = true;   //cancal navigation
            }
        }
        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Login());
            housekeeper = null;
        }
        private void frame_Navigated(object sender, NavigationEventArgs e)  // לא חובה. נותן שליטה בקןד במצב של דפדוף
        {

            // נחליט איזה אופציות בתפריט יוצגו/ יוסתרו
            //if (User != null)
            //    this.menu.Visibility = Visibility.Visible;

            //if (User != null)
            //    this.MenuGrid.Visibility = Visibility.Visible;  // display my-menu Buttons
            //else
            //    this.MenuGrid.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (cmb.SelectedItem != null)
            //{
            //    Problems p = problemlist.Find(item => (int)cmb.SelectedItem == item.Id);
            //    p.Issolved = true;
            //    service.UpdateProblem(p);
            //}
            //else
            //{

            //}
            if (clr1.SelectedDate != null)
            {
                p = lstv.SelectedItem as Problems;
                p.SolvingTime = clr1.SelectedDate.Value;
                service.UpdateProblem(p);
                clr1.Visibility = Visibility.Hidden;
                updatebt.Visibility = Visibility.Hidden;
                cancel.Visibility = Visibility.Hidden;
                button10.Visibility = Visibility.Visible;
                button11.Visibility = Visibility.Visible;

            }
            else
            {
                MessageBox.Show ("pls select valid date");
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            p = lstv.SelectedItem as Problems;
            p.Issolved = true;
            service.UpdateProblem(p);

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            p = lstv.SelectedItem as Problems;
            clr1.Visibility = Visibility.Visible;
            updatebt.Visibility = Visibility.Visible;
            cancel.Visibility = Visibility.Visible;
            button10.Visibility = Visibility.Hidden;
            button11.Visibility = Visibility.Hidden;
            button15.Visibility = Visibility.Hidden;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            clr1.Visibility = Visibility.Hidden;
            updatebt.Visibility = Visibility.Hidden;
            cancel.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Visible;
            button11.Visibility = Visibility.Visible;
            button15.Visibility = Visibility.Visible;
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new InsertTool());
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Classlst());

        }
    }
}
