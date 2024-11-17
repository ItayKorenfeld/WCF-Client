using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public abstract class ReportDB:BaseEntityDB
    {
        public ReportDB() : base() { }
        public override BaseEntity CreateModel(BaseEntity entity)
        {
            Report R = entity as Report;
            int classid = (int)reader["classid"];
            R.Classs=  ClassDB.SelectById(classid);
            int toolid = (int)reader["toolid"];
            R.Tools = ToolDB.SelectById(toolid);
            R.Description = reader["description"].ToString();
            int studentid = (int)reader["studentid"];
            R.Student = StudentDB.SelectById(studentid);
           
            base.CreateModel(entity);
            return R;

        }
        protected override string CreateInsertSQL(BaseEntity entity)
        {
            Report R = entity as Report;
            string sqlStr = string.Format("Insert into Report (classid, toolid, description, studentid)" + " values( {0}, {1}, '{2}' , '{3}')", R.Classs.Id, R.Tools.Id, R.Description, R.Student.Id);
            return sqlStr;
        }
        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            Report R = entity as Report;
            string str = $"Delete From report Where  id={R.Id} ";
            return str;
        }
        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            Report s = entity as Report;
            string str = $"UPDATE report SET  classid= {s.Classs.Id}, toolid={s.Tools.Id} , description='{s.Description}' , studentid={s.Student.Id}  Where id={s.Id} ";
            return str;
        }

    }
}
