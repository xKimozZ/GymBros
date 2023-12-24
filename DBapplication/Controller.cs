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
        public DataTable getAllMembers()
        {
            string query = @"
        SELECT Users.User_ID, Users.Fname, Users.Lname,
               CASE WHEN Users.Gender = 1 THEN 'Male' ELSE 'Female' END AS Gender,
               Users.Age, Users.Contact_Info, Users.Emrgncy_Contact,
               Members.Renewal_Date
        FROM Users
        JOIN Members ON Users.User_ID = Members.Member_ID;";

            return dbMan.ExecuteReader(query);
        }

        public DataTable getAllStaff()
        {
            string query = @"
        SELECT Users.User_ID, Users.Fname, Users.Lname,
               CASE WHEN Users.Gender = 1 THEN 'Male' ELSE 'Female' END AS Gender,
               Users.Age, Users.Contact_Info, Users.Emrgncy_Contact,
               Staff.Role
        FROM Users
        JOIN Staff ON Users.User_ID = Staff.Staff_ID;";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMemberInformation(int memberId)
        {
            string query = $@"
        SELECT Users.User_ID, Users.Fname, Users.Lname,
               CASE WHEN Users.Gender = 1 THEN 'Male' ELSE 'Female' END AS Gender,
               Users.Age, Users.Contact_Info, Users.Emrgncy_Contact,
               Members.Renewal_Date
        FROM Users
        JOIN Members ON Users.User_ID = Members.Member_ID
        WHERE Users.User_ID = {memberId}";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetStaffInformation(int staffId)
        {
            string query = $@"
        SELECT Users.User_ID, Users.Fname, Users.Lname,
               CASE WHEN Users.Gender = 1 THEN 'Male' ELSE 'Female' END AS Gender,
               Users.Age, Users.Contact_Info, Users.Emrgncy_Contact,
               Staff.Role
        FROM Users
        JOIN Staff ON Users.User_ID = Staff.Staff_ID
        WHERE Users.User_ID = {staffId}";

            return dbMan.ExecuteReader(query);
        }

        public int AddOrUpdateBodyComposition(int memberId, int height, int weight, float musclePercentage, float bodyFatPercentage, string bodyType, string chronicDisease)
        {
            // Check if a body composition record already exists for the member
            string checkQuery = $"SELECT COUNT(*) FROM Body_Composition WHERE Member_ID = {memberId}";
            object existingRecordCountObj = dbMan.ExecuteScalar(checkQuery);

            if (existingRecordCountObj != null && int.TryParse(existingRecordCountObj.ToString(), out int existingRecordCount) && existingRecordCount > 0)
            {
                // Update the existing record
                string updateQuery = $@"
            UPDATE Body_Composition
            SET Height = {height},
                Weight = {weight},
                Muscle_Prcntg = {musclePercentage},
                BodyFat_Prcntg = {bodyFatPercentage},
                Body_Type = '{bodyType}',
                Chronic_Disease = '{chronicDisease}'
            WHERE Member_ID = {memberId}";

                return dbMan.ExecuteNonQuery(updateQuery);
            }
            else
            {
                // Insert a new record
                string insertQuery = $@"
            INSERT INTO Body_Composition (Member_ID, Height, Weight, Muscle_Prcntg, BodyFat_Prcntg, Body_Type, Chronic_Disease)
            VALUES ({memberId}, {height}, {weight}, {musclePercentage}, {bodyFatPercentage}, '{bodyType}', '{chronicDisease}')";

                return dbMan.ExecuteNonQuery(insertQuery);
            }
        }

        public int UpdateSessionCheckInStatus(int sessionId)
        {
            string updateQuery = $@"
                                    UPDATE PT_Session
                                    SET Did_Attend = 1
                                    WHERE Session_ID = {sessionId}";

            return dbMan.ExecuteNonQuery(updateQuery);

        }

        public DataTable GetStaffAttendance(int staffId)
        {
            string query = $@"
                SELECT PT_Session.Date ,Users.Fname + ' ' + Users.Lname AS MemberName, PT_Session.Did_Attend
                FROM PT_Session
                JOIN Members ON PT_Session.Member_ID = Members.Member_ID
                JOIN Users ON Members.Member_ID = Users.User_ID
                WHERE PT_Session.Staff_ID = {staffId}";
               
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
        public int AddPrivateSession(int memberId, int staffId, DateTime sessionDate, bool didAttend)
        {
            string query = $@"
            INSERT INTO PT_Session (Date, Member_ID, Staff_ID, Did_Attend)
            VALUES ('{sessionDate.ToString("yyyy-MM-dd")}', {memberId}, {staffId}, {(didAttend ? 1 : 0)})";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdatePrivateSession(int sessionId, DateTime sessionDate, bool didAttend)
        {
            string query = $@"
            UPDATE PT_Session
            SET Date = '{sessionDate.ToString("yyyy-MM-dd")}',
         
            Did_Attend = {(didAttend ? 1 : 0)}
            WHERE Session_ID = {sessionId}";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetSessionsByStaff(int staffId)
        {
            string query = $@"
            SELECT Session_ID, Date, Member_ID, Did_Attend
            FROM PT_Session
            WHERE Staff_ID = {staffId}";

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

        public int AddMember(string Fname , string Lname , string pass,int age, int contactInfo , int emergencyContact, int gender)
        {
            string userInsertQuery = $"INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) " +
                            $"VALUES ('{Fname}', '{Lname}', {gender}, {age}, '{pass}', {emergencyContact}, {contactInfo});";

            string memberInsertQuery = $"INSERT INTO Members (Member_ID, Renewal_Date) " +
                                       $"VALUES (SCOPE_IDENTITY(),  DATEADD(MONTH, 1, GETDATE()));";

            dbMan.ExecuteNonQuery(userInsertQuery);
            return dbMan.ExecuteNonQuery(memberInsertQuery);
        }
        public int AddStaff(string Fname, string Lname, string pass, int age, int contactInfo, int emergencyContact, int gender, string Role)
        {
            string userInsertQuery = $"INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) " +
                            $"VALUES ('{Fname}', '{Lname}', {gender}, {age}, '{pass}', {emergencyContact}, {contactInfo});";

            string StaffInsertQuery = $"INSERT INTO Staff (Staff_ID, Role) " +
                                       $"VALUES (SCOPE_IDENTITY(), '{Role}');";

        
            dbMan.ExecuteNonQuery(userInsertQuery);
            return dbMan.ExecuteNonQuery(StaffInsertQuery);
        }
        public int UpdateUser(int userId, string newFname, string newLname, string newPass, int newAge, int newContactInfo, int newEmergencyContact, int newGender)
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
        //public int UpdateStaffSalary(int staffId, int Salary)
        //{
        //    string staffUpdateQuery = $"UPDATE Staff " +
        //                              $"SET Salary = '{Salary}' " +
        //                              $"WHERE Staff_ID = {staffId};";

        //    return dbMan.ExecuteNonQuery(staffUpdateQuery);
        //}
        public int DeleteUser(int userid)
        {
            string staffUpdateQuery = $"Delete Users " +
                                      $"WHERE User_ID = {userid};";

            return dbMan.ExecuteNonQuery(staffUpdateQuery);
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
