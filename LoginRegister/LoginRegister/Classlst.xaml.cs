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
    /// Interaction logic for Classlst.xaml
    /// </summary>
    public partial class Classlst : Page
    {
        Service1Client service;
        public Classlst()
        {
            
            InitializeComponent();
            service = new Service1Client();
            ClassList lst2 = Sameschoolclass();
            ColumnDefinition gridCol;
            for (int i = 0; i < lst2.Count / 2 + 1; i++)
            {
                gridCol = new ColumnDefinition();
                gridCol.Width = new GridLength(120);
                g.ColumnDefinitions.Add(gridCol);
            }
            RowDefinition gridRow;
            //gridRow = new RowDefinition();
            //gridRow.Height = new GridLength(40);
            //g.RowDefinitions.Add(gridRow);
            for (int i = 0; i < 2; i++)
            {
                gridRow = new RowDefinition();
                gridRow.Height = new GridLength(160);
                g.RowDefinitions.Add(gridRow);
            }
           
            //gridRow = new RowDefinition();
            //gridRow.Height = new GridLength(40);
            //g.RowDefinitions.Add(gridRow);
            //TextBlock t = new TextBlock();
            //t.Text = "Class List";
            //t.TextAlignment = TextAlignment.Center;
            //t.HorizontalAlignment = HorizontalAlignment.Center;
            //t.FontSize = 30;
            //Thickness margin = t.Margin;
            //margin.Left = 100;
            //t.Margin = margin;
            //Grid.SetColumnSpan(t, 2);
            //t.Foreground = new SolidColorBrush(Color.FromRgb(151, 155, 237));
           //Button button1 = new Button();
           // Grid.SetRow(button1, 3);
           // Grid.SetColumn(button1, 0);
           // button1.Width = 75;
           // button1.Height = 50;
           // button1.Content = "back";
           // button1.Click += button1_Click;
           // button1.Background = new SolidColorBrush(Color.FromRgb(151, 155, 237));
           // g.Children.Add(button1);
            //Grid.SetRow(t, 0);
            //Grid.SetColumn(t, 0);
            //g.Children.Add(t);
            int k = 0, j = 0;
            foreach (Class b in lst2)
            {
                StudentsUC tUC = new StudentsUC(b);
                tUC.Margin = new Thickness(10);
                Grid.SetRow(tUC, k);
                Grid.SetColumn(tUC, j);
                j++;
                if (j == lst2.Count / 2 + 1)
                {
                    k++; j = 0;
                }


                g.Children.Add(tUC);
            }
        }

        public ClassList Sameschoolclass()
        {
            ClassList lst = service.SelectAllClass();
            ClassList lst1 = new ClassList();
            foreach(var x in lst)
            {
                if (x.School.Id == HouseKeeperPage.housekeeper.School.Id)
                {
                    lst1.Add(x);
                }
            }
            return lst1;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new HouseKeeperPage());
        }
    }
}
