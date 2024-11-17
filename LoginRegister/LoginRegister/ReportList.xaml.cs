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
using System.Threading;

namespace LoginRegister
{
    /// <summary>
    /// Interaction logic for ReportList.xaml
    /// </summary>
    public partial class ReportList : Page
    {
        Service1Client service;
        Class c1;
        ClassList c4;
        ToolList t4;
       

        public ReportList()
        {
            
            InitializeComponent();
            
            service = new Service1Client();
            ClassList c2 = new ClassList();
            ClassList c3 = new ClassList();
            c2 = service.SelectAllClass();
            //ToolList t1 = new ToolList();
            //ToolList t2 = new ToolList();
            //t1 = service.SelectAllTools();

            foreach (var x in c2)
            {
                if (x.School.Id == MainPage.student.School.Id)
                {
                    c3.Add(x);
                }
            }
            c4 = new ClassList();
            c4 = c3;
            foreach (var y in c3)
            {
                cmb1.Items.Add(y.ClassName.ToString());
                
              
            }
           
            //if (cmb1.SelectedItem != null)
            //{
            //    string cname = cmb1.SelectedItem.ToString();
            //    Class c = c4.Find(item => item.ClassName == cname);

            //    foreach (var x in t1)
            //    {
            //        if (x.Classs.Id == c.Id)
            //        {
            //            t2.Add(x);
            //        }
            //    }
            //    t4 = new ToolList();
            //    t4 = t2;
            //    foreach (var x in t2)
            //    {
            //        cmb2.Items.Add(x.ToolName.ToolName1.ToString());
            //    }
            //}

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            try { 
            string cname = cmb1.SelectedItem.ToString();
            Class c = c4.Find(item => item.ClassName == cname);

            string tname = cmb2.SelectedItem.ToString();
            Tools t= t4.Find(item => item.ToolName.ToolName1 == tname);


            int n = 0;
            
                n = service.InsertAProblem(c.Id, t.Id, textBox2.Text, MainPage.student.Id, new DateTime(), false);
                //c1 = service.SelectclassByID(Convert.ToInt32(textBox.Text));
                if (n == 0)
                {
                    textBlock.Visibility = Visibility.Visible;
                    textBlock.Text = "שגיאה בדיווח";
                }
                //else if (c1.School.Id != MainPage.student.School.Id)
                //{
                //    textBlock.Visibility = Visibility.Visible;
                //    textBlock.Text = "עליך להזין כיתה הנמצאת בבית הספר שלך";
                //}
                


                else
                {
                    //    textBlock.Visibility = Visibility.Hidden;  //  מיותר


                    textBlock.Visibility = Visibility.Visible;
                    textBlock.Text = "דווח בהצלחה";

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter Valid Fields");
            }
        }
       


        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new MainPage());
        }

       

        private void Cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if (cmb1.SelectedItem != null)
            {
                cmb2.Items.Clear();
                string cname = cmb1.SelectedItem.ToString();
                Class c = c4.Find(item => item.ClassName == cname);
                ToolList t1 = new ToolList();
                ToolList t2 = new ToolList();
                t1 = service.SelectAllTools();
                foreach (var x in t1)
                {
                    if (x.Classs.Id == c.Id)
                    {
                        t2.Add(x);
                    }
                }
                t4 = new ToolList();
                t4 = t2;
                foreach (var x in t4)
                {
                    cmb2.Items.Add(x.ToolName.ToolName1.ToString());
                }
            }
        }
    }
}
