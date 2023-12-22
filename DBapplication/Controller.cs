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
      public int AddMember(string Fname , string Lname , string pass,int age, int contactInfo , int emergencyContact, int gender)
        {
            string userInsertQuery = $"INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) " +
                            $"VALUES ('{Fname}', '{Lname}', {gender}, {age}, '{pass}', {emergencyContact}, {contactInfo});";

            string memberInsertQuery = $"INSERT INTO Members (Member_ID, Renewal_Date, Membership_Fees) " +
                                       $"VALUES (SCOPE_IDENTITY(), GETDATE(), 500);";

            dbMan.ExecuteNonQuery(userInsertQuery);
            return dbMan.ExecuteNonQuery(memberInsertQuery);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


    }
}
