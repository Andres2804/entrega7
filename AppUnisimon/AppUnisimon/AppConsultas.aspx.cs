using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AppUnisimon
{
    public partial class AppConsultas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //conexion a la base de datos
            string cadena=@"Data Source=(LocalDb)\v11.0;AttachDbFilename=C:\Users\LAB104BPC10\Documents\Visual Studio 2012\Projects\AppUnisimon\AppUnisimon\App_Data\aspnet-AppUnisimon-20150423185041.mdf;Initial Catalog=aspnet-AppUnisimon-20150423185041;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            cn.Open();
            string sqlCommand="INSERT INTO Usuarios(nombre,apellido,edad,correo) VALUES(
            
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();


        }
    }
}