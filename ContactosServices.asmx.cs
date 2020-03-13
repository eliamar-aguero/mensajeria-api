using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;

namespace mensajeria_ws
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }


        [WebMethod]
        public DataSet Obtener_dato(string id)
        {
            string conString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(conString);
            SqlCommand sql = new SqlCommand("SELECT contactos.nombre, contactos.tel_movil, mensajes.mensaje FROM contactos INNER JOIN mensajes ON contactos.id = mensajes.contactos_id; ", con);
           // sql.Parameters.Add("@id", SqlDbType.NVarChar);
           // sql.Parameters[0].Value = id;
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(ds);

            return ds;
        }
        
    }
}
