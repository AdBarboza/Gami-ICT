using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gami_ICT.App_Code
{
    public class Controler
    {
        private static Controler instance;
        private static string connectionString = @"Server=localhost;Database=gami;Uid=root;Pwd=fnfDB1996;";


        private Controler() { }

        public static Controler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controler();
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
                MySqlCommand sqlCmd = new MySqlCommand("exitsTurista", sqlCon);
                MySqlParameter ouP = new MySqlParameter("resultado", MySqlDbType.Int16) { Direction = ParameterDirection.Output };
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("email", email);
                sqlCmd.Parameters.AddWithValue("cont", password);
                sqlCmd.Parameters.Add(ouP);
                result = sqlCmd.ExecuteNonQuery();
            }
            return result;
        }
    }
}