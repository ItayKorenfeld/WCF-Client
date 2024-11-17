using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class ProblemsDB:ReportDB
    {
        public ProblemsDB() : base() { }

        public override BaseEntity CreateModel(BaseEntity entity)
        {
            Problems problems = entity as Problems;
            base.CreateModel(problems);
            problems.SolvingTime = (DateTime)reader["solvingtime"];
            problems.Issolved = (bool)reader["issolved"];
            return problems;
        }
        public override BaseEntity NewEntity()
        {
            return new Problems();
        }
        public ProblemsList SelectAll()
        {
            this.command.CommandText = $"SELECT report.id as id, report.classid, report.toolid, report.description, report.studentid, problems.solvingtime , problems.issolved  FROM (report INNER JOIN problems ON report.id = problems.id)";

            ProblemsList list = new ProblemsList(base.Select());
            return list;

        }
        public ProblemsList SelectFilter(string command)
        {
            this.command.CommandText = command;

            ProblemsList list = new ProblemsList(base.Select());
            return list;

        }
        protected override string CreateInsertSQL(BaseEntity entity)
        {
            Problems p = entity as Problems;
            string sqlStr = $"Insert INTO problems (id, solvingtime,issolved) VALUES ({p.Id}, #{p.SolvingTime}#, {p.Issolved})";
            return sqlStr;
        }
       
        protected override string CreateUpdateSQL(BaseEntity entity)
        {
            Problems p = entity as Problems;
            string sqlStr = $"Update problems set solvingtime= #{p.SolvingTime}# , issolved={p.Issolved} Where id={p.Id}";
            return sqlStr;
        }
        protected override string CreateDeleteSQL(BaseEntity entity)
        {
            Problems p = entity as Problems;
            string sqlStr = $"Delete From problems Where id={p.Id}";
            return sqlStr;
        }
        public override void Insert(BaseEntity entity)
        {
            Problems p = entity as Problems;
            if (p != null)
            {
                inserted.Add(new ChangeEntity(base.CreateInsertSQL, p));
                inserted.Add(new ChangeEntity(this.CreateInsertSQL, p));
            }
        }
        public override void Update(BaseEntity entity)
        {
            Problems p = entity as Problems;
            if (p != null)
            {
                updated.Add(new ChangeEntity(base.CreateUpdateSQL, p));
                updated.Add(new ChangeEntity(this.CreateUpdateSQL, p));

            }

        }
        public override void Delete(BaseEntity entity)
        {
            Problems p = entity as Problems;
            if (p != null)
            {
                deleted.Add(new ChangeEntity(base.CreateDeleteSQL, p));
                deleted.Add(new ChangeEntity(this.CreateDeleteSQL, p));
            }
        }
    }
}
