using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gami_ICT
{
    public class ControladorDB
    {
        private static ControladorDB instance;
        private static string connectionString = @"Server=localhost;Database=gami;Uid=root;Pwd=fnfDB1996;";

        private ControladorDB() { }

        public static ControladorDB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ControladorDB();
                }
                return instance;
            }
        }

        public int logIn(string email, string password)
        {
            int result = 5;
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlCommand sqlCmd = new MySqlCommand("Login", sqlCon);
                MySqlParameter ouP = new MySqlParameter("resultado", MySqlDbType.Int16) { Direction = ParameterDirection.Output };
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("email", email);
                sqlCmd.Parameters.AddWithValue("cont", password);
                sqlCmd.Parameters.Add(ouP);
                result = sqlCmd.ExecuteNonQuery();
            }
            return result;
        }

        public DataTable logIn2(string email, string password)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Login", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("cont", password);
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            // fill DataTable logic
                            sda.Fill(dt);
                            return dt;
                        }

                    }
                }
            }
        }

        public DataTable select()
        {
            
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SelectTurista", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            // fill DataTable logic
                            sda.Fill(dt);
                            return dt;
                        }                        
                                                
                    }
                }
            }
        }

        public DataTable selectnombres()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("faltanonmbre", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            // fill DataTable logic
                            sda.Fill(dt);
                            return dt;
                        }

                    }
                }
            }
        }
    }
}