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
    /// Interaction logic for InsertTool.xaml
    /// </summary>
    public partial class InsertTool : Page
    {
        Service1Client service;
        ClassList c4;
        ToolNameList t4;

        public InsertTool()
        {
            InitializeComponent();
            service = new Service1Client();
            ClassList c2 = new ClassList();
            ClassList c3 = new ClassList();
            ToolNameList t1 = new ToolNameList();
            c2 = service.SelectAllClass();
            c4 = new ClassList();
            
            t1 = service.SelectAllToolName();
            t4 = new ToolNameList();
            t4 = t1;


            foreach (var x in c2)
            {
                if (x.School.Id == HouseKeeperPage.housekeeper.School.Id)
                {
                    c3.Add(x);
                }
            }
            c4 = c3;

            foreach (var y in c3)
            {
                cmb2.Items.Add(y.ClassName.ToString());


            }
            foreach(var x in t1)
            {
                cmb1.Items.Add(x.ToolName1.ToString());
            }
        }

       



        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new HouseKeeperPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string cname = cmb1.SelectedItem.ToString();
            ToolName t = t4.Find(item => item.ToolName1 == cname);
            string tname = cmb2.SelectedItem.ToString();
            Class c = c4.Find(item => item.ClassName == tname);

            
           


            int n = 0;
            ToolList t3 = new ToolList();
            ToolList t5 = new ToolList();
            t3 = service.SelectAllTools();
            foreach(var x in t3)
            {
                if (x.Classs.School.Id == HouseKeeperPage.housekeeper.School.Id)
                {
                    t5.Add(x);
                }
            }
            Tools t6 = t5.Find(item => item.ToolName.ToolName1 == cname && item.Classs.ClassName == tname);
            n = service.InsertATool(t.Id, c.Id);
            if (t6 != null)
                n = -1;


            if (n == 0)
            {
                MessageBox.Show("שגיאה בהוספה");
            }
            else if (n == -1)
            {
                MessageBox.Show("פריט כבר קיים");
            }
            //else if (c1.School.Id != MainPage.student.School.Id)
            //{
            //    textBlock.Visibility = Visibility.Visible;
            //    textBlock.Text = "עליך להזין כיתה הנמצאת בבית הספר שלך";
            //}


            else
            {
                //    textBlock.Visibility = Visibility.Hidden;  //  מיותר


                MessageBox.Show("הוסף בהצלחה");
                cmb1.SelectedItem = null;
                cmb2.SelectedItem = null;



            }
        }
    }
}
