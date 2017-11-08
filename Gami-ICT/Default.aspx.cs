using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            int res = App_Start.Controlador.Instance.logIn(mail,pass);            
            LB_prueba.Text = res.ToString();
        }
    }
}