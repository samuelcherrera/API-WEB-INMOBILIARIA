using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsProyecto
    {
            private INMOBILIARIAAEntities DB = new INMOBILIARIAAEntities();

    public proyecto Proyecto { get; set; }

    public string Insertar()
    {
        try
        {
            DB.proyectoes.Add(Proyecto);
            DB.SaveChanges();
            return "Proyecto insertado correctamente.";
        }
        catch (Exception ex)
        {
            return "Error al insertar el proyecto: " + ex.Message;
        }
    }

    public string Actualizar()
    {
        var existente = ConsultarPorId(Proyecto.id_proyecto);
        if (existente == null)
            return "El proyecto no existe.";

        DB.proyectoes.AddOrUpdate(Proyecto);
        DB.SaveChanges();
        return "Proyecto actualizado correctamente.";
    }

    public proyecto ConsultarPorId(int id)
    {
        return DB.proyectoes.FirstOrDefault(p => p.id_proyecto == id);
    }

    public List<proyecto> ConsultarTodos()
    {
        return DB.proyectoes.OrderBy(p => p.nombre).ToList();
    }

    public string Eliminar()
    {
        try
        {
            var existente = ConsultarPorId(Proyecto.id_proyecto);
            if (existente == null)
                return "El proyecto no existe.";

            DB.proyectoes.Remove(existente);
            DB.SaveChanges();
            return "Proyecto eliminado correctamente.";
        }
        catch (Exception ex)
        {
            return "Error al eliminar el proyecto: " + ex.Message;
        }
    }

    public string EliminarPorId(int id)
    {
        try
        {
            var existente = ConsultarPorId(id);
            if (existente == null)
                return "El proyecto no existe.";

            DB.proyectoes.Remove(existente);
            DB.SaveChanges();
            return "Proyecto eliminado correctamente.";
        }
        catch (Exception ex)
        {
            return "Error al eliminar el proyecto: " + ex.Message;
        }
    }
}
    }
}
