using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Gami_ICT.Views
{
    public partial class Registrar_Restaurante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void But_reg_Click(object sender, EventArgs e)
        {
            if(TXT_Nombre.Text!="" && TXT_Maximo.Text!="" && TXT_codigo.Text != "")
            {
                DataTable t = ControladorDB.Instance.registerRest(TXT_codigo.Text, TXT_Nombre.Text, Int32.Parse(TXT_Maximo.Text));
                if (t.Rows[0][0].ToString() == "1")
                {
                    TXT_Nombre.Text = "";
                    TXT_Maximo.Text = "";
                    TXT_codigo.Text = "";
                }
                else
                {
                    LBL_Error.Visible = true;
                }
            }
            else
            {
                LBL_Error.Visible = true;
            }
        }
    }
}