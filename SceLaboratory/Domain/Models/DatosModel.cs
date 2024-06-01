using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DataAccess.Contracts;
using Domain.ValueObjects;
using DataAccess.Entities;
using DataAccess.Repositories;
using System.Xml.Linq;

namespace Domain.Models
{
    public class DatosModel: IDisposable
    {
        // CAMPOS
        private int id;
        private DateTime fecha;
        private DateTime hora;
        private string temperatura;
        private string humedad;

        private IDatosRepository datosRepository;
        public EntityState State { private get; set; }
        private List<DatosModel> listDatos;

        //PROPIEDADES/MODELO DE VISTA/ VALIDAR DATOS
        public int Id { get => id; set => id = value; }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public DateTime Hora { get => hora; set => hora = value; }

        public string Temperatura { get => temperatura; set => temperatura = value; }
        public string Humedad { get => humedad; set => humedad = value; }

        public DatosModel()
        {
            datosRepository = new DatosRepository();
        }
        public string SaveChanges()
        {
            string message = null;
            try
            {
                var datosDataModel = new Datos();
                datosDataModel.id = id;
                datosDataModel.fecha = fecha;
                datosDataModel.hora = hora;
                datosDataModel.temperatura = temperatura;
                datosDataModel.humedad = humedad;

                switch (State)
                {
                    case EntityState.Added:
                        datosRepository.Add(datosDataModel);
                        message = "successfully record o registrado corrrectamente";
                        break;
                    case EntityState.Modified:
                        datosRepository.Adit(datosDataModel);
                        message = "successfully edited o editado corrrectamente";
                        break;
                    case EntityState.Deleted:
                        datosRepository.Remove(id);
                        message = "successfully removed o eliminado corrrectamente";
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
                {
                    message = "Duplicate record";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }

        public List<DatosModel> GetAll()
        {
            var datosDataModel = datosRepository.GetAll();
            listDatos = new List<DatosModel>();
            foreach (Datos item in datosDataModel)
            {
              
                listDatos.Add(new DatosModel
                {
                    id = item.id,
                    fecha = item.fecha,
                    hora = item.hora,
                    temperatura = item.temperatura,
                    humedad = item.humedad,
                });
            }
            return listDatos;
        }
        public IEnumerable<DatosModel> FindById(string filter)
        {
            return GetAll().FindAll(e => e.temperatura.Contains(filter) || e.humedad.Contains(filter));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
