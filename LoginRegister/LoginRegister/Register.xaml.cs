﻿using System;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        Service1Client service;
        
        public Register()
        {
            InitializeComponent();
            service = new Service1Client();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            try
            {
               
                n = service.InsertAStudent(passwordBox.Password, this.textBox.Text, this.textBox1.Text, Convert.ToInt32(this.textBox4.Text), this.textBox3.Text, this.textBox2.Text, Convert.ToInt32(this.textBox5.Text));
            }
            catch
            {
                MessageBox.Show("Please Enter Valid fields");
            }
            if (n == 0)
            {
                MessageBox.Show("שגיאה בהרשמה");
                //textBlock.Visibility = Visibility.Visible;
                //textBlock.Text = "שגיאה בהרשמה";
            }
            else if(n==10)
            {
                MessageBox.Show("מספר טלפון כבר קיים");
                //textBlock.Visibility = Visibility.Visible;
                //textBlock.Text = "מספר טלפון כבר קיים";
            }
            else if (n == 11)
            {
                MessageBox.Show("מספר תז כבר קיים");
                //textBlock.Visibility = Visibility.Visible;
                //textBlock.Text = "מספר תז כבר קיים";
            }

            else
            {
                //    textBlock.Visibility = Visibility.Hidden;  //  מיותר


                NavigationService nav = NavigationService.GetNavigationService(this);
                nav.Navigate(new Login());
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)  // fill the correct UName & Password
        {
            this.textBox.Text = "kuku";
            this.passwordBox.Password = "kuku";
        }


        private void button4_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new LoginOrRegister());
        }
    }
}
