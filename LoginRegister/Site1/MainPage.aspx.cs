using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site1.ServiceReference1;
using LoginRegister;



namespace Site1
{
    public partial class MainPage : System.Web.UI.Page
    {
        Service1Client service;
       public static Student student=new Student();

        protected void Page_Load(object sender, EventArgs e)
        {
            service = new Service1Client();
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
           MainPage.student = service.Login(String.Format("{0}", Request.Form["uname"]), String.Format("{0}", Request.Form["psw"]));
            string n = student.FirstName + " " + student.LastName;
            if (student != null) {
                Response.Redirect("StudentPa.aspx");
            }
            else
            {
                Label1.Visible = true;
            }

        }
         
    }
}