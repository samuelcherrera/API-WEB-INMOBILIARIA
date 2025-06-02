using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsPropiedadModelo
    {
         private INMOBILIARIAAEntities db = new INMOBILIARIAAEntities();

 public propiedad_modelo propiedadModelo { get; set; }

 public string Insertar()
 {
     try
     {
         db.propiedad_modelo.Add(propiedadModelo);
         db.SaveChanges();
         return "Propiedad modelo insertada correctamente";
     }
     catch (Exception ex)
     {
         return "Error al insertar propiedad modelo: " + ex.Message;
     }
 }

 public string Actualizar()
 {
     propiedad_modelo existente = ConsultarPorId(propiedadModelo.id_propiedad);
     if (existente == null)
         return "La propiedad modelo no existe";

     db.propiedad_modelo.AddOrUpdate(propiedadModelo);
     db.SaveChanges();
     return "Propiedad modelo actualizada correctamente";
 }

 public propiedad_modelo ConsultarPorId(int id)
 {
     return db.propiedad_modelo.FirstOrDefault(p => p.id_propiedad == id);
 }

 public List<propiedad_modelo> ConsultarTodas()
 {
     return db.propiedad_modelo
         .OrderBy(p => p.id_propiedad)
         .ToList();
 }

 public string Eliminar()
 {
     try
     {
         var existente = ConsultarPorId(propiedadModelo.id_propiedad);
         if (existente == null)
             return "La propiedad modelo no existe";

         db.propiedad_modelo.Remove(existente);
         db.SaveChanges();
         return "Propiedad modelo eliminada correctamente";
     }
     catch (Exception ex)
     {
         return "Error al eliminar propiedad modelo: " + ex.Message;
     }
 }

 public string EliminarPorId(int id)
 {
     try
     {
         var existente = ConsultarPorId(id);
         if (existente == null)
             return "La propiedad modelo no existe";

         db.propiedad_modelo.Remove(existente);
         db.SaveChanges();
         return "Propiedad modelo eliminada correctamente";
     }
     catch (Exception ex)
     {
         return "Error al eliminar propiedad modelo: " + ex.Message;
     }
 }
    }
}
