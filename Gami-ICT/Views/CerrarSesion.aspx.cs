using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gami_ICT.Views
{
    public partial class CerrarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
            Master.FindControl("NB_Iniciar").Visible = true;
            Master.FindControl("NB_Registrar").Visible = true;
            Master.FindControl("NB_Admi").Visible = false;
            Master.FindControl("NB_Cerrar").Visible = false;
        }
    }
}