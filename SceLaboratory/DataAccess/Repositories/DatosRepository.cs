using DataAccess.Contracts;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class DatosRepository : MasterRepository, IDatosRepository
    {
        //Campos
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        //Propiedades
        //:::

        public DatosRepository()
        {
            selectAll = "select * from Datos";
            insert = "insert into Datos values(@fecha,@hora,@temperatura,@humedad)";
            update = "update Datos set Fecha=@fecha,Hora=@hora,Temperatura=@temperatura,Humedad=@humedad where Id=@id";
            delete = "delete from Datos where Id=@id";
        }

        public int Add(Datos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@fecha", entity.fecha));
            parameters.Add(new SqlParameter("@hora", entity.hora));
            parameters.Add(new SqlParameter("@temperatura", entity.temperatura));
            parameters.Add(new SqlParameter("@humedad", entity.humedad));
            return ExecuteNonQuery(insert);
        }

        public int Adit(Datos entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", entity.id));
            parameters.Add(new SqlParameter("@fecha", entity.fecha));
            parameters.Add(new SqlParameter("@hora", entity.hora));
            parameters.Add(new SqlParameter("@temperatura", entity.temperatura));
            parameters.Add(new SqlParameter("@humedad", entity.humedad));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<Datos> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var listDatos = new List<Datos>();
            foreach (DataRow item in tableResult.Rows)
            {

                var fecha = Convert.ToDateTime(item[1]);
                var hora = item[2] is TimeSpan ? (TimeSpan)item[2] : TimeSpan.Zero;
                var fechaHora = fecha.Add(hora); // Combina fecha y hora

                listDatos.Add(new Datos
                {
                    id = Convert.ToInt32(item[0]),
                    fecha = fecha,
                    hora = fechaHora, // Ajusta si es necesario
                    temperatura = Convert.ToString(item[3]),
                    humedad = Convert.ToString(item[4]),
                });
            }
            return listDatos;
        }

        public int Remove(int id)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", id));
            return ExecuteNonQuery(delete);
        }
    }
}
