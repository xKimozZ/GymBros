﻿using System;
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

        public int LoginAttempt(int UID, string pass)
        {
            string query = $"SELECT User_ID FROM Users WHERE User_ID = '{UID}' AND Account_Pass = '{pass}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public string LoginStaff(int UID)
        {
            string query = $"SELECT Role FROM Staff WHERE Staff_ID = '{UID}';";
            return dbMan.ExecuteScalar(query).ToString();
        }
        public int LoginMember(int UID)
        {
            string query = $"Select Count(*) FROM Members WHERE Member_ID = '{UID}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DataTable getMemberData(int UID)
        {
            string query = $"SELECT Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact" +
                $", Contact_Info  FROM Users WHERE User_ID = {UID};";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateComp(int userId, int height, int weight, float fat, float muscle, string type,string chronic)
        {

            string userUpdateQuery = $"UPDATE Body_Composition " +
                                     $"SET Height = {height}, Weight = {weight}, Muscle_Prcntg = {muscle}, BodyFat_Prcntg = {fat}, " +
                                     $"Body_Type = '{type}', Chronic_Disease = '{chronic}' " +
                                     $"WHERE Member_ID = {userId};";

            return dbMan.ExecuteNonQuery(userUpdateQuery);
        }

        public int InsertComp(int userId, int height, int weight, float fat, float muscle, string type, string chronic)
        {

            string userUpdateQuery = $"INSERT into Body_Composition " +
                                     $"(Member_ID, Height, Weight, BodyFat_Prcntg, Muscle_Prcntg, Body_Type, Chronic_disease) " +
                                     $"Values ({userId},{height},{weight},{fat},{muscle},'{type}','{chronic}')";

            return dbMan.ExecuteNonQuery(userUpdateQuery);
        }

        public int CheckCompExist(int UID)
        {
            string query = $"SELECT Member_ID FROM Body_Composition WHERE Member_ID = '{UID}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DataTable getBodyComp(int UID)
        {
            string query = $"SELECT Height, Weight, BodyFat_Prcntg, Muscle_Prcntg, Body_Type, Chronic_Disease" +
                $" FROM Body_Composition WHERE Member_ID = {UID};";
            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


    }
}
