using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.OleDb;



namespace ViewModel
{
    public delegate string CreateSql(BaseEntity entity);
    public abstract class BaseEntityDB
    {
        protected static string connectionString= @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path() + "\\housekeeper_final.accdb;";
        protected OleDbConnection connection;
        protected OleDbCommand command;
        protected OleDbDataReader reader;
        protected List<ChangeEntity> inserted = new List<ChangeEntity>();
        protected List<ChangeEntity> deleted = new List<ChangeEntity>();
        protected List<ChangeEntity> updated = new List<ChangeEntity>();

        protected abstract string CreateInsertSQL(BaseEntity entity);
        protected abstract string CreateUpdateSQL(BaseEntity entity);
        protected abstract string CreateDeleteSQL(BaseEntity entity);

        public virtual void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if(entity != null && entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, entity));
            }
        }
        public virtual void Update(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, entity));
            }
        }
        public virtual void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeleteSQL, entity));
            }
        }



        protected static string Path()
        {
            //string s = Environment.CurrentDirectory;
            String[] arguments = Environment.GetCommandLineArgs();
            string s;
            if (arguments.Length == 1)
            {
                s = arguments[0];
            }
            else
            {
                s = arguments[1];
                s = s.Replace("/service:", "");
            }
            string[] ss = s.Split('\\');

            int x = ss.Length - 5;
             ss[x + 1] = "ViewModel";
            Array.Resize(ref ss, x + 2);

            string str = String.Join("\\", ss);
            return str;
        }
        public abstract BaseEntity NewEntity();
        public BaseEntityDB()
        {
            if (connectionString == null)
            {
                connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path() + "\\housekeeper_final.accdb;";
            }
            connection = new OleDbConnection(connectionString);
            command = new OleDbCommand();
            command.Connection = connection;
        }
        public virtual BaseEntity CreateModel(BaseEntity entity)
        {
            entity.Id = (int)reader["ID"];
            return entity;
        }
        public List<BaseEntity> Select()
        {
            List<BaseEntity> list = new List<BaseEntity>();
            try
            {
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BaseEntity entity = NewEntity();
                    list.Add(CreateModel(entity));
                }

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + "\nSQL:" + command.CommandText);

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
        public int SaveChanges()
        {
            OleDbCommand cmd = new OleDbCommand();
            int records_affected = 0;

            try
            {
                cmd.Connection = this.connection;
                this.connection.Open();
                foreach(var item in inserted)
                {
                    cmd.CommandText = item.CreateSql(item.Entity);
                    records_affected += cmd.ExecuteNonQuery();
                    cmd.CommandText = "Select @@Identity";
                    item.Entity.Id = (int)cmd.ExecuteScalar();
                }
                foreach (var item in updated)
                {
                    cmd.CommandText = item.CreateSql(item.Entity);
                    records_affected += cmd.ExecuteNonQuery();
                    
                }
                foreach (var item in deleted)
                {
                    cmd.CommandText = item.CreateSql(item.Entity);
                    records_affected += cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message + "\nSQL :" + command.CommandText);

            }
            finally
            {
                inserted.Clear();
                updated.Clear();
                deleted.Clear();
            }
            return records_affected;
        }

    }
}
