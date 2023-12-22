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
        public DataTable getAllMembers() {
            string query = $"SELECT * FROM Members;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getAllStaff()
        {
            string query = $"SELECT * FROM Staff;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getNamesMembers()
        {
            string query = $"SELECT User_ID, Fname FROM Users INNER JOIN Members ON Users.User_ID = Members.Member_ID;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getNamesStaff()
        {
            string query = $"SELECT Staff_ID, Lname FROM Users INNER JOIN Staff ON Users.User_ID = Staff.Staff_ID;";
            return dbMan.ExecuteReader(query);
        }
        public int AddMember(string Fname , string Lname , string pass,int age, int contactInfo , int emergencyContact, int gender)
        {
            string userInsertQuery = $"INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) " +
                            $"VALUES ('{Fname}', '{Lname}', {gender}, {age}, '{pass}', {emergencyContact}, {contactInfo});";

            string memberInsertQuery = $"INSERT INTO Members (Member_ID, Renewal_Date, Membership_Fees) " +
                                       $"VALUES (SCOPE_IDENTITY(), GETDATE(), 500);";

            dbMan.ExecuteNonQuery(userInsertQuery);
            return dbMan.ExecuteNonQuery(memberInsertQuery);
        }
        public int AddStaff(string Fname, string Lname, string pass, int age, int contactInfo, int emergencyContact, int gender, int Salary, string Role)
        {
            string userInsertQuery = $"INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) " +
                            $"VALUES ('{Fname}', '{Lname}', {gender}, {age}, '{pass}', {emergencyContact}, {contactInfo});";

            string StaffInsertQuery = $"INSERT INTO Staff (Staff_ID, Salary, Role) " +
                                       $"VALUES (SCOPE_IDENTITY(), {Salary}, '{Role}');";

            dbMan.ExecuteNonQuery(userInsertQuery);
            return dbMan.ExecuteNonQuery(StaffInsertQuery);
        }
        public int UpdateMember(int userId, string newFname, string newLname, string newPass, int newAge, int newContactInfo, int newEmergencyContact, int newGender)
        {
           
            string userUpdateQuery = $"UPDATE Users " +
                                     $"SET Fname = '{newFname}', Lname = '{newLname}', Gender = {newGender}, Age = {newAge}, " +
                                     $"Account_Pass = '{newPass}', Emrgncy_Contact = {newEmergencyContact}, Contact_Info = {newContactInfo} " +
                                     $"WHERE User_ID = {userId};";

            return dbMan.ExecuteNonQuery(userUpdateQuery);
        }

        public int UpdateStaffRole(int staffId, string newRole)
        {
            string staffUpdateQuery = $"UPDATE Staff " +
                                      $"SET Role = '{newRole}' " +
                                      $"WHERE Staff_ID = {staffId};";

            return dbMan.ExecuteNonQuery(staffUpdateQuery);
        }
        public int UpdateStaffSalary(int staffId, int Salary)
        {
            string staffUpdateQuery = $"UPDATE Staff " +
                                      $"SET Salary = '{Salary}' " +
                                      $"WHERE Staff_ID = {staffId};";

            return dbMan.ExecuteNonQuery(staffUpdateQuery);
        }
        public int DeleteStaff(int staffId)
        {
            string staffUpdateQuery = $"Delete Staff " +
                                      $"WHERE Staff_ID = {staffId};";

            return dbMan.ExecuteNonQuery(staffUpdateQuery);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
