using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site1.ServiceReference1;

namespace Site1
{
    
    public partial class StudentPa : System.Web.UI.Page 
    {
        Service1Client service;
        public ProblemsList clist = null;
       public string n = MainPage.student.FirstName + " " + MainPage.student.LastName;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            service = new Service1Client();
            clist = service.SelectAllProblems();
            if (!IsPostBack)
            {
                CGridView2.DataSource = clist;
                CGridView2.DataBind();

            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
            Session.Abandon();
        }
    }
}