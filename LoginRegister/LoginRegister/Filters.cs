using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginRegister.ServiceReference1;

namespace LoginRegister
{
   public class Filters:Problems
    {
        bool? Issolved1;

        public bool? Issolved11 { get => Issolved1; set => Issolved1 = value; }

        public string BuildFilter()
        {

            string sql = $"SELECT report.id as id, report.classid, report.toolid, report.description, report.studentid, problems.solvingtime , problems.issolved FROM(report INNER JOIN problems ON report.id = problems.id) where"; 
            bool was = false;
            if (this.Issolved1 != null)
            {
                sql += $" (((problems.issolved)={this.Issolved11})) ";
                was = true;
            }
            if (this.Tools != null)
            {
                if (was)
                    sql += $" and (((report.toolid)={this.Tools.Id})) ";
                else
                {
                    sql += $" (((report.toolid) ={ this.Tools.Id})) ";
                    was = true;
                }
            }

            if (this.Classs != null)
            {
                if (was)
                    sql += $" and (((report.classid)={this.Classs.Id})) ";
                else
                {
                    sql += $" (((report.classid)={this.Classs.Id})) ";
                    was = true;
                }
            }

            if (this.Issolved1 == null && this.Tools == null && this.Classs == null)
            {
                return null;
            }
            return sql;

        }

    }
    }

