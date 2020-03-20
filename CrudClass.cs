using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using FSharp.Data.Runtime.StructuralTypes;
using System.Web.UI.WebControls;
using System.Drawing;

namespace mensajeria_ws {
    public class CrudClass {
        private static string conString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        private static SqlConnection con = new SqlConnection(conString);

        public static DataSet getAllRecords(string query) {
            SqlCommand sql = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet getSingleRecord(string query, string name) {
            SqlCommand sql = new SqlCommand(query, con);
            sql.Parameters.Add("@name", SqlDbType.NVarChar);
            sql.Parameters[0].Value = name;
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet deleteRecord(string query, int id) {
            SqlCommand sql = new SqlCommand(query, con);
            sql.Parameters.Add("@id", SqlDbType.NVarChar);
            sql.Parameters[0].Value = id;
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet createRecord(
            string query,
            string name,
            string organization,
            string position,
            string storeType,
            string email,
            string showAs,
            string website,
            string imAddress,
            string phoneWork,
            string phoneHome,
            string faxWork,
            string phoneMobile,
            string workAddress,
            int correspondence,
            string notes,
            string imagen
        ) {
            SqlCommand sql = new SqlCommand(query, con);
            sql.Parameters.Add("@name", SqlDbType.NVarChar);
            sql.Parameters[0].Value = name;
            sql.Parameters.Add("@organization", SqlDbType.NVarChar);
            sql.Parameters[1].Value = organization;
            sql.Parameters.Add("@position", SqlDbType.NVarChar);
            sql.Parameters[2].Value = position;
            sql.Parameters.Add("@storeType", SqlDbType.NVarChar);
            sql.Parameters[3].Value = storeType;
            sql.Parameters.Add("@email", SqlDbType.NVarChar);
            sql.Parameters[4].Value = email;
            sql.Parameters.Add("@showAs", SqlDbType.NVarChar);
            sql.Parameters[5].Value = showAs;
            sql.Parameters.Add("@website", SqlDbType.NVarChar);
            sql.Parameters[6].Value = website;
            sql.Parameters.Add("@imAddress", SqlDbType.NVarChar);
            sql.Parameters[7].Value = imAddress;
            sql.Parameters.Add("@phoneWork", SqlDbType.NVarChar);
            sql.Parameters[8].Value = phoneWork;
            sql.Parameters.Add("@phoneHome", SqlDbType.NVarChar);
            sql.Parameters[9].Value = phoneHome;
            sql.Parameters.Add("@faxWork", SqlDbType.NVarChar);
            sql.Parameters[10].Value = faxWork;
            sql.Parameters.Add("@phoneMobile", SqlDbType.NVarChar);
            sql.Parameters[11].Value = phoneMobile;
            sql.Parameters.Add("@workAddress", SqlDbType.NVarChar);
            sql.Parameters[12].Value = workAddress;
            sql.Parameters.Add("@correspondence", SqlDbType.TinyInt);
            sql.Parameters[13].Value = correspondence;
            sql.Parameters.Add("@notes", SqlDbType.NVarChar);
            sql.Parameters[14].Value = notes;
            sql.Parameters.Add("@imagen", SqlDbType.VarChar);
            sql.Parameters[15].Value = imagen;
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static DataSet updateRecord(
            string query,
            int id,
            string name,
            string organization,
            string position,
            string storeType,
            string email,
            string showAs,
            string website,
            string imAddress,
            string phoneWork,
            string phoneHome,
            string faxWork,
            string phoneMobile,
            string workAddress,
            int correspondence,
            string notes,
            string imagen
        )
        {
            SqlCommand sql = new SqlCommand(query, con);
            sql.Parameters.Add("@name", SqlDbType.NVarChar);
            sql.Parameters[0].Value = name;
            sql.Parameters.Add("@organization", SqlDbType.NVarChar);
            sql.Parameters[1].Value = organization;
            sql.Parameters.Add("@position", SqlDbType.NVarChar);
            sql.Parameters[2].Value = position;
            sql.Parameters.Add("@storeType", SqlDbType.NVarChar);
            sql.Parameters[3].Value = storeType;
            sql.Parameters.Add("@email", SqlDbType.NVarChar);
            sql.Parameters[4].Value = email;
            sql.Parameters.Add("@showAs", SqlDbType.NVarChar);
            sql.Parameters[5].Value = showAs;
            sql.Parameters.Add("@website", SqlDbType.NVarChar);
            sql.Parameters[6].Value = website;
            sql.Parameters.Add("@imAddress", SqlDbType.NVarChar);
            sql.Parameters[7].Value = imAddress;
            sql.Parameters.Add("@phoneWork", SqlDbType.NVarChar);
            sql.Parameters[8].Value = phoneWork;
            sql.Parameters.Add("@phoneHome", SqlDbType.NVarChar);
            sql.Parameters[9].Value = phoneHome;
            sql.Parameters.Add("@faxWork", SqlDbType.NVarChar);
            sql.Parameters[10].Value = faxWork;
            sql.Parameters.Add("@phoneMobile", SqlDbType.NVarChar);
            sql.Parameters[11].Value = phoneMobile;
            sql.Parameters.Add("@workAddress", SqlDbType.NVarChar);
            sql.Parameters[12].Value = workAddress;
            sql.Parameters.Add("@correspondence", SqlDbType.TinyInt);
            sql.Parameters[13].Value = correspondence;
            sql.Parameters.Add("@notes", SqlDbType.NVarChar);
            sql.Parameters[14].Value = notes;
            sql.Parameters.Add("@imagen", SqlDbType.VarChar);
            sql.Parameters[15].Value = imagen;
            sql.Parameters.Add("@id", SqlDbType.NVarChar);
            sql.Parameters[16].Value = id;
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
