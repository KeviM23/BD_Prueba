using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string usuario = TextBox1.Text;
        string contrasena = TextBox2.Text;
        string nombre = TextBox3.Text;
        string area = DropDownList1.SelectedItem.Text;
        string cargo = DropDownList2.SelectedItem.Text;
        string viaje = TextBox4.Text;

        try
        {



            SqlConnection con = new SqlConnection(" Server=.\\SQLExpress;Database=BD_data;Trusted_Connection=True;");
            con.Open();

            SqlCommand com = new SqlCommand(); // Comando para obtener la cadena de conexion y almacenarla
            com.Connection = con; //Establecer la conexion con la base de datos 
            com.CommandType = CommandType.StoredProcedure; // Linea para poder usar procedimientos almacenados
            com.CommandText = "insertar_usuario"; //Nombre del procedimiento almacenado


            com.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            com.Parameters.Add("@contrasena", SqlDbType.NVarChar).Value = contrasena;
            com.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            com.Parameters.Add("@nombrearea", SqlDbType.NVarChar).Value = area;
            com.Parameters.Add("@nombrecargo", SqlDbType.NVarChar).Value = cargo;
            com.Parameters.Add("@viaje", SqlDbType.NVarChar).Value = viaje;


            com.ExecuteNonQuery();

            

        }
        catch (Exception ex)
        {

        }
    }
}