using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Gami_ICT.Views
{
    public partial class Registrar_Parque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TXT_Nombre1.Text != "" && TXT_Tarifa.Text != "")
            {
                LBL_Error.Visible = true;
            }
        }
    }
}