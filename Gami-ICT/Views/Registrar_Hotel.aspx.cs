using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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
                DataTable t = ControladorDB.Instance.registerHotel(TXT_cod.Text, TXT_Nombre.Text, DD_tipoHabitacion.SelectedItem.ToString(), Int32.Parse(TXT_Cantidad.Text), Int32.Parse(TXT_Tarifa.Text));
                if (t.Rows[0][0].ToString() == "1")
                {
                    limpiar();
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

        public void limpiar()
        {
            TXT_Cantidad.Text = "";
            TXT_Nombre.Text = "";
            TXT_cod.Text = "";
            TXT_Tarifa.Text = "";
        }
    }
}