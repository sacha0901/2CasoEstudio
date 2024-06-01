using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Datos
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public string temperatura { get; set; }
        public string humedad { get; set; }
    }
}
