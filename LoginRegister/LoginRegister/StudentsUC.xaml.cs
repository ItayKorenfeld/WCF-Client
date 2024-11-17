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
    /// Interaction logic for StudentsUC.xaml
    /// </summary>
    public partial class StudentsUC : UserControl
    {
        Class c;
        

        Service1Client service;
        public StudentsUC(Class cl)
        {
            InitializeComponent();
            service = new Service1Client();
            this.c = new Class();
            c = cl;
            ClassName.Content = cl.ClassName;
        }
        public int ProblemCounter(Class ct)
        {
            int count = 0;
            ProblemsList ls = new ProblemsList();
            ls = service.SelectAllProblems();
            foreach (var x in ls)
            {
                if (x.Classs.Id == ct.Id && x.Issolved==false)
                    count++;

            }
            return count;
        }

        private void MyClass_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MyClass.ToolTip =" active problem in this class :" + ProblemCounter(this.c) ;
            this.amountprob.Visibility = Visibility.Visible; 
        }

        private void MyClass_MouseLeave(object sender, MouseEventArgs e)
        {
            this.MyClass.ToolTip = "";
            this.amountprob.Visibility = Visibility.Hidden;
        }
    }
}
