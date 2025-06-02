using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsTipoVisita
    {
        private INMOBILIARIAAEntities dbInmobiliaria = new INMOBILIARIAAEntities();
        public tipo_visita tipoVisita { get; set; } // Objeto que representa la tabla tipo_visita

        public string Insertar()
        {
            try
            {
                dbInmobiliaria.tipo_visita.Add(tipoVisita); // Inserta un nuevo tipo de visita
                dbInmobiliaria.SaveChanges(); // Guarda los cambios en la base de datos
                return "Tipo de visita insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el tipo de visita: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            tipo_visita tv = Consultar(tipoVisita.id_tipo_visita); // Consulta por ID
            if (tv == null)
            {
                return "El ID del tipo de visita no es válido";
            }
            dbInmobiliaria.tipo_visita.AddOrUpdate(tipoVisita); // Actualiza
            dbInmobiliaria.SaveChanges();
            return "Se actualizó el tipo de visita correctamente";
        }

        public tipo_visita Consultar(int idTipoVisita)
        {
            tipo_visita tv = dbInmobiliaria.tipo_visita.FirstOrDefault(t => t.id_tipo_visita == idTipoVisita);
            return tv;
        }

        public List<tipo_visita> ConsultarTodos()
        {
            return dbInmobiliaria.tipo_visita
                .OrderBy(t => t.descripcion) // Ajusta si hay otro campo por el cual ordenar
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                tipo_visita tv = Consultar(tipoVisita.id_tipo_visita);
                if (tv == null)
                {
                    return "El ID del tipo de visita no es válido";
                }
                dbInmobiliaria.tipo_visita.Remove(tv);
                dbInmobiliaria.SaveChanges();
                return "Se eliminó el tipo de visita correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarXId(int idTipoVisita)
        {
            try
            {
                tipo_visita tv = Consultar(idTipoVisita);
                if (tv == null)
                {
                    return "El ID del tipo de visita no es válido";
                }
                dbInmobiliaria.tipo_visita.Remove(tv);
                dbInmobiliaria.SaveChanges();
                return "Se eliminó el tipo de visita correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}