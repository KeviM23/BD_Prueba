using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        string usuario = TextBox1.Text;
        string contrasena = TextBox2.Text;
        try
        {



            SqlConnection con = new SqlConnection(" Server=.\\SQLExpress;Database=BD_data;Trusted_Connection=True;");
            con.Open();

            SqlCommand com = new SqlCommand(); // Comando para obtener la cadena de conexion y almacenarla
            com.Connection = con; //Establecer la conexion con la base de datos 
            com.CommandType = CommandType.StoredProcedure; // Linea para poder usar procedimientos almacenados
            com.CommandText = "SP_Login"; //Nombre del procedimiento almacenado


            com.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            com.Parameters.Add("@contrasena", SqlDbType.NVarChar).Value = contrasena;


            com.ExecuteNonQuery();

            Response.Redirect("Default2.aspx");

        }
        catch (Exception ex)
        {

        }
    }
}