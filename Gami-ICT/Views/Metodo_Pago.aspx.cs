using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Gami_ICT.Views
{
    public partial class Metodo_Pago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if(TXT_TT.Text!="" && TXT_Numero.Text!="" && TXT_Codigo.Text != "")
            {
                ControladorDB.Instance.reservar(ControladorDB.Instance.PaqueteSeleccionado,
                                            ControladorDB.Instance.Nombre_Hotel,
                                            ControladorDB.Instance.Nombre_Restaurante,
                                            ControladorDB.Instance.SesionNombre,
                                            ControladorDB.Instance.Precio_Hotel,
                                            ControladorDB.Instance.FechaInicial_Hotel,
                                            ControladorDB.Instance.FechaFinal_Hotel,
                                            ControladorDB.Instance.FechaParque,
                                            ControladorDB.Instance.Fecha_Restaurante,
                                            ControladorDB.Instance.Tipo_Hotel,
                                            ControladorDB.Instance.CantidadParque,
                                            ControladorDB.Instance.Cantidad_Hotel,
                                            ControladorDB.Instance.Cantidad_Restaurante,
                                            TXT_TT.Text,
                                            TXT_Numero.Text,
                                            Calendar_Venccimineto.SelectedDate,
                                            Int32.Parse(TXT_Codigo.Text));                
                Response.Redirect("Pago_Exitoso.aspx");
                
                
            }
            
        }
    }
}