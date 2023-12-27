using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

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

        public DataTable GetSessionsForMember(int memberId)
        {
            string query = $@"
            SELECT Session_ID, Date, Did_Attend
            FROM PT_Session
            WHERE Member_ID = {memberId}";

            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSessionsByMemberAndStaff(int memberId, int staffId)
        {
            string query = $@"
        SELECT Session_ID, Date, Did_Attend
        FROM PT_Session
        WHERE Member_ID = {memberId} AND Staff_ID = {staffId}";

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
        // stored 
        public int AddOrUpdateBodyComposition(int memberId, int height, int weight, float musclePercentage, float bodyFatPercentage, string bodyType, string chronicDisease)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@MemberId", memberId);
            parameters.Add("@Height", height);
            parameters.Add("@Weight", weight);
            parameters.Add("@MusclePercentage", musclePercentage);
            parameters.Add("@BodyFatPercentage", bodyFatPercentage);
            parameters.Add("@BodyType", bodyType);
            parameters.Add("@ChronicDisease", chronicDisease);

            return dbMan.ExecuteNonQueryStored("AddOrUpdateBodyCompositionProcedure", parameters);
        }

        // stored 
        public int UpdateSessionCheckInStatus(int sessionId, int memberId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sessionId", sessionId);
            parameters.Add("@memberId", memberId);

            return dbMan.ExecuteNonQueryStored("UpdateSessionCheckInStatusProcedure", parameters);
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
        //stored
        public int AddPrivateSession(int memberId, int staffId, DateTime sessionDate, bool didAttend)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@MemberId", memberId);
            parameters.Add("@StaffId", staffId);
            parameters.Add("@SessionDate", sessionDate);
            parameters.Add("@DidAttend", didAttend);

            return dbMan.ExecuteNonQueryStored("AddPrivateSessionProcedure", parameters);
        }
        //stored
        public int UpdatePrivateSession(int sessionId, DateTime sessionDate, bool didAttend,int memberId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@sessionId", sessionId);
            parameters.Add("@memberId", memberId);
            parameters.Add("@sessionDate", sessionDate);
            parameters.Add("@didAttend", didAttend);

            return dbMan.ExecuteNonQueryStored("UpdatePrivateSessionProcedure", parameters);
        }

        //stored
        public DataTable GetSessionsByStaff(int staffId)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StaffId", staffId);

            return dbMan.ExecuteReaderStored("GetSessionsByStaffProcedure", parameters);
        }

        //stored
        public DataTable GetStaffAnnouncements()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReaderStored("GetStaffAnnouncementsProcedure" , parameters);
        }

        //stored
        public int SendAnnouncement(int senderId, string messageText)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@SenderId", senderId);
            parameters.Add("@MessageText", messageText);

            return dbMan.ExecuteNonQueryStored("SendAnnouncementProcedure", parameters);
        }

        //stored
        public int AddMember(string Fname, string Lname, string pass, int age, int contactInfo, int emergencyContact, int gender)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Fname", Fname);
            parameters.Add("@Lname", Lname);
            parameters.Add("@Pass", pass);
            parameters.Add("@Age", age);
            parameters.Add("@ContactInfo", contactInfo);
            parameters.Add("@EmergencyContact", emergencyContact);
            parameters.Add("@Gender", gender);

            return dbMan.ExecuteNonQueryStored("AddMemberProcedure", parameters);
        }
        //stored
        public int AddStaff(string Fname, string Lname, string pass, int age, int contactInfo, int emergencyContact, int gender, string Role)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Fname", Fname);
            parameters.Add("@Lname", Lname);
            parameters.Add("@Pass", pass);
            parameters.Add("@Age", age);
            parameters.Add("@ContactInfo", contactInfo);
            parameters.Add("@EmergencyContact", emergencyContact);
            parameters.Add("@Gender", gender);
            parameters.Add("@Role", Role);

            return dbMan.ExecuteNonQueryStored("AddStaffProcedure", parameters);
        }
        //stored
        public int UpdateUser(int userId, string newFname, string newLname, string newPass, int newAge, int newContactInfo, int newEmergencyContact, int newGender)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@UserId", userId);
            parameters.Add("@NewFname", newFname);
            parameters.Add("@NewLname", newLname);
            parameters.Add("@NewPass", newPass);
            parameters.Add("@NewAge", newAge);
            parameters.Add("@NewContactInfo", newContactInfo);
            parameters.Add("@NewEmergencyContact", newEmergencyContact);
            parameters.Add("@NewGender", newGender);

            return dbMan.ExecuteNonQueryStored("UpdateUserProcedure", parameters);
        }
        public int UpdateStaffRole(int staffId, string newRole)
        {
            string staffUpdateQuery = $"UPDATE Staff " +
                                      $"SET Role = '{newRole}' " +
                                      $"WHERE Staff_ID = {staffId};";

            return dbMan.ExecuteNonQuery(staffUpdateQuery);
        }
 
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
        public string GetRoleByStaffId(int staffId)
        {
            string roleQuery = $"SELECT Role FROM Staff WHERE Staff_ID = {staffId}";
            object result = dbMan.ExecuteScalar(roleQuery);

            // Check if the result is not null and return the role as a string
            return result != null ? result.ToString() : "Role Not Found"; // You can use any default value you prefer
        }
        public int InsertStaffTransaction(int staffId, string transactionType)
        {
            string insertQuery = $"INSERT INTO Staff_Trans (Staff_ID, Transaction_Type, Transaction_Date) VALUES ({staffId}, '{transactionType}', GETDATE())";
            return dbMan.ExecuteNonQuery(insertQuery);
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

        public string FnameUser(int UID)
        {
            string query = $"Select Fname FROM Users WHERE User_ID = '{UID}';";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public DataTable getMemberData(int UID)
        {
            string query = $"SELECT Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact" +
                $", Contact_Info  FROM Users WHERE User_ID = {UID};";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateComp(int userId, int height, int weight, float fat, float muscle, string type, string chronic)
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
