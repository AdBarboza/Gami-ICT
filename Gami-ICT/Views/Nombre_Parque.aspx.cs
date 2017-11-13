using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gami_ICT.Views
{
    public partial class Nombre_Parque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = ControladorDB.Instance.selectnombres();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}