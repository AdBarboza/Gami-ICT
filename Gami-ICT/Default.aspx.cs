using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Gami_ICT
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Master.FindControl("NB_Cerrar").Visible=true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            DataTable dt = ControladorDB.Instance.select();           
            GridView1.DataSource = dt;
            GridView1.DataBind();
               
        }

        protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 iID = Convert.ToInt32((GridView1.DataKeys[e.NewEditIndex].Value));
            //EditMethod(iID);        // now you can send ID and retrieve data.
        }
    }
}