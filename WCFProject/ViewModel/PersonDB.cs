using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace ViewModel
{
   public abstract class PersonDB:BaseEntityDB
    {
        public PersonDB(): base() { }
        public override BaseEntity CreateModel(BaseEntity entity)
        {
            Person p = entity as Person;
            p.FirstName = reader["firstname"].ToString();
            p.LastName = reader["lastname"].ToString();
            p.Password = reader["password1"].ToString();
            p.PhoneNumber = reader["phonenumber"].ToString();
            p.Realid = reader["realid"].ToString();
            int schoolid = (int)reader["schoolid"];
            p.School = SchoolDB.SelectById(schoolid);
            base.CreateModel(entity);
            return p;

        }
        protected override string CreateInsertSQL(BaseEntity entity)
        {
            Person p = entity as Person;
            string sqlStr = $"Insert into Person (password1, firstname, lastname, schoolid, realid, phonenumber) values (  '{p.Password}' , '{p.FirstName}' , '{p.LastName}' , {p.School.Id}, '{p.Realid}' , '{p.PhoneNumber}' ) ";
            return sqlStr;
        }
        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            Person p = entity as Person;
            string str = $"Delete From Person Where ( firstName='{p.FirstName}' and lastName='{p.LastName}') ";
            return str;
        }
        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            Person s = entity as Person;
            string sqlStr = $"UPDATE person SET  password1= '{s.Password}', firstName='{s.FirstName}' , lastname='{s.LastName}' , schoolid={s.School.Id}, realid='{s.Realid}', phonenumber='{s.PhoneNumber}'  Where id={s.Id} ";
           


            return sqlStr; 
        }
    }
}
