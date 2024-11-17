using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class ClassDB : BaseEntityDB
    {
        static private ClassList list = new ClassList();


        public ClassDB()
        {

        }

        public ClassList SelectAll()
        {
            command.CommandText = $"SELECT * FROM class";
            ClassList classList = new ClassList();
            try
            {
                this.command.Connection = this.connection;
                this.connection.Open();
                this.reader = this.command.ExecuteReader();
                Class c;
                while (reader.Read())
                {
                    c = new Class();
                    c.Id = (int)reader["id"];
                    c.ClassName = reader["classname"].ToString();
                    int schoolid = (int)reader["schoolid"];
                    c.School = SchoolDB.SelectById(schoolid);

                    classList.Add(c);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return classList;
        }


        public static Class SelectById(int id)
        {
            if (list.Count == 0)
            {
                ClassDB db = new ClassDB();
                list = db.SelectAll();
            }
            Class classs = list.Find(item => item.Id == id);
            return classs;
        }

        public override BaseEntity NewEntity()
        {
            return new Class();
        }
        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            Class c = entity as Class;
            string str = $"Delete From class Where classname= '{c.ClassName}' ";
            return str;
        }
        protected override string CreateInsertSQL(BaseEntity entity)
        {
            Class c = entity as Class;
            string str = $"Insert into class (classname, schoolid) Values ('{c.ClassName}', {c.School.Id}) ";
            return str;
        }
        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            Class c = entity as Class;
            string str = $"Update class set classname='{c.ClassName}', schoolid={c.School.Id} where id= {c.Id}";
            return str;
        }
        public override void Insert(BaseEntity entity)
        {
            Class c = entity as Class;
            if (c != null)
            {
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, c));
            }
        }

        public override void Update(BaseEntity entity)
        {
            Class c = entity as Class;
            if (c != null)
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, c));
        }

        public override void Delete(BaseEntity entity)
        {
            Class c = entity as Class;
            if (c != null)
                deleted.Add(new ChangeEntity(this.CreateDeleteSQL, c));
        }

    }
}
