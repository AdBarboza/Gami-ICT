using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gami_ICT.Views
{
    public partial class Selecciona_Parque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Aceptar_Click(object sender, EventArgs e)
        {
            if (TXT_cantidad.Text != "") {
                ControladorDB.Instance.FechaParque = Calendar.SelectedDate.ToString();
                ControladorDB.Instance.CantidadParque = TXT_cantidad.Text;
                Response.Redirect("Paquete_Especifico.aspx");
            }
            
        }
    }
}