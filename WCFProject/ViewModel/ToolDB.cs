using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
   public class ToolDB: BaseEntityDB
    {
        static private ToolList list = new ToolList();


        public ToolDB()
        {

        }

        public ToolList SelectAll()
        {
            command.CommandText = $"SELECT * FROM tools";
            ToolList toolsList = new ToolList();
            try
            {
                this.command.Connection = this.connection;
                this.connection.Open();
                this.reader = this.command.ExecuteReader();
                Tools c;
                
                while (reader.Read())
                {
                    c = new Tools();
                    c.Id = (int)reader["id"];
                    int toolname=  (int)reader["toolnamecode"];
                    c.ToolName = ToolNameDB.SelectById(toolname);
                    int classid = (int)reader["classid"];
                    c.Classs = ClassDB.SelectById(classid);

                    toolsList.Add(c);
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
            return toolsList;
        }


        public static Tools SelectById(int id)
        {
            list.Clear();
            if (list.Count == 0)
            {
                ToolDB db = new ToolDB();
                list = db.SelectAll();
            }
            Tools tools = list.Find(item => item.Id == id);
            return tools;
        }

        public override BaseEntity NewEntity()
        {
            return new Tools();
        }

        protected override string CreateInsertSQL(BaseEntity entity)
        {
            Tools c = entity as Tools;
            string str = $"Insert into tools (toolnamecode, classid) Values ('{c.ToolName.Id}', {c.Classs.Id}) ";
            return str;
        }

        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            Tools c = entity as Tools;
            string str = $"Update tools set toolnamecode='{c.ToolName}', classid={c.Classs.Id} where id= {c.Id}";
            return str;
        }

        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            Tools c = entity as Tools;
            string str = $"Delete From tools Where id= {c.Id} ";
            return str;
        }
        public override void Insert(BaseEntity entity)
        {
            Tools c = entity as Tools;
            if (c != null)
            {
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, c));
            }
        }

        public override void Update(BaseEntity entity)
        {
            Tools c = entity as Tools;
            if (c != null)
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, c));
        }

        public override void Delete(BaseEntity entity)
        {
            Tools c = entity as Tools;
            if (c != null)
                deleted.Add(new ChangeEntity(this.CreateDeleteSQL, c));
        }
    }
}
