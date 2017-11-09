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
            string mail = TB_email.Text;
            string pass = TB_password.Text;
            int res = ControladorDB.Instance.logIn(mail,pass);
            LB_prueba.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            DataTable dt = ControladorDB.Instance.select();           
            GridView1.DataSource = dt;
            GridView1.DataBind();           
        }

        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {
            Int32 iID = Convert.ToInt32((GridView1.DataKeys[e.NewEditIndex].Value));
            //EditMethod(iID);        // now you can send ID and retrieve data.
        }

        protected void RowDeliting(object sender, GridViewDeleteEventArgs e)
        {
            Int32 iID = Convert.ToInt32((GridView1.DataKeys[e.RowIndex].Value));
            //DeleteMethod(iID);        // now you can send ID and retrieve data.
        }
    }
}