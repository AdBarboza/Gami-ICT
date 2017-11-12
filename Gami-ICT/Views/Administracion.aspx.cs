using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gami_ICT.Views
{
    public partial class Administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Restaurante_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar_Restaurante.aspx");
        }

        protected void BTN_Parque_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar_Parque.aspx");
        }

        protected void BTN_Hotel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar_Hotel.aspx");
        }

        protected void BTN_Reserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerReservas.aspx");
        }
    }
}