using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace PoncheMaster
{
    public class Datos : Idatos
    {
        
        public bool Autentification(string username, string password)
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("AutUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pass", password);
                object result = cmd.ExecuteScalar();
                if (result == DBNull.Value)
                {
                    conn.Dispose();
                    return false;
                }
                else
                {
                    conn.Dispose();
                    return true;
                }
            }
            catch (Exception e)
            {
             
                return false;
                throw new Exception(e.Message.ToString());

            }
           
            
        }

        public bool IsAdmin(string username, int Type = 1)
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("AutUserType", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@TypeUser", Type);
                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    conn.Dispose();
                    return true;
                   
                }
                else
                {
                    conn.Dispose();
                    return false;
                   
                }

            }
            catch (Exception e)
            {
                return false;
                throw new Exception(e.Message.ToString());

            }
           


        }

        public bool Ponche(string cedula)
        {
            
                try
                {
                    string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                    SqlConnection conn = new SqlConnection(connection);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("InOrOut", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    object result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        try
                        {
                            SqlCommand cmd2 = new SqlCommand("insertPonche", conn);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@cedula", cedula);
                            cmd2.Parameters.AddWithValue("@Status", 0);
                            object result2 = cmd.ExecuteNonQuery();
                            return true;


                        }
                        catch (Exception e)
                        {
                        conn.Dispose();
                        return false;
                        throw new Exception(e.Message.ToString());
                            
                        }
                        
                        
                    }
                    else if ((int)cmd.ExecuteScalar() == 1)
                    {

                        try
                        {
                            SqlCommand cmd2 = new SqlCommand("insertPonche", conn);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@cedula", cedula);
                            cmd2.Parameters.AddWithValue("@Status", 1);
                            object result2 = cmd.ExecuteNonQuery();
                            return true;


                        }
                        catch (Exception e)
                        {
                        conn.Dispose();
                        return false;
                        throw new Exception(e.Message.ToString());

                        }

                        


                    }
                    else if ((int)cmd.ExecuteScalar()>1)
                    {
                    conn.Dispose();
                    return false;
                        
                    }
                    else
                    {
                    conn.Dispose();
                    return false;
                        
                    }


                }
                catch (Exception e)
                {

                    throw new Exception(e.Message.ToString());
                }
                
        }

        public bool AuthCedula(string cedula)
        {
            char[] chars = cedula.ToCharArray();
            bool Isvalid = true;

            if (cedula.Length !=13)
            {
                Isvalid = false;
            }

            if (chars[3]!='-' && chars[11] != '-')
            {
                Isvalid = false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsDigit(chars[i]))
                {
                    Isvalid = false;
                }


            }

            for (int t = 4; t < 11; t++)
            {
                if (!char.IsDigit(chars[t]))
                {
                    Isvalid = false;
                }


            }

            if (!char.IsDigit(chars[12]))
            {
                Isvalid = false;
            }

            return Isvalid;
        }

        public bool insertEmployee(string Name, string Lastname, string cedula, DateTime birthdate, int userID, int deptID, int PositionID)
        {
            bool isValid = false;
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@lastName", Lastname);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@user", userID);
                cmd.Parameters.AddWithValue("@Dept", deptID);
                cmd.Parameters.AddWithValue("@position", PositionID);
                object result = cmd.ExecuteNonQuery();
                isValid = true;
                return isValid;

            }
            catch (Exception e)
            {
                isValid = false;
                return isValid;
                throw new Exception(e.Message.ToString());

            }

          
        }

        public bool insertUser(string username, string password, int usertype)
        {
            bool isValid = false;
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("InsertUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@type", usertype);
                object result = cmd.ExecuteNonQuery();
                isValid = true;
                return isValid;

            }
            catch (Exception e)
            {
                isValid = false;
                return isValid;
                throw new Exception(e.Message.ToString());

            }
        }
        public bool UpdateEmployee(int ID, string Name, string Lastname, string cedula, DateTime birthdate, int userID, int deptID, int PositionID)
        {
            bool isValid = false;
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@lastName", Lastname);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@user", userID);
                cmd.Parameters.AddWithValue("@Dept", deptID);
                cmd.Parameters.AddWithValue("@position", PositionID);
                object result = cmd.ExecuteNonQuery();
                isValid = true;
                return isValid;

            }
            catch (Exception e)
            {
                isValid = false;
                return isValid;
                throw new Exception(e.Message.ToString());

            }

        }
        public bool UpdateUser(int ID, string username, string password, int usertype)
        {
            bool isValid = false;
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("UpdateUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@type", usertype);
                object result = cmd.ExecuteNonQuery();
                isValid = true;
                return isValid;

            }
            catch (Exception e)
            {
                isValid = false;
                return isValid;
                throw new Exception(e.Message.ToString());

            }
        }

        public bool DeleteUser(int ID)
        {
            bool isValid = false;
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                object result = cmd.ExecuteNonQuery();
                isValid = true;
                return isValid;

            }
            catch (Exception e)
            {
                isValid = false;
                return isValid;
                throw new Exception(e.Message.ToString());

            }
        }
        public bool DeleteEmployee(int ID)
        {
            bool isValid = false;
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["PoncheMaster.Properties.Settings.PoncheMasterConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ID);
                object result = cmd.ExecuteNonQuery();
                isValid = true;
                return isValid;

            }
            catch (Exception e)
            {
                isValid = false;
                return isValid;
                throw new Exception(e.Message.ToString());

            }
        }
    }
}
