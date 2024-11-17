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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public static Frame Frame;  // במשתנה בדף, אם נרצה לגשת אליו ישירות מתוך דפים אחרים.  Frame-נשמור את ה
                                    // .מתוך דף זה, ישירות פשוט ע"י שימוש בשמו , Frame-אחרת, ניתן לגשת ישירות ל


        public static Student student;
         // לא חובה

        //public static Student student   // לא חובה
        //{
        //    get
        //    {
        //        return student;
        //    }

        //    set
        //    {
        //        student = value;
        //    }
        //}

        public MainPage()
        {
            InitializeComponent();
            txtb1.Text = "Hi " + MainPage.student.FirstName + " " + MainPage.student.LastName;
            //Frame = this.frame;  // .במשתנה Frame-צריך רק אם שמרנו את ה
        }



        private void frame_Navigating(object sender, NavigatingCancelEventArgs e)  // לא חובה. נותן שליטה בקוד במצב של דפדוף
        {
            if (Frame != null && Frame.Content != null && // if Self-Navigation 
                Frame.Content.GetType() == e.Content.GetType())
            {
                e.Cancel = true;   //cancal navigation
            }
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
       

        private void Button5_Copy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new StudentProblemsList());

        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new ReportList());
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Login());
            MainPage.student = null;
        }

        private void cp_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            byte Red = 0;
            byte Green = 0;
            byte Blue = 0;
            if (cp.SelectedColor.HasValue)
            {
                Color C = cp.SelectedColor.Value;
                Red = C.R;
                 Green = C.G;
                 Blue = C.B;

            }
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(Red, Green, Blue));
            txtb1.Foreground = brush;
            txtb2.Foreground = brush;

        }

       
    }
}
