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
    /// Interaction logic for StudentProblemsList.xaml
    /// </summary>
    public partial class StudentProblemsList : Page
    {
        private List<ServiceReference1.Problems> problemlist = new List<ServiceReference1.Problems>();

        Service1Client service;

        
        Class c1;
        ClassList c4;
        ToolList t4;


        

            

         
           




            public StudentProblemsList()
        {

            InitializeComponent();
            service = new Service1Client();
            problemlist = service.SelectAllProblemsSameSchools(MainPage.student);
            lstv.ItemsSource = problemlist;

            //RowDefinition gridRow;
            //for (int i = 0; i < problemlist.Count; i++)
            //{
            //    gridRow = new RowDefinition();
            //    gridRow.Height = new GridLength(100);
            //    g.RowDefinitions.Add(gridRow);
            //}
            //int j = 0;
            //foreach(ServiceReference1.Problems p in problemlist)
            //{
            //    ProblemsUC puc = new ProblemsUC(p);
            //    Grid.SetRow(puc, j);
            //    j++;
            //    g.Children.Add(puc);
            //}
            ClassList c2 = new ClassList();
            ClassList c3 = new ClassList();
            c2 = service.SelectAllClass();
           
            t4 = service.SelectAllTools();

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
            ToolNameList t5 = service.SelectAllToolName();
            foreach (var x in t5)
            {
                cmb2.Items.Add(x.ToolName1);


            }

        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new MainPage());
        }

        private void Rb1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Rb2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Cmb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (cmb1.SelectedItem != null)
            //{
            //    cmb2.Items.Clear();
            //    string cname = cmb1.SelectedItem.ToString();
            //    Class c = c4.Find(item => item.ClassName == cname);
            //    ToolList t1 = new ToolList();
            //    ToolList t2 = new ToolList();
            //    t1 = service.SelectAllTools();
            //    foreach (var x in t1)
            //    {
            //        if (x.Classs.Id == c.Id)
            //        {
            //            t2.Add(x);
            //        }
            //    }
            //    t4 = new ToolList();
            //    t4 = t2;
            //    foreach (var x in t4)
            //    {
            //        cmb2.Items.Add(x.ToolName.ToolName1.ToString());
            //    }
            //}

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            

                


                bool? isso = null;
            if (this.rb1.IsChecked == true)
                isso = true;
            else if (this.rb2.IsChecked == true)
                isso = false;

            Class cl = null;
                if (this.cmb1.SelectedItem != null)
            {
                string cname = cmb1.SelectedItem.ToString();
                cl = c4.Find(item => item.ClassName == cname);
            }
            Tools tl = null;
            if (this.cmb2.SelectedItem != null)
            {
                string tname = cmb2.SelectedItem.ToString();
                tl = t4.Find(item => item.ToolName.ToolName1 == tname);
            }






            string sqlSentence = new Filters() {Issolved11=isso, Tools=tl, Classs=cl }.BuildFilter();
            ProblemsList pl = service.SelectProblemsFilter(sqlSentence);


            if (pl != null)
            {
               
                ProblemsList c2List = new ProblemsList();

               

                foreach (var x in pl)
                {
                    if (x.Classs.School.Id == MainPage.student.School.Id)
                    {
                        c2List.Add(x);
                    }
                }
                lstv.ItemsSource = c2List;
            }
                





        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            problemlist = service.SelectAllProblemsSameSchools(MainPage.student);
            lstv.ItemsSource = problemlist;
            cmb1.SelectedItem = null;
            cmb2.SelectedItem = null;
            rb1.IsChecked = false;
            rb2.IsChecked = false;


        }
    }
}
