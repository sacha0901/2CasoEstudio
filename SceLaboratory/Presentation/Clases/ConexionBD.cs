using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Clases
{
    public class ConexionBD
    {
        string cadena = "Data Source=JOKI\\SQLEXPRESS; Initial Catalog=MyLaboratory; Integrated Security=True";
        public static SqlConnection ConectarBD = new SqlConnection();

        public ConexionBD()
        {
            ConectarBD.ConnectionString = cadena;
        }
        public void AbrirCn()
        {
            try
            {
                ConectarBD.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error en la conexion" + ex.Message);
            }
        }
        public void CerrarCn()
        {
            ConectarBD.Close();
        }
    }
}
