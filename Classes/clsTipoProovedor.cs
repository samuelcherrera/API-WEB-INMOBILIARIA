using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsTipoProovedor
    {
        private INMOBILIARIAAEntities DBinmobiliaria = new INMOBILIARIAAEntities();

public tipo_proveedor TipoProveedor { get; set; }

public string Insertar()
{
    try
    {
        DBinmobiliaria.tipo_proveedor.Add(TipoProveedor);
        DBinmobiliaria.SaveChanges();
        return "Tipo de proveedor insertado correctamente";
    }
    catch (Exception ex)
    {
        return "Error al insertar el tipo de proveedor: " + ex.Message;
    }
}

public string Actualizar()
{
    tipo_proveedor existente = ConsultarPorId(TipoProveedor.id_tipo_proveedor);
    if (existente == null)
        return "El tipo de proveedor no existe";

    DBinmobiliaria.tipo_proveedor.AddOrUpdate(TipoProveedor);
    DBinmobiliaria.SaveChanges();
    return "Tipo de proveedor actualizado correctamente";
}

public tipo_proveedor ConsultarPorId(int id)
{
    return DBinmobiliaria.tipo_proveedor.FirstOrDefault(t => t.id_tipo_proveedor == id);
}

public List<tipo_proveedor> ConsultarTodos()
{
    return DBinmobiliaria.tipo_proveedor.OrderBy(t => t.descripcion).ToList();
}

public string Eliminar()
{
    try
    {
        tipo_proveedor existente = ConsultarPorId(TipoProveedor.id_tipo_proveedor);
        if (existente == null)
            return "El tipo de proveedor no existe";

        DBinmobiliaria.tipo_proveedor.Remove(existente);
        DBinmobiliaria.SaveChanges();
        return "Tipo de proveedor eliminado correctamente";
    }
    catch (Exception ex)
    {
        return "Error al eliminar el tipo de proveedor: " + ex.Message;
    }
}

public string EliminarPorId(int id)
{
    try
    {
        tipo_proveedor existente = ConsultarPorId(id);
        if (existente == null)
            return "El tipo de proveedor no existe";

        DBinmobiliaria.tipo_proveedor.Remove(existente);
        DBinmobiliaria.SaveChanges();
        return "Tipo de proveedor eliminado correctamente";
    }
    catch (Exception ex)
    {
        return "Error al eliminar el tipo de proveedor: " + ex.Message;
    }
}
    }
}
