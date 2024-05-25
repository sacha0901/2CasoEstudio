using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString; // Atributo 
        public ConnectionToSql() //Metodo
        {
            connectionString = "Server=JOKI\\SQLEXPRESS;DataBase= MyLaboratory; integrated security= true";
        }
        protected SqlConnection GetConnection() 
        {
            return new SqlConnection(connectionString);
        }
    }
}
