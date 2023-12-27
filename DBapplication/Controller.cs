using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Deployment.Internal;

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
        public DataTable GetStaffByRole(string role)
        {
            string query = $@"
        SELECT *
        FROM Staff
        WHERE Staff.Role = '{role}';";

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
        public int InsertSupplierTransaction(int supplierId, string transactionType)
        {
            string insertQuery = $"INSERT INTO Supplier_Trans (Supplier_ID, Transaction_Type, Transaction_Date) VALUES ({supplierId}, '{transactionType}', GETDATE())";
            return dbMan.ExecuteNonQuery(insertQuery);
        }

        public DataTable getEquimpent()
        {
            string query = $"SELECT Equipment_ID, Model FROM " +
                           $"Equipment;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getStaffRequiredMaintain(DateTime date)
        {
            string query = $"SELECT Equipment_ID, Model FROM " +
                           $"Equipment WHERE '{date}' >= Maintenance_Sched;";
            return dbMan.ExecuteReader(query);
        }

        public DateTime getEquimpentMaintenanceDate(int id)
        {
            string query = $"SELECT Maintenance_Sched FROM " +
                           $"Equipment WHERE Equipment_ID = {id};";
            return DateTime.Parse((dbMan.ExecuteScalar(query)).ToString());
        }
        public int updateEquimpentMaintenanceDate(int id, DateTime newDate)
        {
            string query = $"UPDATE Equipment " +
                                      $"SET Maintenance_Sched = '{newDate:yyyy-MM-dd}' " +
                                      $"WHERE Equipment_ID = {id};";

            return dbMan.ExecuteNonQuery(query);
        }

        public int updateEquimpentStatus(int id, string status)
        {
            string query = $"UPDATE Equipment " +
                                      $"SET Status = '{status}' " +
                                      $"WHERE Equipment_ID = {id};";

            return dbMan.ExecuteNonQuery(query);
        }

        public int generateMaintenanceRequest(int reporter_id, int equip_id, DateTime rqst_date, int dmg, string desc, string status)
        {
            string query = $"INSERT INTO Maintains " +
                $"(Reporter_ID, Equipment_ID, Request_Date, Dmg_Estimate, Request_Description, Status) " +
                $"VALUES ({reporter_id}, {equip_id}, '{rqst_date:yyyy-MM-dd}', {dmg}, '{desc}', '{status}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public string getEquipmentStatus(int id)
        {
            string query = $"SELECT STATUS FROM Equipment " +
                           $"WHERE Equipment_ID = {id};";

            return (dbMan.ExecuteScalar(query)).ToString();
        }
        public DataTable getAttendingClassMembers(string classType)
        {
            string query = $"SELECT DISTINCT U.User_ID, U.Fname FROM Users AS U " +
                $"WHERE U.User_ID IN(" +
                $"SELECT A.Member_ID FROM Attends_Class AS A " +
                $"WHERE Class_Type = '{classType}');";
            return dbMan.ExecuteReader(query);
        }

        public int getNumClassAttendances(int id, string classType)
        {
            string query = $"SELECT Num_Attended_Classes FROM Attends_Class " +
                           $"WHERE Member_ID = {id} AND Class_Type = '{classType}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public int updateNumClassAttendances(int id, int newVal, string classType)
        {
            string query;
            if (id <= -1)
            {
                query = $"UPDATE Attends_Class " +
                            $"SET Num_Attended_Classes = {newVal};";
            }
            else
            {
                query = $"UPDATE Attends_Class " +
                           $"SET Num_Attended_Classes = {newVal} " +
                           $"WHERE Member_ID = {id} AND Class_Type = '{classType}';";
            }


            return dbMan.ExecuteNonQuery(query);
        }

        public int dropClass(int id, string classType)
        {
            string query = $"DELETE FROM Attends_Class " +
                $"WHERE Member_ID = {id} AND Class_Type = '{classType}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int updateClassDateTime(DateTime newDate, TimeSpan newTime, string classType)
        {
            string query = $"UPDATE Classes " +
                           $"SET Date = '{newDate:yyyy-MM-dd}', Time = '{newTime:hh\\:mm}' " +
                           $"WHERE Class_Type = '{classType}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getAllClassAttenders(string class_type)
        {
            string query = $"SELECT * FROM Attends_Class " +
                            $"WHERE Class_Type = '{class_type}';";
            return dbMan.ExecuteReader(query);
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

        public string LnameUser(int UID)
        {
            string query = $"Select Lname FROM Users WHERE User_ID = '{UID}';";
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


        public int InsertClass(string classType, int classMgr, string description, int instructorId, DateTime date, TimeSpan time, string location, int classMaxLimit)
        {
            string classInsertQuery = $"INSERT INTO Classes " +
                                      $"(Class_Type, Class_Mgr, Availability, Description, Instructor_ID, Date, Time, Location, Registered_Num, Class_Max_Limit) " +
                                      $"VALUES " +
                                      $"('{classType}', {classMgr}, 1, '{description}', {instructorId}, '{date:yyyy-MM-dd}', '{time:hh\\:mm}', '{location}', 0, {classMaxLimit});";

            return dbMan.ExecuteNonQuery(classInsertQuery);
        }
        public int InsertExtraService(string serviceName, string description, int serviceMgrId)
        {
            string insertQuery = $@"
        INSERT INTO Extra_Service (Service_Name, Availability, Description, Service_Mgr_ID)
        VALUES
        ('{serviceName}', 1, '{description}', {serviceMgrId});";

            return dbMan.ExecuteNonQuery(insertQuery);
        }


        public int UpdateClass(string classType, int newClassMgr, string newDescription, int newInstructorId, DateTime newDate, TimeSpan newTime, string newLocation, int newClassMaxLimit, bool newAvailability)
        { 
            string classUpdateQuery = $@"
        UPDATE Classes
        SET Class_Mgr = {newClassMgr},
            Description = '{newDescription}',
            Instructor_ID = {newInstructorId},
            Date = '{newDate:yyyy-MM-dd}',
            Time = '{newTime:hh\\:mm}',
            Location = '{newLocation}',
            Class_Max_Limit = {newClassMaxLimit},
            Availability = {(newAvailability ? 1 : 0)}
        WHERE Class_Type = '{classType}';";

            return dbMan.ExecuteNonQuery(classUpdateQuery);
        }
        public int UpdateExtraService(string serviceName, string description, int serviceMgrId, bool availability)
        {
            int availabilityValue = availability ? 1 : 0; // Convert bool to 1 or 0 for the BIT field

            string updateQuery = $@"
        UPDATE Extra_Service
        SET Description = '{description}',
            Service_Mgr_ID = {serviceMgrId},
            Availability = {availabilityValue}
        WHERE Service_Name = '{serviceName}';";

            return dbMan.ExecuteNonQuery(updateQuery);
        }

        public DataTable GetAllClassTypes()
        {
            string query = "SELECT * FROM Classes;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAllServices()
        {
            string query = @"
        SELECT *
        FROM Extra_Service;";

            return dbMan.ExecuteReader(query);
        }
        public int DeleteClass(string classType)
        {
            string deleteQuery = $"DELETE FROM Classes WHERE Class_Type = '{classType}';";
            return dbMan.ExecuteNonQuery(deleteQuery);
        }
        public int DeleteService(string serviceName)
        {
            string deleteQuery = $@"
        DELETE FROM Extra_Service
        WHERE Service_Name = '{serviceName}';";

            return dbMan.ExecuteNonQuery(deleteQuery);
        }

        public DataTable GetPendingMaintenanceRequests()
        {
            string query = @"
        SELECT *
        FROM Maintains
        WHERE Maintains.Status = 'Pending';";

            return dbMan.ExecuteReader(query);
        }
        public int GetDmgEstimateByEquipmentId(int equipmentId)
        {
            string dmgEstimateQuery = $"SELECT Dmg_Estimate FROM Maintains WHERE Equipment_ID = {equipmentId}";
            object result = dbMan.ExecuteScalar(dmgEstimateQuery);

            // Check if the result is not null and return the damage estimate as an integer
            return result != null && int.TryParse(result.ToString(), out int dmgEstimate) ? dmgEstimate : -1; // You can use any default value you prefer
        }
        public int UpdateEquipmentStatus(int equipmentId, string newStatus)
        {
            string updateQuery = $"UPDATE Equipment SET Status = '{newStatus}' WHERE Equipment_ID = {equipmentId};";
            return dbMan.ExecuteNonQuery(updateQuery);
        }
        public int UpdateEquipmentMaintenanceStatus(int equipmentId, string newStatus)
        {
            string updateQuery = $"UPDATE Maintains SET  Status = '{newStatus}' WHERE Equipment_ID = {equipmentId};";
            return dbMan.ExecuteNonQuery(updateQuery);
        }
        public int DeleteMaintainsRecord(int equipmentId)
        {
            string deleteQuery = $"DELETE FROM Maintains WHERE Equipment_ID = {equipmentId};";
            return dbMan.ExecuteNonQuery(deleteQuery);
        }
        public int InsertEquipment(string model, DateTime purchaseDate, int supplierId)
        {
            // Calculate Maintenance_Sched date as one month after the Purchase_Date
            DateTime maintenanceSched = purchaseDate.AddMonths(1);

            string insertQuery = $@"
        INSERT INTO Equipment (Model, Purchase_Date, Maintenance_Sched, Status, Supplier_ID)
        VALUES
        ('{model}', '{purchaseDate:yyyy-MM-dd}', '{maintenanceSched:yyyy-MM-dd}', 'Good', {supplierId});";

            return dbMan.ExecuteNonQuery(insertQuery);
        }
        public DataTable GetAllSuppliers()
        {
            string query = "SELECT * FROM Suppliers;";
            return dbMan.ExecuteReader(query);
        }
        public int GetSupplierIdByEquipmentId(int equipmentId)
        {
            string query = $"SELECT Supplier_ID FROM Equipment WHERE Equipment_ID = {equipmentId}";
            object result = dbMan.ExecuteScalar(query);

            // Check if the result is not null and return the supplier ID as an integer
            return result != null ? Convert.ToInt32(result) : -1; // Return -1 if supplier ID is not found or an error occurs
        }

        public DateTime GetRenewalDate(int UID)
        {
            string query = $"SELECT Renewal_Date FROM Members WHERE Member_ID = '{UID}';";
            return (DateTime)dbMan.ExecuteScalar(query);
        }

        public int TransactionAmount(string type)
        {
            string query = $"Select Transaction_Amount FROM Financial_Records WHERE Transaction_Type = '{type}';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int UpdateRenewalDate(DateTime newdate, int UID)
        {

            string userUpdateQuery = $"UPDATE Members SET Renewal_Date = '{newdate}' WHERE Member_ID = {UID};";

            return dbMan.ExecuteNonQuery(userUpdateQuery);
        }

        public int InsertMemberTransaction(int UID, string transactionType)
        {
            string insertQuery = $"INSERT INTO Mem_Trans (Member_ID, Transaction_Type, Transaction_Date) VALUES ({UID}, '{transactionType}', GETDATE())";
            return dbMan.ExecuteNonQuery(insertQuery);
        }

        public DataTable GetAllClasses()
        {
            string query = "SELECT Class_Type, Class_Mgr, Instructor_ID, Availability, Date, Time, Location " +
                "FROM Classes;";
            return dbMan.ExecuteReader(query);
        }

        public DateTime getDateClass(string classType)
        {
            string query = $"SELECT Date FROM Classes " +
                           $"WHERE Class_Type = '{classType}';";
            return DateTime.Parse((dbMan.ExecuteScalar(query)).ToString());
        }

        public TimeSpan getTimeClass(string classType)
        {
            string query = $"SELECT Time FROM Classes " +
                           $"WHERE Class_Type = '{classType}';";
            return TimeSpan.Parse((dbMan.ExecuteScalar(query)).ToString());
        }

        public DataTable GetAllES()
        {
            string query = "SELECT Service_Name, Service_Mgr_ID, Availability " +
                "FROM Extra_Service;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getAttendingESMembers(string es_type)
        {
            string query = $"SELECT DISTINCT U.User_ID, U.Fname FROM Users AS U " +
                $"WHERE U.User_ID IN(" +
                $"SELECT A.Member_ID FROM Uses_Service AS A " +
                $"WHERE Service_Name = '{es_type}');";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getAllESAttenders(string es_type)
        {
            string query = $"SELECT * FROM Uses_Service " +
                            $"WHERE Service_Name = '{es_type}';";
            return dbMan.ExecuteReader(query);
        }

        public int getNumESAttendances(int id, string service)
        {
            string query = $"SELECT Num_Attended_Sessions FROM Uses_Service " +
                           $"WHERE Member_ID = {id} AND Service_Name = '{service}';";
            return Convert.ToInt32(dbMan.ExecuteScalar(query));
        }

        public DateTime getSubLenES(int id, string service)
        {
            string query = $"SELECT Subscription_Len FROM Uses_Service " +
                           $"WHERE Member_ID = {id} AND Service_Name = '{service}';";
            return DateTime.Parse((dbMan.ExecuteScalar(query)).ToString());
        }

        public int updateNumESAttendances(int id, int newVal, string service)
        {
            string query;
            if (id <= -1)
            {
                query = $"UPDATE Uses_Service " +
                            $"SET Num_Attended_Sessions = {newVal};";
            }
            else
            {
                query = $"UPDATE Uses_Service " +
                           $"SET Num_Attended_Sessions = {newVal} " +
                           $"WHERE Member_ID = {id} AND Service_Name = '{service}';";
            }


            return dbMan.ExecuteNonQuery(query);
        }

        public int dropES(int id, string service)
        {
            string query = $"DELETE FROM Uses_Service " +
                $"WHERE Member_ID = {id} AND Service_Name = '{service}';";
            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
