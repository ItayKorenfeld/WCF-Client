using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class HouseKeeperDB:PersonDB
    {
        public HouseKeeperDB() : base() { }
        public override BaseEntity CreateModel(BaseEntity entity)
        {
            HouseKeeper housekeeper = entity as HouseKeeper;
            base.CreateModel(housekeeper);
            housekeeper.JoinDate = (DateTime)reader["joindate"];
            
            
            return housekeeper;
        
    }
       
        public override BaseEntity NewEntity()
        {
            return new HouseKeeper();
        }
        public HouseKeeperList SelectAll()
        {
            this.command.CommandText = $"SELECT person.id as id, person.firstName, person.lastName, person.password1, person.phoneNumber, person.realid, person.schoolid , housekeeper.joindate  FROM (person INNER JOIN housekeeper ON person.id = housekeeper.id)";

            HouseKeeperList housekeeperlist = new HouseKeeperList(base.Select());
            return housekeeperlist;

        }
        protected override string CreateInsertSQL(BaseEntity entity)
        {
            HouseKeeper h = entity as HouseKeeper;
            string sqlStr = $"INSERT INTO housekeeper (id, joindate) VALUES ({h.Id}, #{h.JoinDate}#)";
            return sqlStr;
        }
        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            HouseKeeper h = entity as HouseKeeper;
            string sqlStr = $"Delete From housekeeper Where id={h.Id}";
            return sqlStr;
        }
        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            HouseKeeper s = entity as HouseKeeper;
            string sqlStr = $"UPDATE housekeeper SET  joindate= #{s.JoinDate}# Where id={s.Id} ";

            return sqlStr;
        }
        public override void Insert(BaseEntity entity)
        {
            HouseKeeper h = entity as HouseKeeper;
            if (h != null)
            {
                inserted.Add(new ChangeEntity(base.CreateInsertSQL, h));
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, h));
            }
        }
        public override void Update(BaseEntity entity)
        {
            HouseKeeper h = entity as HouseKeeper;
            if (h != null)
            {
                updated.Add(new ChangeEntity(base.CreateUpdateSQL, h));

                updated.Add(new ChangeEntity(this.CreateUpdateSQL, h));
            }

        }
        public override void Delete(BaseEntity entity)
        {
            HouseKeeper h = entity as HouseKeeper;
            if (h != null)
            {
                deleted.Add(new ChangeEntity(base.CreateDeleteSQL, h));
                deleted.Add(new ChangeEntity(this.CreateDeleteSQL, h));

            }
        }
    }
}
