using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Model;


namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        StudentList SelectAllStudents();
        [OperationContract]
        HouseKeeperList SelectAllHousekeepers();
        [OperationContract]
        ToolList SelectAllTools();
        [OperationContract]
        ProblemsList SelectAllProblems();
        [OperationContract]
        SchoolList SelectAllSchools();
        [OperationContract]
        ClassList SelectAllClass();

        [OperationContract]
        int InsertAClass(string className, int schoolid);
        [OperationContract]
        int InsertAStudent(string password ,string firstName, string lastName , int schoolid, string realid, string phonenumber, int classid);
        [OperationContract]
        int InsertAHouseKeeper(string password, string firstName, string lastName, int schoolid, string realid, string phonenumber, DateTime joinDate);
        [OperationContract]
        int InsertAProblem( int classid, int toolid, string description, int studentid ,DateTime solvingTime , bool issolved);
        [OperationContract]
        int InsertASchool(string schoolName);
        [OperationContract]
        int InsertAToolName(string toolName);
        [OperationContract]
        int InsertATool(int toolNamecode, int classid);
        [OperationContract]
        int UpdateStudent(Student c);
        [OperationContract]
        int UpdateHouseKeeper(HouseKeeper c);
        [OperationContract]
        int UpdateProblem(Problems c);
        [OperationContract]
        int UpdateClass(Class c);
        [OperationContract]
        int UpdateSchool(School c);
        [OperationContract]
        int UpdateToolName(ToolName c);
        [OperationContract]
        int UpdateTool(Tools c);
        [OperationContract]
        int DeleteStudent(Student c);
        [OperationContract]
        int DeleteHouseKeeper(HouseKeeper c);
        [OperationContract]
        int DeleteProblem(Problems c);
        [OperationContract]
        int DeleteClass(Class c);
        [OperationContract]
        int DeleteSchool(School c);
        [OperationContract]
        int DeleteToolName(ToolName c);
        [OperationContract]
        int DeleteTool(Tools c);
        [OperationContract]
        Student Login(string phonenumber, string password);
        [OperationContract]
        HouseKeeper Login1(string phonenumber, string password);
        [OperationContract]
        ProblemsList SelectAllProblemsSameSchoolh(HouseKeeper h);
        [OperationContract]
        ProblemsList SelectAllProblemsSameSchools(Student s);
        [OperationContract]
        Class SelectclassByID(int id);
        [OperationContract]
        ToolNameList SelectAllToolName();
        [OperationContract]
        ProblemsList SelectProblemsFilter(string command);

    }

    
    
}
