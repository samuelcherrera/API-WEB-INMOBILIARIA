using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsOrdenCompra
    {
        private INMOBILIARIAAEntities DBinmobiliaria = new INMOBILIARIAAEntities();

        public orden_compra ordenCompra { get; set; }

        public string Insertar()
        {
            try
            {
                DBinmobiliaria.orden_compra.Add(ordenCompra);
                DBinmobiliaria.SaveChanges();
                return "Orden de compra insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la orden de compra: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            orden_compra orden = ConsultarPorId(ordenCompra.id_orden);
            if (orden == null)
            {
                return "La orden de compra no existe";
            }

            DBinmobiliaria.orden_compra.AddOrUpdate(ordenCompra);
            DBinmobiliaria.SaveChanges();
            return "Orden de compra actualizada correctamente";
        }

        public orden_compra ConsultarPorId(int id)
        {
            return DBinmobiliaria.orden_compra.FirstOrDefault(o => o.id_orden == id);
        }

        public List<orden_compra> ConsultarTodas()
        {
            return DBinmobiliaria.orden_compra
                .OrderBy(o => o.fecha_orden)
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                orden_compra orden = ConsultarPorId(ordenCompra.id_orden);
                if (orden == null)
                {
                    return "La orden de compra no existe";
                }

                DBinmobiliaria.orden_compra.Remove(orden);
                DBinmobiliaria.SaveChanges();
                return "Orden de compra eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la orden de compra: " + ex.Message;
            }
        }

        public string EliminarPorId(int id)
        {
            try
            {
                orden_compra orden = ConsultarPorId(id);
                if (orden == null)
                {
                    return "La orden de compra no existe";
                }

                DBinmobiliaria.orden_compra.Remove(orden);
                DBinmobiliaria.SaveChanges();
                return "Orden de compra eliminada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar la orden de compra: " + ex.Message;
            }
        }
    }
}