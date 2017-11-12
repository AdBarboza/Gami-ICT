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
            Response.Redirect("Paquete_Especifico.aspx");
        }
    }
}