using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsVenta
    {
        private INMOBILIARIAAEntities DBinmobiliaria = new INMOBILIARIAAEntities();

        public venta venta { get; set; }

        public string Insertar()
        {
            try
            {
                DBinmobiliaria.ventas.Add(venta);
                DBinmobiliaria.SaveChanges();
                return "Venta insertada correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar la venta: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            venta vta = Consultar(venta.id_venta);
            if (vta == null)
            {
                return "El ID de la venta no es válido";
            }
            DBinmobiliaria.ventas.AddOrUpdate(venta);
            DBinmobiliaria.SaveChanges();
            return "Se actualizó la venta correctamente";
        }

        public venta Consultar(int idVenta)
        {
            venta vta = DBinmobiliaria.ventas.FirstOrDefault(v => v.id_venta == idVenta);
            return vta;
        }

        public List<venta> ConsultarTodos()
        {
            return DBinmobiliaria.ventas
                .OrderBy(v => v.fecha_venta)
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                venta vta = Consultar(venta.id_venta);
                if (vta == null)
                {
                    return "El ID de la venta no es válido";
                }
                DBinmobiliaria.ventas.Remove(vta);
                DBinmobiliaria.SaveChanges();
                return "Se eliminó la venta correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarXId(int idVenta)
        {
            try
            {
                venta vta = Consultar(idVenta);
                if (vta == null)
                {
                    return "El ID de la venta no es válido";
                }
                DBinmobiliaria.ventas.Remove(vta);
                DBinmobiliaria.SaveChanges();
                return "Se eliminó la venta correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}