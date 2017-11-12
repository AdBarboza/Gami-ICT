using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Gami_ICT.Views
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Registrarse_Click(object sender, EventArgs e)
        {
            if(TXT_Nombre.Text!="" && TXT_Correo.Text != "" && TXT_Apellido.Text!="" && TXT_Cedula.Text!="" && TXT_Contraseña.Text != "")
            {
                DataTable t=ControladorDB.Instance.register(TXT_Nombre.Text, TXT_Correo.Text, TXT_Apellido.Text, TXT_Cedula.Text, TXT_Contraseña.Text);
                if (t.Rows[0][0].ToString() == "1")
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    LBL_Error.Visible = true;
                }
            }
            else
            {
                LBL_Error.Visible=true;
            }
        }
    }
}