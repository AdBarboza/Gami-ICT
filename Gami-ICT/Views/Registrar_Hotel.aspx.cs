using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gami_ICT.Views
{
    public partial class Registrar_Hotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Registrarse_Click(object sender, EventArgs e)
        {
            
            if (TXT_Nombre.Text!="" && TXT_Cantidad.Text!="" && TXT_Tarifa.Text!="" && TXT_cod.Text!="")
            {
                LBL_Error.Visible = true;
            }
            else
            {
                LBL_Error.Visible = true;
            }
        }
    }
}