using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;
using ViewModel;




namespace WcfServiceLibrary
{
   
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        public StudentList SelectAllStudents()
        {
            StudentList cList;
            StudentDB cDB = new StudentDB();
            cList = cDB.SelectAll();
            return cList;
        }

        public int InsertAClass(string classname, int schoolid)
        {
           
            ClassDB cDB = new ClassDB();
            cDB.Insert(new Class() { ClassName = classname, School = SchoolDB.SelectById(schoolid) });
            return cDB.SaveChanges();
        }

        public int UpdateStudent(Student c)
        {
            StudentDB cDB = new StudentDB();
            cDB.Update(c);
            return cDB.SaveChanges();
        }

        public HouseKeeperList SelectAllHousekeepers()
        {
            HouseKeeperList cList;
            HouseKeeperDB cDB = new HouseKeeperDB();
            cList = cDB.SelectAll();
            return cList;
        }

        public ToolList SelectAllTools()
        {
            ToolList cList;
            ToolDB cDB = new ToolDB();
            cList = cDB.SelectAll();
            return cList;
        }
        public ToolNameList SelectAllToolName()
        {
            ToolNameList cList;
            ToolNameDB cDB = new ToolNameDB();
            cList = cDB.SelectAll();
            return cList;
        }

        public ProblemsList SelectAllProblems()
        {
            ProblemsList cList;
            ProblemsDB cDB = new ProblemsDB();
            cList = cDB.SelectAll();
            return cList;
        }

        public SchoolList SelectAllSchools()
        {
            SchoolList cList;
            SchoolDB cDB = new SchoolDB();
            cList = cDB.SelectAll();
            return cList;
        }

        public ClassList SelectAllClass()
        {
            ClassList cList=new ClassList();
            ClassDB cDB = new ClassDB();
            cList = cDB.SelectAll();
            
            return cList;
        }

        public int InsertAStudent(string password, string firstName, string lastName, int schoolid, string realid, string phonenumber, int classid)
        {
            
            StudentDB cDB = new StudentDB();
            StudentList c = cDB.SelectAll();
            Student s = c.Find(item => item.PhoneNumber == phonenumber);
            if (s != null)
            {
               
                return 10;
            }
            Student k = c.Find(item => item.Realid == realid);
            if (k != null)
            {
                
                return 11;
            }
            cDB.Insert(new Student() { Password=password , FirstName=firstName, LastName=lastName, School= SchoolDB.SelectById(schoolid) , Realid=realid, Classs=ClassDB.SelectById(classid) , PhoneNumber=phonenumber });
           

            return cDB.SaveChanges();
        }

        public int InsertAHouseKeeper(string password, string firstName, string lastName, int schoolid, string realid, string phonenumber, DateTime joinDate)
        {
            HouseKeeperDB cDB = new HouseKeeperDB();
            HouseKeeperList c = cDB.SelectAll();
            HouseKeeper s = c.Find(item => item.PhoneNumber == phonenumber);
            if (s != null)
            {
               
                return 10;
            }
            s = c.Find(item => item.Realid == realid);
            if (s != null)
            {
                
                return 11;
            }
            cDB.Insert(new HouseKeeper() { Password = password, FirstName = firstName, LastName = lastName, School = SchoolDB.SelectById(schoolid), Realid = realid,JoinDate=joinDate , PhoneNumber = phonenumber });
           
            return cDB.SaveChanges();
        }

        public int InsertAProblem(int classid, int toolid, string description, int studentid, DateTime solvingTime, bool issolved)
        {
            ProblemsDB cDB = new ProblemsDB();
            cDB.Insert(new Problems() { Classs = ClassDB.SelectById(classid), Student=StudentDB.SelectById(studentid), Description=description, Tools=ToolDB.SelectById((toolid)), SolvingTime=solvingTime, Issolved=issolved });
            return cDB.SaveChanges();
        }

        public int InsertASchool(string schoolName)
        {
            SchoolDB cDB = new SchoolDB();
            cDB.Insert(new School() { SchoolName=schoolName });
            return cDB.SaveChanges();
        }

        public int InsertAToolName(string toolName)
        {
            ToolNameDB cDB = new ToolNameDB();
            cDB.Insert(new ToolName() { ToolName1=toolName });
            return cDB.SaveChanges();
        }

        public int InsertATool(int toolNamecode, int classid)
        {
            ToolDB cDB = new ToolDB();
            cDB.Insert(new Tools() { ToolName=ToolNameDB.SelectById(toolNamecode) , Classs=ClassDB.SelectById(classid) });
            return cDB.SaveChanges();
        }

        public int UpdateHouseKeeper(HouseKeeper c)
        {
            HouseKeeperDB cDB = new HouseKeeperDB();
            cDB.Update(c);
            return cDB.SaveChanges();
        }

        public int UpdateProblem(Problems c)
        {
            ProblemsDB cDB = new ProblemsDB();
            cDB.Update(c);
            return cDB.SaveChanges();
        }

        public int UpdateClass(Class c)
        {
            ClassDB cDB = new ClassDB();
            cDB.Update(c);
            return cDB.SaveChanges();
        }

        public int UpdateSchool(School c)
        {
            SchoolDB cDB = new SchoolDB();
            cDB.Update(c);
            return cDB.SaveChanges();
        }

        public int UpdateToolName(ToolName c)
        {
            ToolNameDB cDB = new ToolNameDB();
            cDB.Update(c);
            return cDB.SaveChanges();
        }

        public int UpdateTool(Tools c)
        {
            ToolDB cDB = new ToolDB();
            cDB.Update(c);
            return cDB.SaveChanges();
        }

        public int DeleteStudent(Student c)
        {
            StudentDB cDB = new StudentDB();
            cDB.Delete(c);
            return cDB.SaveChanges();
        }

        public int DeleteHouseKeeper(HouseKeeper c)
        {
            HouseKeeperDB cDB = new HouseKeeperDB();
            cDB.Delete(c);
            return cDB.SaveChanges();
        }

        public int DeleteProblem(Problems c)
        {
            ProblemsDB cDB = new ProblemsDB();
            cDB.Delete(c);
            return cDB.SaveChanges();
        }

        public int DeleteClass(Class c)
        {
            ClassDB cDB = new ClassDB();
            cDB.Delete(c);
            return cDB.SaveChanges();
        }

        public int DeleteSchool(School c)
        {
            SchoolDB cDB = new SchoolDB();
            cDB.Delete(c);
            return cDB.SaveChanges();
        }

        public int DeleteToolName(ToolName c)
        {
            ToolNameDB cDB = new ToolNameDB();
            cDB.Delete(c);
            return cDB.SaveChanges();
        }

        public int DeleteTool(Tools c)
        {
            ToolDB cDB = new ToolDB();
            cDB.Delete(c);
            return cDB.SaveChanges();
        }

        public Student Login(string phonenumber, string password)
        {
            StudentList cList;
            StudentDB cDB = new StudentDB();
            cList = cDB.SelectAll();
            Student s =   cList.Find(item => item.PhoneNumber == phonenumber && item.Password == password);
            return s;
        }

        public HouseKeeper Login1(string phonenumber, string password)
        {
            HouseKeeperList cList;
            HouseKeeperDB cDB = new HouseKeeperDB();
            cList = cDB.SelectAll();
            HouseKeeper s = cList.Find(item => item.PhoneNumber == phonenumber && item.Password == password);
            return s;
        }
        public ProblemsList SelectAllProblemsSameSchoolh(HouseKeeper h)
        {
            ProblemsList cList;
            ProblemsList c2List=new ProblemsList();

            ProblemsDB cDB = new ProblemsDB();
            cList = cDB.SelectAll();
           
            foreach(var x in cList)
            {
                if (x.Classs.School.Id == h.School.Id)
                {
                    c2List.Add(x);
                }
            }
            return c2List;
        }
        public ProblemsList SelectAllProblemsSameSchools(Student s)
        {
            ProblemsList cList;
            ProblemsList c2List = new ProblemsList();

            ProblemsDB cDB = new ProblemsDB();
            cList = cDB.SelectAll();

            foreach (var x in cList)
            {
                if (x.Classs.School.Id == s.School.Id)
                {
                    c2List.Add(x);
                }
            }
            return c2List;
        }
       public Class SelectclassByID(int id)
        {
            ClassList list = new ClassList();
            if (list.Count == 0)
            {
                ClassDB db = new ClassDB();
                list = db.SelectAll();
            }
            Class classs = list.Find(item => item.Id == id);
            return classs;
        }
        public ProblemsList SelectProblemsFilter(string command)
        {
            ProblemsList pList;
            ProblemsDB cDB = new ProblemsDB();
            pList = cDB.SelectFilter(command);
            return pList;

        }

    }
}
