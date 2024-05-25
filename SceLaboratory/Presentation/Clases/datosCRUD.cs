using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation.Clases
{
    public class datosCRUD
    {
        public static int Insertar(Datos datos)
        {
            int retorno = 0;
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO Datos(Fecha, Hora, Temperatura, Humedad) VALUES('{0}', '{1}', '{2}', " +
                "'{3}')", datos.Fecha, datos.Hora, datos.Temperatura, datos.Humedad), ConexionBD.ConectarBD);
            retorno = cmd.ExecuteNonQuery();
            return retorno;
        }

        public static DataTable ObtenerDatos()
        {
            try
            {
                string sql = "SELECT Id AS ID, Fecha AS 'FECHA', Hora AS 'HORA', Temperatura AS 'TEMPERATURA', Humedad AS 'HUMEDAD' FROM Datos";
                SqlDataAdapter adap = new SqlDataAdapter(sql, ConexionBD.ConectarBD);
                DataTable Tabla = new DataTable();
                adap.Fill(Tabla);
                return Tabla;
            }
            catch (Exception error)
            {
                return null;
            }
            
        }
    }
}
