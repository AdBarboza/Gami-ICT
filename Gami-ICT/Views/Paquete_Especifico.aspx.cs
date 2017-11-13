using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gami_ICT.Views
{
    public partial class Parq_Musep_Especifico : System.Web.UI.Page
    {

        String general_Hotel;
        String general_Restaurante;  

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = ControladorDB.Instance.selectnombrehotel();
            GridView_Hotel.DataSource = dt;
            GridView_Hotel.DataBind();

            dt = ControladorDB.Instance.selectnombrerestaurante();
            GridView_Restaurante.DataSource = dt;
            GridView_Restaurante.DataBind();
        }

        protected void BTN_Parques_Click(object sender, EventArgs e)
        {

        }

        protected void GridView_Hotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow grdrow = GridView_Hotel.SelectedRow;
            ControladorDB.Instance.Nombre_Hotel = grdrow.Cells[1].Text;
        }      

        protected void Button_Hotel_Click(object sender, EventArgs e)
        {

            ControladorDB.Instance.FechaInicial_Hotel = Calendar_Hotel.SelectedDate;
            ControladorDB.Instance.FechaFinal_Hotel = Calendar2_Hotel.SelectedDate;
            ControladorDB.Instance.Tipo_Hotel = DD_tipoHabitacion.SelectedItem.Text;
            ControladorDB.Instance.Cantidad_Hotel = Convert.ToInt32(TextBox_Hotel.Text);
            general_Hotel = ControladorDB.Instance.Nombre_Hotel + ControladorDB.Instance.FechaInicial_Hotel 
                + ControladorDB.Instance.FechaFinal_Hotel + ControladorDB.Instance.Tipo_Hotel + ControladorDB.Instance.Cantidad_Hotel + ControladorDB.Instance.Precio_Hotel;
            TextBox_Aceptar.Text = general_Hotel + "\n" + general_Restaurante;
        }

        protected void Button_Restaurante_Click(object sender, EventArgs e)
        {
            ControladorDB.Instance.Fecha_Restaurante = Calendar_Restaurante.SelectedDate;
            ControladorDB.Instance.Cantidad_Restaurante = Convert.ToInt32(TextBox_Restaurante.Text);

            general_Restaurante = ControladorDB.Instance.Nombre_Restaurante + ControladorDB.Instance.Fecha_Restaurante + 
                        ControladorDB.Instance.Cantidad_Restaurante;

            TextBox_Aceptar.Text = general_Hotel + "\n" + general_Restaurante;
        }


        protected void Button_Aceptar_Click(object sender, EventArgs e)
        {
            //validar nombre que no este vacio
            Response.Redirect("Metodo_Pago.aspx");
        }

        protected void Button_EliminarHotel_Click(object sender, EventArgs e)
        {
            ControladorDB.Instance.Nombre_Hotel = "";
            general_Hotel = "";

            TextBox_Aceptar.Text = general_Hotel + "\n" + general_Restaurante;
        }

        protected void Button_EliminarRestaurante_Click(object sender, EventArgs e)
        {
            ControladorDB.Instance.Nombre_Restaurante = "";
            general_Restaurante = "";

            TextBox_Aceptar.Text = general_Hotel + "\n" + general_Restaurante;
        }

        protected void Calendar_Hotel_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void GridView_Restaurante_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow grdrow = GridView_Restaurante.SelectedRow;
            ControladorDB.Instance.Nombre_Restaurante = grdrow.Cells[1].Text;
        }

       

        //El boton de Eliminar_XXX cambia el nombre de XXX a "" esto para validar que desea
        //agregar XXX al paquete o no, en caso de ser "" no se guarda, de lo contrario se
        //ocuparian los datos.
        //En Button_Aceptar_Click tienen que validar si el nombre tiene algo o no, para saber si usar
        //los datos de las otras variables para la consulta de agregar paquete que haran ustedes.
    }
}