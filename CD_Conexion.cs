using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Prototipo
{
    class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-VEVADOI;Database=tiendita;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }


        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }

        public DataSet Consultar()
        {
            SqlDataAdapter datos = new SqlDataAdapter("Select * from producto;", Conexion);
            DataSet ds = new DataSet();
            datos.Fill(ds, "producto");
            return ds;
        }

        public DataSet User(string cmd)
        {
            AbrirConexion();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion);
            DP.Fill(DS);
            CerrarConexion();
            return DS;
        }

        public DataSet nom(string code)
        {

            AbrirConexion();
            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter("Select CodCli from Cliente where CodCli=" + code, Conexion);
            dp.Fill(ds);
            CerrarConexion();
            return ds;

        }

        public void agregar(String tabla,string valores)
        {

            AbrirConexion();
            
            SqlCommand com = new SqlCommand("Insert into "+tabla+ " values ("+valores+");", Conexion);
            int num = com.ExecuteNonQuery();
            CerrarConexion();


        }

        public void actualizar(string tabla,string cam,string where)
        {
            try
            {
                AbrirConexion();
                SqlCommand com = new SqlCommand("Update " + tabla + " set " + cam + " " + where,Conexion);
                com.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex){ Console.WriteLine(ex.Message); }

        }

        public DataSet select(String tabla,String cam,String where)
        {
            AbrirConexion();
            SqlDataAdapter datos = new SqlDataAdapter("Select "+cam+" from "+tabla+" "+where+";", Conexion);
            DataSet ds = new DataSet();
            datos.Fill(ds, tabla);
            CerrarConexion();
            return ds;
        }

        public int borrar(String tabla,String where)
        {
            AbrirConexion();
            SqlCommand cmd = new SqlCommand("delete from "+tabla+" where "+where+";", Conexion);
            int num = cmd.ExecuteNonQuery();
            CerrarConexion();
            return num;
        }

    }
}
