using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class DBManager
    {
        // KAREEM:
        //static string DB_Connection_String = @"Data Source=.\SQLEXPRESS;Initial Catalog=GymBrosDB;Integrated Security=True";
        // GALAL:
        //static string DB_Connection_String = @"Data Source=.\SQLEXPRESS;Initial Catalog=GymBrosDB;Integrated Security=True";
        // HUSSEIN:
        //
        // EZZ:
        //Data Source=DESKTOP-MAINEZ\SQLEXPRESS;Initial Catalog=GymBrosDB;Integrated Security=True;Encrypt=False

        static string DB_Connection_String = @"Data Source=.\SQLEXPRESS;Initial Catalog=GymBrosDB;Integrated Security=True;Encrypt=False; MultipleActiveResultSets=True;";
        SqlConnection myConnection;
        static bool check=false;
        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String); 
            try
            {
                myConnection.Open();
                if (!check)
                {
                    MessageBox.Show("The DB connection is opened successfully");
                    check = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("The DB connection is failed");
                //MessageBox.Show(e.ToString());
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }

        public DataTable ExecuteReaderStored(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);

                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public int ExecuteNonQueryStored(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                foreach (KeyValuePair<string, object> param in parameters)
                {
                    myCommand.Parameters.Add(new SqlParameter(param.Key, param.Value));
                }

                int rowsAffected = myCommand.ExecuteNonQuery();

                
                return (rowsAffected > 0) ? 1 : 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0; 
            }
        }



        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
;