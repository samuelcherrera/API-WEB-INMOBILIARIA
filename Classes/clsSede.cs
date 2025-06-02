using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsSede
    {
                private INMOBILIARIAAEntities dbInmobiliaria = new INMOBILIARIAAEntities();
        public sede sede { get; set; } // Instancia para manipular los datos de la tabla sede

        public string Insertar()
        {
            try
            {
                dbInmobiliaria.sedes.Add(sede); // Agrega una nueva sede
                dbInmobiliaria.SaveChanges();   // Guarda los cambios
                return "Sede insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la sede: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            sede s = Consultar(sede.id_sede); // Consulta la sede por ID
            if (s == null)
            {
                return "El ID de la sede no es válido";
            }
            dbInmobiliaria.sedes.AddOrUpdate(sede); // Actualiza la sede
            dbInmobiliaria.SaveChanges();
            return "Se actualizó la sede correctamente";
        }

        public sede Consultar(int idSede)
        {
            return dbInmobiliaria.sedes.FirstOrDefault(s => s.id_sede == idSede); // Consulta por ID
        }

        public List<sede> ConsultarTodos()
        {
            return dbInmobiliaria.sedes
                .OrderBy(s => s.nombre) // Puedes cambiar el criterio de orden si lo deseas
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                sede s = Consultar(sede.id_sede);
                if (s == null)
                {
                    return "El ID de la sede no es válido";
                }
                dbInmobiliaria.sedes.Remove(s); // Elimina la sede
                dbInmobiliaria.SaveChanges();
                return "Se eliminó la sede correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarXId(int idSede)
        {
            try
            {
                sede s = Consultar(idSede);
                if (s == null)
                {
                    return "El ID de la sede no es válido";
                }
                dbInmobiliaria.sedes.Remove(s);
                dbInmobiliaria.SaveChanges();
                return "Se eliminó la sede correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
