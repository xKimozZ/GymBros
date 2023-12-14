using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

//Project stuff
        public int InsertUser(string Fname, string Lname, bool gender, int Age, string pass, int emergency, int contact)
        {
            string query = "INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info)" +
                            " Values ('" + Fname + "','" + Lname + "','" + gender + "'," + Age + ",'" + pass + "'," + emergency + "," + contact + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        
        public int InsertMember(int ID, int Fees, string date)
        {
            string query = "INSERT INTO Members (Member_ID, Membership_Fees, Renewal_Date)" +
                            "Values (" + ID + "," + Fees + ",'" + date + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable ViewAllMembers()
        {
            string query = "SELECT Member_ID,Renewal_Date,Membership_Fees FROM Members;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewAllUsers()
        {
            string query = "SELECT User_ID,Fname,Lname FROM Users;";
            return dbMan.ExecuteReader(query);
        }

//LAB STUFF, USE AS REFERENCE        
        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }


        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                            "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepartments()
        {
            string query= "SELECT Dnumber,Dname FROM Department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepLoc()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProject(string location)
        {
            string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
             +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 
            
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepartments3()
        {
            string query = "SELECT Dnumber,Dname,Mgr_SSN FROM Department;";
            return dbMan.ExecuteReader(query);
        }

        //Mine

        public DataTable SelectSalaryLess40k()
        {
            string query = "SELECT SSN, Fname FROM Employee WHERE (Salary < 40000 OR Salary IS NULL);";
            return dbMan.ExecuteReader(query);
        }


        public DataTable GetMaxAverageSalary()
        {
            string query = "SELECT MAX(Salary) AS MaxSalary, AVG(Salary) AS AvgSalary FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable CheckDnum(int dnumber)
        {
            string query = "SELECT Dnumber AS Dnum FROM Department WHERE Dnumber = " + dnumber + ";";
            return dbMan.ExecuteReader(query);
        }

       /* public int InsertDepartment(string Dname, int dnumber, int mgrssn)
        {
            //if (date == "")
              //  date = DateTime.Now.ToShortDateString();

            string query = "INSERT INTO Department (Dname, Dnumber, Mgr_SSN)" +
                            "VALUES ('" + Dname + "'," + dnumber + "," + mgrssn + ");";

            //INSERT INTO Department(Dname,Dnumber,Mgr_SSN) VALUES ('kimo',70,123456789);

            return dbMan.ExecuteNonQuery(query);
        }*/

        public int InsertDepartment(string Dname, int dnumber, int mgrssn,string date)
        {
            string query = "INSERT INTO Department (Dname, Dnumber, Mgr_SSN,Mgr_Start_Date)" +
                            "Values ('" + Dname + "'," + dnumber + "," + mgrssn + ",'"+ date +"');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertLocation(int Dnumber, string Dname)
        {
            string query = "INSERT INTO Dept_Locations (Dnumber,Dlocation) "
                + " SELECT "+ Dnumber+ " AS Dnum,'" + Dname +"' AS Dloc "
                + " WHERE NOT EXISTS ( SELECT 1 FROM Dept_Locations WHERE Dnumber= "+ Dnumber +
                " AND Dlocation = '"+ Dname +"');";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepLocAll()
        {
            string query = "SELECT Dnumber,Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployees()
        {
            string query = "SELECT Fname,SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateManager(int Dnumber, int SSN)
        {
            string query = "UPDATE Department SET Mgr_SSN = "+ SSN + " WHERE Dnumber = "+ Dnumber+";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable DepartmentManager()
        {
            string query = "SELECT Employee.Fname AS EmployeeName, Department.Dname AS" +
            " DepartmentName FROM Employee JOIN Department ON Employee.SSN =  Department.Mgr_SSN;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDepLocAll4()
        {
            string query = "SELECT DL.Dnumber, DL.Dlocation, D.Dname FROM Dept_Locations DL JOIN Department D ON DL.Dnumber = D.Dnumber;";
            return dbMan.ExecuteReader(query);
        }
    }
}
