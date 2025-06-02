using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsPropiedad
    {
        private INMOBILIARIAAEntities DBinmobiliaria = new INMOBILIARIAAEntities();

        public propiedad propiedad { get; set; }

        public string Insertar()
        {
            try
            {
                DBinmobiliaria.propiedads.Add(propiedad);
                DBinmobiliaria.SaveChanges();
                return "Propiedad insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la propiedad: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            propiedad prop = ConsultarPorId(propiedad.id_propiedad);
            if (prop == null)
            {
                return "La propiedad no existe";
            }
            DBinmobiliaria.propiedads.AddOrUpdate(propiedad);
            DBinmobiliaria.SaveChanges();
            return "Propiedad actualizada correctamente";
        }

        public propiedad ConsultarPorId(int id)
        {
            return DBinmobiliaria.propiedads.FirstOrDefault(p => p.id_propiedad == id);
        }

        public List<propiedad> ConsultarTodas()
        {
            return DBinmobiliaria.propiedads
                .OrderBy(p => p.titulo)
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                propiedad prop = ConsultarPorId(propiedad.id_propiedad);
                if (prop == null)
                {
                    return "La propiedad no existe";
                }
                DBinmobiliaria.propiedads.Remove(prop);
                DBinmobiliaria.SaveChanges();
                return "Propiedad eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la propiedad: " + ex.Message;
            }
        }

        public string EliminarPorId(int id)
        {
            try
            {
                propiedad prop = ConsultarPorId(id);
                if (prop == null)
                {
                    return "La propiedad no existe";
                }
                DBinmobiliaria.propiedads.Remove(prop);
                DBinmobiliaria.SaveChanges();
                return "Propiedad eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la propiedad: " + ex.Message;
            }
        }
    }
}