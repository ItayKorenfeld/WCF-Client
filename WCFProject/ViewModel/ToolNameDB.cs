using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class ToolNameDB:BaseEntityDB
    {
        static private ToolNameList list = new ToolNameList();


        public ToolNameDB()
        {

        }

        public ToolNameList SelectAll()
        {
            command.CommandText = $"SELECT * FROM toolname";
            ToolNameList toolNameList = new ToolNameList();
            try
            {
                this.command.Connection = this.connection;
                this.connection.Open();
                this.reader = this.command.ExecuteReader();
                ToolName c;
                while (reader.Read())
                {
                    c = new ToolName();
                    c.Id = (int)reader["id"];
                    c.ToolName1 = reader["toolname"].ToString();

                    toolNameList.Add(c);
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
            return toolNameList;
        }


        public static ToolName SelectById(int id)
        {
            list.Clear();

            if (list.Count == 0)
            {
                ToolNameDB db = new ToolNameDB();
                list = db.SelectAll();
            }
            ToolName toolname = list.Find(item => item.Id == id);
            return toolname;
        }

        public override BaseEntity NewEntity()
        {
            return new ToolName();
        }

        protected override string CreateInsertSQL(BaseEntity entity)
        {
            ToolName c = entity as ToolName;
            string str = $"Insert into toolname (toolname) Values ('{c.ToolName1}') ";
            return str;
        }

        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            ToolName c = entity as ToolName;
            string str = $"Update toolname set toolname='{c.ToolName1}' where id= {c.Id}";
            return str;
        }

        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            ToolName c = entity as ToolName;
            string str = $"Delete From toolname Where id= {c.Id} ";
            return str;
        }
        public override void Insert(BaseEntity entity)
        {
            ToolName c = entity as ToolName;
            if (c != null)
            {
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, c));
            }
        }

        public override void Update(BaseEntity entity)
        {
            ToolName c = entity as ToolName;
            if (c != null)
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, c));
        }

        public override void Delete(BaseEntity entity)
        {
            ToolName c = entity as ToolName;
            if (c != null)
                deleted.Add(new ChangeEntity(this.CreateDeleteSQL, c));
        }
    }
}
