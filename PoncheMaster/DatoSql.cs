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
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {

                throw new System.Exception(e.Message.ToString());

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
                    return true;
                    conn.Dispose();
                }
                else
                {
                    return false;
                    conn.Dispose();
                }

            }
            catch (Exception e)
            {

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

                            throw new Exception(e.Message.ToString());
                            
                        }
                        
                        conn.Dispose();
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

                            throw new Exception(e.Message.ToString());

                        }

                        conn.Dispose();


                    }
                    else if ((int)cmd.ExecuteScalar()>1)
                    {
                        return false;
                        conn.Dispose();
                    }
                    else
                    {
                        return false;
                        conn.Dispose();
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

    }
}
