using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace ViewModel
{
   public class SchoolDB:BaseEntityDB
    {
        static private SchoolList list = new SchoolList();


        public SchoolDB()
        {

        }

        public SchoolList SelectAll()
        {
            command.CommandText = $"SELECT * FROM school";
            SchoolList schoolList = new SchoolList();
            try
            {
                this.command.Connection = this.connection;
                this.connection.Open();
                this.reader = this.command.ExecuteReader();
                School c;
                while (reader.Read())
                {
                    c = new School();
                    c.Id = (int)reader["id"];
                    c.SchoolName = reader["schoolname"].ToString();

                    list.Add(c);
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
            return list;
        }


        public  static School SelectById(int id)
        {
            if (list.Count == 0)
            {
                SchoolDB db = new SchoolDB();
                list = db.SelectAll();
            }
            School school = list.Find(item => item.Id == id);
            return school;
        }

        public override BaseEntity NewEntity()
        {
            return new School();
        }

        protected override string CreateInsertSQL(BaseEntity entity)
        {
            School c = entity as School;
            string str = $"Insert into school (schoolname) Values ('{c.SchoolName}') ";
            return str;
        }

        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            School c = entity as School;
            string str = $"Update school set schoolname='{c.SchoolName}' where id= {c.Id}";
            return str;
        }

        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            School c = entity as School;
            string str = $"Delete From school Where schoolname= '{c.SchoolName}' ";
            return str;
        }
        public override void Insert(BaseEntity entity)
        {
            School c = entity as School;
            if (c != null)
            {
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, c));
            }
        }

        public override void Update(BaseEntity entity)
        {
            School c = entity as School;
            if (c != null)
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, c));
        }

        public override void Delete(BaseEntity entity)
        {
            School c = entity as School;
            if (c != null)
                deleted.Add(new ChangeEntity(this.CreateDeleteSQL, c));
        }
    }
}
