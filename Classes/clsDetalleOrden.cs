using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsDetalleOrden
    {
        private INMOBILIARIAAEntities db = new INMOBILIARIAAEntities();

        public detalle_orden detalle { get; set; }

        public string Insertar()
        {
            try
            {
                db.detalle_orden.Add(detalle);
                db.SaveChanges();
                return "Detalle de orden insertado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el detalle: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            var existente = ConsultarPorId(detalle.id_detalle);
            if (existente == null)
                return "El detalle no existe.";

            db.detalle_orden.AddOrUpdate(detalle);
            db.SaveChanges();
            return "Detalle de orden actualizado correctamente.";
        }

        public detalle_orden ConsultarPorId(int id)
        {
            return db.detalle_orden.FirstOrDefault(d => d.id_detalle == id);
        }

        public List<detalle_orden> ConsultarTodas()
        {
            return db.detalle_orden.OrderBy(d => d.id_detalle).ToList();
        }

        public string Eliminar()
        {
            try
            {
                var existente = ConsultarPorId(detalle.id_detalle);
                if (existente == null)
                    return "El detalle no existe.";

                db.detalle_orden.Remove(existente);
                db.SaveChanges();
                return "Detalle eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el detalle: " + ex.Message;
            }
        }

        public string EliminarPorId(int id)
        {
            try
            {
                var existente = ConsultarPorId(id);
                if (existente == null)
                    return "El detalle no existe.";

                db.detalle_orden.Remove(existente);
                db.SaveChanges();
                return "Detalle eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el detalle: " + ex.Message;
            }
        }
    }
}