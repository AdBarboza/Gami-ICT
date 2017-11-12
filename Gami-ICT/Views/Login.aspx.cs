using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Gami_ICT.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LBL_Error.Visible = false;
        }

        protected void BTN_Logear_Click(object sender, EventArgs e)
        {
            
            string email = TXT_user.Text;
            string contraseña = TXT_Contraseña.Text;
            DataTable t = ControladorDB.Instance.logIn2(email,contraseña);
            if(email!="" && contraseña != "")
            {
                if ((email == "admin1@ict.com" || email == "admin2@ict.com") && contraseña == "1234")
                {
                    ControladorDB.Instance.SesionActiva = 2;
                    Response.Redirect("Administracion.aspx");
                    Master.FindControl("NB_Iniciar").Visible = false;
                    Master.FindControl("NB_Registrar").Visible = false;
                    Master.FindControl("NB_Admi").Visible = true;
                    Master.FindControl("NB_Cerrar").Visible = true;
                }
                else
                {
                    if (t.Rows[0][0].ToString() == "1")
                    {
                        ControladorDB.Instance.SesionActiva = 1;
                        Response.Redirect("Paquete_Especifico.aspx");
                        Master.FindControl("NB_Iniciar").Visible = false;
                        Master.FindControl("NB_Registrar").Visible = false;
                        Master.FindControl("NB_Cerrar").Visible = true;
                    }
                    else
                    {
                        ControladorDB.Instance.SesionActiva = 0;
                        LBL_Error.Visible = true;
                    }
                }
            }
            else
            {
                ControladorDB.Instance.SesionActiva = 0;
                LBL_Error.Visible = true;
            }
        }
    }
}