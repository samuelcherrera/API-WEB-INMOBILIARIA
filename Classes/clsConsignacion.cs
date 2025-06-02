using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsConsignacion
    {
        private INMOBILIARIAAEntities DBinmobiliaria = new INMOBILIARIAAEntities();

        public consignacion consignacion { get; set; }

        public string Insertar()
        {
            try
            {
                DBinmobiliaria.consignacions.Add(consignacion);
                DBinmobiliaria.SaveChanges();
                return "Consignación insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la consignación: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            consignacion cons = Consultar(consignacion.id_consignacion);
            if (cons == null)
            {
                return "El ID de la consignación no es válido";
            }
            DBinmobiliaria.Entry(cons).CurrentValues.SetValues(consignacion);
            DBinmobiliaria.SaveChanges();
            return "Se actualizó la consignación correctamente";
        }

        public consignacion Consultar(int idConsignacion)
        {
            return DBinmobiliaria.consignacions.FirstOrDefault(c => c.id_consignacion == idConsignacion);
        }

        public List<consignacion> ConsultarTodos()
        {
            return DBinmobiliaria.consignacions
                .OrderBy(c => c.fecha_inicio)
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                consignacion cons = Consultar(consignacion.id_consignacion);
                if (cons == null)
                {
                    return "El ID de la consignación no es válido";
                }
                DBinmobiliaria.consignacions.Remove(cons);
                DBinmobiliaria.SaveChanges();
                return "Se eliminó la consignación correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarXId(int idConsignacion)
        {
            try
            {
                consignacion cons = Consultar(idConsignacion);
                if (cons == null)
                {
                    return "El ID de la consignación no es válido";
                }
                DBinmobiliaria.consignacions.Remove(cons);
                DBinmobiliaria.SaveChanges();
                return "Se eliminó la consignación correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}