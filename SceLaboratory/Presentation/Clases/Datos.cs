using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Clases
{
    public class Datos
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public double Temperatura { get; set; }
        public double Humedad { get; set; }

        public Datos() { }

        public Datos(int id, DateTime fecha, DateTime hora, double temperatura, double humedad)
        {
            Id = id;
            Fecha = fecha;
            Hora = hora;
            Temperatura = temperatura;
            Humedad = humedad;
        }
    }
}