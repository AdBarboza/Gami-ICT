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

        }

        String general_Hotel;
        String general_Restaurante;

        String nombre_Hotel;
        DateTime fechaInicial_Hotel;
        DateTime fechaFinal_Hotel;
        String tipo_Hotel;
        int cantidad_Hotel;
        int precio_Hotel;

        DateTime fecha_Restaurante;
        String nombre_Restaurante;
        int cantidad_Restaurante;

        protected void Button_Hotel_Click(object sender, EventArgs e)
        {
            nombre_Hotel = GridView_Hotel.SelectedValue.ToString();
            fechaInicial_Hotel = Calendar_Hotel.SelectedDate;
            fechaFinal_Hotel = Calendar2_Hotel.SelectedDate;
            tipo_Hotel = ListBox_Hotel.SelectedValue;
            cantidad_Hotel = Convert.ToInt32(TextBox_Hotel.Text);

            general_Hotel = nombre_Hotel + fechaInicial_Hotel + fechaFinal_Hotel + tipo_Hotel + cantidad_Hotel + precio_Hotel;

            TextBox_Aceptar.Text = general_Hotel + "\n" + general_Restaurante;
        }

        protected void Button_Restaurante_Click(object sender, EventArgs e)
        {
            nombre_Restaurante = GridView_Restaurante.SelectedValue.ToString();
            fecha_Restaurante = Calendar_Restaurante.SelectedDate;
            cantidad_Restaurante = Convert.ToInt32(TextBox_Restaurante.Text);

            general_Restaurante = nombre_Restaurante + fecha_Restaurante + cantidad_Restaurante;

            TextBox_Aceptar.Text = general_Hotel + "\n" + general_Restaurante;
        }


        protected void Button_Aceptar_Click(object sender, EventArgs e)
        {
            //validar nombre que no este vacio
            Response.Redirect("Metodo_Pago.aspx");
        }

        protected void Button_EliminarHotel_Click(object sender, EventArgs e)
        {
            nombre_Hotel = "";
            general_Hotel = "";

            TextBox_Aceptar.Text = general_Hotel + "\n" + general_Restaurante;
        }

        protected void Button_EliminarRestaurante_Click(object sender, EventArgs e)
        {
            nombre_Restaurante = "";
            general_Restaurante = "";

            TextBox_Aceptar.Text = general_Hotel + "\n" + general_Restaurante;
        }

        protected void Calendar_Hotel_SelectionChanged(object sender, EventArgs e)
        {

        }

        //El boton de Eliminar_XXX cambia el nombre de XXX a "" esto para validar que desea
        //agregar XXX al paquete o no, en caso de ser "" no se guarda, de lo contrario se
        //ocuparian los datos.
        //En Button_Aceptar_Click tienen que validar si el nombre tiene algo o no, para saber si usar
        //los datos de las otras variables para la consulta de agregar paquete que haran ustedes.
    }
}