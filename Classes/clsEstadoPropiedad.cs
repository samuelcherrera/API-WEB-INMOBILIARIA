using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsEstadoPropiedad
    {
        private INMOBILIARIAAEntities DBInmobiliaria = new INMOBILIARIAAEntities();

        public estado_propiedad Estado_Propiedad { get; set; }

        public string Insertar()
        {
            try
            {
                DBInmobiliaria.estado_propiedad.Add(Estado_Propiedad);
                DBInmobiliaria.SaveChanges();
                return "Estado de propiedad ingresado correctamente. ID: " + Estado_Propiedad.id_estado_propiedad;
            }
            catch (Exception ex)
            {
                return "Error al insertar el estado de propiedad: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                var existente = DBInmobiliaria.estado_propiedad.FirstOrDefault(e => e.id_estado_propiedad == Estado_Propiedad.id_estado_propiedad);
                if (existente == null)
                {
                    return "El ID no es válido";
                }

                DBInmobiliaria.estado_propiedad.AddOrUpdate(Estado_Propiedad);
                DBInmobiliaria.SaveChanges();
                return "Estado de propiedad actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el estado de propiedad: " + ex.Message;
            }
        }

        public estado_propiedad Consultar(int id)
        {
            return DBInmobiliaria.estado_propiedad.FirstOrDefault(e => e.id_estado_propiedad == id);
        }

        public List<estado_propiedad> ConsultarTodos()
        {
            return DBInmobiliaria.estado_propiedad
                .OrderBy(e => e.descripcion)
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                var existente = Consultar(Estado_Propiedad.id_estado_propiedad);
                if (existente == null)
                {
                    return "El ID no es válido";
                }

                DBInmobiliaria.estado_propiedad.Remove(existente);
                DBInmobiliaria.SaveChanges();
                return "Estado de propiedad eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el estado de propiedad: " + ex.Message;
            }
        }

        public string EliminarXid(int id)
        {
            try
            {
                var existente = Consultar(id);
                if (existente == null)
                {
                    return "El ID no es válido";
                }

                DBInmobiliaria.estado_propiedad.Remove(existente);
                DBInmobiliaria.SaveChanges();
                return "Estado de propiedad eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el estado de propiedad: " + ex.Message;
            }
        }
    }
}