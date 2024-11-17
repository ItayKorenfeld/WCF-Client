using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
  public  class StudentDB:PersonDB
    {
        static private StudentList list = new StudentList();

        public StudentDB() : base() { }
        public override BaseEntity CreateModel(BaseEntity entity)
        {
            Student student = entity as Student;
            base.CreateModel(student);
            int classs = (int)reader["classid"];
            student.Classs = ClassDB.SelectById(classs);
            return student;
        }
        public override BaseEntity NewEntity()
        {
            return new Student();
        }
        public StudentList SelectAll()
        {
            this.command.CommandText = $"SELECT person.id as id, person.firstName, person.lastName, person.password1, person.phoneNumber, person.realid, person.schoolid , student.classid  FROM (person INNER JOIN student ON person.id = student.id)";
            
          list = new StudentList(base.Select());
            return list;

        }
        public static Student SelectById(int id)
        {
            if (list.Count == 0)
            {
                StudentDB db = new StudentDB();
                list = db.SelectAll();
            }
            Student student = list.Find(item => item.Id == id);
            return student;
        }
        protected override string CreateInsertSQL(BaseEntity entity)
        {
            Student s = entity as Student;
            string sqlStr = $"INSERT INTO student (id, classid) VALUES ({s.Id},{s.Classs.Id})";
            return sqlStr;
        }
        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            Student s = entity as Student;
            string sqlStr = $"UPDATE student SET  classid= '{s.Classs.Id}' Where id={s.Id} ";

            return sqlStr;
        }
        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            Student student = entity as Student;
            string sqlStr = $"Delete From student Where id={student.Id}";
            return sqlStr;
        }
        public override void Insert(BaseEntity entity)
        {
            Student s = entity as Student;
            if (s != null)
            {
                inserted.Add(new ChangeEntity(base.CreateInsertSQL, s));
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, s));
            }
        }
        public override void Update(BaseEntity entity)
        {
            Student s = entity as Student;
            if (s != null)
            {
                updated.Add(new ChangeEntity(base.CreateUpdateSQL, s));
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, s));
            }

        }
        public override void Delete(BaseEntity entity)
        {
            Student s = entity as Student;
            if (s != null)
            {
                deleted.Add(new ChangeEntity(base.CreateDeleteSQL, s));
                deleted.Add(new ChangeEntity(this.CreateDeleteSQL, s));

            }
        }
    }
}
