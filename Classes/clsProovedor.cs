using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsProovedor
    {
        private INMOBILIARIAAEntities DBinmobiliaria = new INMOBILIARIAAEntities();

        public proveedor proveedor { get; set; }

        public string Insertar()
        {
            try
            {
                DBinmobiliaria.proveedors.Add(proveedor);
                DBinmobiliaria.SaveChanges();
                return "Proveedor insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el proveedor: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            proveedor prov = ConsultarPorId(proveedor.id_proveedor);
            if (prov == null)
            {
                return "El proveedor no existe";
            }
            DBinmobiliaria.proveedors.AddOrUpdate(proveedor);
            DBinmobiliaria.SaveChanges();
            return "Proveedor actualizado correctamente";
        }

        public proveedor ConsultarPorId(int id)
        {
            return DBinmobiliaria.proveedors.FirstOrDefault(p => p.id_proveedor == id);
        }

        public List<proveedor> ConsultarTodos()
        {
            return DBinmobiliaria.proveedors
                .OrderBy(p => p.nombre_comercial)
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                proveedor prov = ConsultarPorId(proveedor.id_proveedor);
                if (prov == null)
                {
                    return "El proveedor no existe";
                }
                DBinmobiliaria.proveedors.Remove(prov);
                DBinmobiliaria.SaveChanges();
                return "Proveedor eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el proveedor: " + ex.Message;
            }
        }

        public string EliminarPorId(int id)
        {
            try
            {
                proveedor prov = ConsultarPorId(id);
                if (prov == null)
                {
                    return "El proveedor no existe";
                }
                DBinmobiliaria.proveedors.Remove(prov);
                DBinmobiliaria.SaveChanges();
                return "Proveedor eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el proveedor: " + ex.Message;
            }
        }
    }
}