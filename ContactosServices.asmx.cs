using System.Data;
using System.Web.Services;

namespace mensajeria_ws {
    /// <summary>
    /// Servicio web para aplicación de administración de contactos y mensajes a contactos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : WebService {
        [WebMethod]
        public DataSet GetAllContacts() {
            string sql = "SELECT id, nombre FROM contactos;";
            return CrudClass.getAllRecords(sql);
        }

        [WebMethod]
        public DataSet GetSingleContact(int id) {
            string sql = "SELECT * FROM contactos where id = @id;";
            return CrudClass.getSingleRecord(sql, id);
        }

        [WebMethod]
        public DataSet DeleteContact(int id) {
            string sql = "DELETE FROM contactos where id = @id;";
            return CrudClass.deleteRecord(sql, id);
        }

        [WebMethod]
        public DataSet CreateContact(
            string name,
            string organization,
            string position,
            string storeType,
            string email,
            string showAs,
            string website,
            string imAdress,
            string phoneWork,
            string phoneHome,
            string faxWork,
            string phoneMobile,
            string workAddress,
            int correspondence,
            string notes
            ) {
            string sql = @"INSERT INTO contactos(
                nombre,
                organizacion,
                puesto,
                archivar_como_a,
                email,
                mostrar_como,
                pagina_web,
                direccion_im,
                tel_trabajo,
                tel_particular,
                fax_trabajo,
                tel_movil,
                direccion_trabajo,
                direccion_correspondencia,
                notas
            )
            VALUES(
                @name,
                @organization,
                @position,
                @storeType,
                @email,
                @showAs,
                @website,
                @imAdress,
                @phoneWork,
                @phoneHome,
                @faxWork,
                @phoneMobile,
                @workAddress,
                @correspondence,
                @notes
            )";
            return CrudClass.createRecord(
                sql,
                name,
                organization,
                position,
                storeType,
                email,
                showAs,
                website,
                imAdress,
                phoneWork,
                phoneHome,
                faxWork,
                phoneMobile,
                workAddress,
                correspondence,
                notes
            );
        }

    }
}
