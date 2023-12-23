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

        public DataTable GetStaffAnnouncements()
        {
            string query = @"
        SELECT Announcements.Message_Text, Staff.Staff_ID, Users.Fname + ' ' + Users.Lname AS SenderName, Staff.Role, Announcements.Message_Date
        FROM Announcements
        JOIN Staff ON Announcements.Sender_ID = Staff.Staff_ID
        JOIN Users ON Announcements.Sender_ID = Users.User_ID";

            return dbMan.ExecuteReader(query);
        }

        public int SendAnnouncement(int senderId, string messageText)
        {
            string query = $@"
            INSERT INTO Announcements (Message_Date, Message_Text, Sender_ID)
            VALUES (GETDATE(), '{messageText}', {senderId});";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getNamesStaff()
        {
            string query = $"SELECT User_ID, Fname FROM Users INNER JOIN Staff ON Users.User_ID = Staff.Staff_ID;";
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

        public int UpdateUser(int userId, string newFname, string newLname, string newPass, int newAge, int newContactInfo, int newEmergencyContact, int newGender)
        {
           
            string userUpdateQuery = $"UPDATE Users " +
                                     $"SET Fname = '{newFname}', Lname = '{newLname}', Gender = {newGender}, Age = {newAge}, " +
                                     $"Account_Pass = '{newPass}', Emrgncy_Contact = {newEmergencyContact}, Contact_Info = {newContactInfo} " +
                                     $"WHERE User_ID = {userId};";

            return dbMan.ExecuteNonQuery(userUpdateQuery);
        }

        public DataTable GetStaffOwnTransactions(string date1, string date2, int id)
        {
            string query;
            if (date1 == "")
            {
                query = $"SELECT FR.Transaction_Type AS Type, FR.Transaction_Amount AS Amount, " +
                        $"ST.Transaction_Date AS Date " +
                        $"FROM Financial_Records AS FR, Staff_Trans AS ST " +
                        $"WHERE ST.Transaction_Date <= '{date2}' AND " +
                        $"ST.Staff_ID = {id} AND FR.Transaction_Type = ST.Transaction_Type;";
            }
            else if (date2 == "")
            {
                query = $"SELECT FR.Transaction_Type AS Type, FR.Transaction_Amount AS Amount, " +
                    $"ST.Transaction_Date AS Date " +
                    $"FROM Financial_Records AS FR, Staff_Trans AS ST " +
                    $"WHERE ST.Transaction_Date >= '{date1}' AND " +
                    $"ST.Staff_ID = {id} AND FR.Transaction_Type = ST.Transaction_Type;";
            }
            else
            {
                query = $"SELECT FR.Transaction_Type AS Type, FR.Transaction_Amount AS Amount, " +
                    $"ST.Transaction_Date AS Date " +
                    $"FROM Financial_Records AS FR, Staff_Trans AS ST " +
                    $"WHERE ST.Transaction_Date >= '{date1}' AND ST.Transaction_Date <= '{date2}' AND " +
                    $"ST.Staff_ID = {id} AND FR.Transaction_Type = ST.Transaction_Type;";
            }

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMemberTransactions(string date1, string date2, int id)
        {
            string query;
            if (date1 == "")
            {
                query = $"SELECT FR.Transaction_Type AS Type, FR.Transaction_Amount AS Amount, " +
                        $"MT.Transaction_Date AS Date " +
                        $"FROM Financial_Records AS FR, Mem_Trans AS MT " +
                        $"WHERE MT.Transaction_Date <= '{date2}' AND " +
                        $"MT.Member_ID = {id} AND FR.Transaction_Type = MT.Transaction_Type;";
            }
            else if (date2 == "")
            {
                query = $"SELECT FR.Transaction_Type AS Type, FR.Transaction_Amount AS Amount, " +
                        $"MT.Transaction_Date AS Date " +
                        $"FROM Financial_Records AS FR, Mem_Trans AS MT " +
                        $"WHERE MT.Transaction_Date >= '{date1}' AND " +
                        $"MT.Member_ID = {id} AND FR.Transaction_Type = MT.Transaction_Type;";
            }
            else
            {
                query = $"SELECT FR.Transaction_Type AS Type, FR.Transaction_Amount AS Amount, " +
                    $"MT.Transaction_Date AS Date " +
                    $"FROM Financial_Records AS FR, Mem_Trans AS MT " +
                    $"WHERE MT.Transaction_Date >= '{date1}' AND MT.Transaction_Date <= '{date2}' AND " +
                    $"MT.Member_ID = {id} AND FR.Transaction_Type = MT.Transaction_Type;";
            }

            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


    }
}
