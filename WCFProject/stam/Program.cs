using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using Model;

namespace stam
{
    class Program
    {
        static void Main(string[] args)
        {
            //StudentDB p = new StudentDB();
            //StudentList x = p.SelectAll();
            //foreach (var k in x)
            //    Console.WriteLine(k.Classs.ClassName);
            //ProblemsDB t = new ProblemsDB();
            //Problems p = new Problems();
            //ProblemsList y = t.SelectAll();
            //foreach(var k in y)
            //   Console.WriteLine(k.Student.FirstName);
            //HouseKeeperDB h = new HouseKeeperDB();
            //HouseKeeperList x = h.SelectAll();
            //foreach (var k in x)
            //    Console.WriteLine(k.FirstName);


            //StudentDB s = new StudentDB();
            //Student t = new Student();
            //t.FirstName = "den";
            //t.LastName = "babybus23123";
            //t.Password = "New5pass";
            //t.PhoneNumber = "324234";
            //t.School = SchoolDB.SelectById(1);
            //t.Realid = "23432";
            //t.Classs = ClassDB.SelectById(1);
            //t.Id = 4;
            ////s.Insert(t);
            ////s.Delete(t);
            //s.Update(t);
            //Console.WriteLine(s.SaveChanges());

            //ProblemsDB p = new ProblemsDB();
            //Problems e = new Problems();
            //e.Description = "sdsds";
            //e.Classs = ClassDB.SelectById(1); ;
            //e.Issolved = true;
            //e.Tools = ToolDB.SelectById(1);
            //e.Student = StudentDB.SelectById(1);
            //e.SolvingTime = new DateTime(2012 , 3 , 2);
            ////e.Id = 4;
            //p.Insert(e);
            ////p.Delete(e);
            //int x = p.SaveChanges();

            //Console.WriteLine(x);
            //HouseKeeperDB p = new HouseKeeperDB();
            //HouseKeeper h = new HouseKeeper();
            //h.FirstName = "den";
            //h.LastName = "babybusxxx";
            //h.Password = "34";
            //h.PhoneNumber = "324234";
            //h.School = SchoolDB.SelectById(1);
            //h.Realid = "23432";
            //h.JoinDate = new DateTime(2012 , 3 , 2);
            ////h.Id = 11;
            //p.Insert(h);
            ////p.Delete(h);
            //Console.WriteLine(p.SaveChanges());
            //   ClassDB c = new ClassDB();
            //   ClassList c1 = c.SelectAll();
            //foreach(var x in c1)
            //   {
            //       Console.WriteLine(x.ClassName.ToString());
            //   }

            ProblemsDB cDB = new ProblemsDB();
            cDB.Insert(new Problems() { Classs = ClassDB.SelectById(11), Student = StudentDB.SelectById(3), Description = "fdf", Tools = ToolDB.SelectById(10), SolvingTime = new DateTime(), Issolved = false });
            int n= cDB.SaveChanges();
            Console.WriteLine( n);


        }
    }
}
