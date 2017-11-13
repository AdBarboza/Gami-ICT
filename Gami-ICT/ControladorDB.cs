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
        private static int sesionActiva;
        private static string sesionNombre;
        private static string paqueteSeleccionado;
        private static string fechaParque;
        private static string cantidadParque;
        private static String nombre_Hotel;
        private static DateTime fechaInicial_Hotel;
        private static DateTime fechaFinal_Hotel;
        private static String tipo_Hotel;
        private static int cantidad_Hotel;
        private static int precio_Hotel;
        private static DateTime fecha_Restaurante;
        private static String nombre_Restaurante;
        private static int cantidad_Restaurante;        

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

        public int SesionActiva
        {
            get
            {
                return sesionActiva;
            }

            set
            {
                sesionActiva = value;
            }
        }

        public string PaqueteSeleccionado
        {
            get
            {
                return paqueteSeleccionado;
            }

            set
            {
                paqueteSeleccionado = value;
            }
        }

        public string CantidadParque
        {
            get
            {
                return cantidadParque;
            }

            set
            {
                cantidadParque = value;
            }
        }

        public string FechaParque
        {
            get
            {
                return fechaParque;
            }

            set
            {
                fechaParque = value;
            }
        }

        public string Nombre_Hotel
        {
            get
            {
                return nombre_Hotel;
            }

            set
            {
                nombre_Hotel = value;
            }
        }

        public DateTime FechaInicial_Hotel
        {
            get
            {
                return fechaInicial_Hotel;
            }

            set
            {
                fechaInicial_Hotel = value;
            }
        }

        public DateTime FechaFinal_Hotel
        {
            get
            {
                return fechaFinal_Hotel;
            }

            set
            {
                fechaFinal_Hotel = value;
            }
        }

        public string Tipo_Hotel
        {
            get
            {
                return tipo_Hotel;
            }

            set
            {
                tipo_Hotel = value;
            }
        }

        public int Cantidad_Hotel
        {
            get
            {
                return cantidad_Hotel;
            }

            set
            {
                cantidad_Hotel = value;
            }
        }

        public DateTime Fecha_Restaurante
        {
            get
            {
                return fecha_Restaurante;
            }

            set
            {
                fecha_Restaurante = value;
            }
        }

        public string Nombre_Restaurante
        {
            get
            {
                return nombre_Restaurante;
            }

            set
            {
                nombre_Restaurante = value;
            }
        }

        public int Cantidad_Restaurante
        {
            get
            {
                return cantidad_Restaurante;
            }

            set
            {
                cantidad_Restaurante = value;
            }
        }

        public int Precio_Hotel
        {
            get
            {
                return precio_Hotel;
            }

            set
            {
                precio_Hotel = value;
            }
        }

        public string SesionNombre
        {
            get
            {
                return sesionNombre;
            }

            set
            {
                sesionNombre = value;
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

        public DataTable register(string nomb,string email,string apellido,string ced, string password)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Registro", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nomb",nomb );
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("apellido", apellido);
                    cmd.Parameters.AddWithValue("ced", ced);
                    cmd.Parameters.AddWithValue("pass", password);
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

        public DataTable registerHotel(string codigo,string nomb, string descp, int capacidad, int tarifa)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("RegistroHotel", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codigo", codigo);
                    cmd.Parameters.AddWithValue("nomb", nomb);
                    cmd.Parameters.AddWithValue("descp", descp);
                    cmd.Parameters.AddWithValue("capacidad",capacidad);
                    cmd.Parameters.AddWithValue("tarifa", tarifa);
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

        public DataTable registerRest(string codigo, string nomb, int capacidad)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("RegistroRestaurante", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codigo", codigo);
                    cmd.Parameters.AddWithValue("nomb", nomb);                    
                    cmd.Parameters.AddWithValue("capacidad", capacidad);                    
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
                using (MySqlCommand cmd = new MySqlCommand("selectnombres", con))
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

        public DataTable selectnombrehotel()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("selectnombrehotel", con))
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

        public DataTable selectnombrerestaurante()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("selectnombrerestaurante", con))
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

        public void reservar
            (string paqueteSeleccionado,
            String nombre_Hotel,
            String nombre_Restaurante,            
            string sesionNombre,
            int precio_Hotel,
            DateTime fechaInicial_Hotel,
            DateTime fechaFinal_Hotel,
            string fechaParque,
            DateTime fecha_Restaurante,
            String tipo_Hotel,
            string cantidadParque,                                   
            int cantidad_Hotel,
            int cantidad_Restaurante,
            string tip_tarjeta,
            string num_t,
            DateTime fecha_tarjeta,
            int cod_t)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Reservar", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("FK_parq_museo", paqueteSeleccionado);
                    cmd.Parameters.AddWithValue("FK_hotel", nombre_Hotel);
                    cmd.Parameters.AddWithValue("FK_rest", nombre_Restaurante);
                    cmd.Parameters.AddWithValue("FK_turista", sesionNombre);
                    cmd.Parameters.AddWithValue("Monto_total", precio_Hotel);
                    cmd.Parameters.AddWithValue("Fecha_icio_h", fechaInicial_Hotel);
                    cmd.Parameters.AddWithValue("Fecha_f_h", fechaFinal_Hotel);
                    cmd.Parameters.AddWithValue("Fecha_parque", fechaParque);
                    cmd.Parameters.AddWithValue("Fecha_rest", fecha_Restaurante);
                    cmd.Parameters.AddWithValue("Tipo_Habitacion", tipo_Hotel);
                    cmd.Parameters.AddWithValue("Cantidad_p T", cantidadParque);
                    cmd.Parameters.AddWithValue("Cantidad_h T", cantidad_Hotel);
                    cmd.Parameters.AddWithValue("Cantidad_r T", cantidad_Restaurante);
                    cmd.Parameters.AddWithValue("TipoTarjeta", tip_tarjeta);
                    cmd.Parameters.AddWithValue("numero", num_t);
                    cmd.Parameters.AddWithValue("Fecha_vencimiento", fecha_tarjeta);
                    cmd.Parameters.AddWithValue("Cod_seguridad", cod_t);             
                }
            }
        }
    }
}