using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsTipo_Propiedad
    {
        private INMOBILIARIAAEntities DBInmobiliaria = new INMOBILIARIAAEntities();
public tipo_propiedad Tipo_Propiedad { get; set; }
public String Insertar()
{
    try
    {
        DBInmobiliaria.tipo_propiedad.Add(Tipo_Propiedad);
        DBInmobiliaria.SaveChanges();
        return "Tipo de Propiedad ingresada correctamente " + Tipo_Propiedad.descripcion;
    }
    catch (Exception ex)
    {
        return "error al insertar el tipo de propiedad " + ex.Message;
    }

}

public String Actualizar()
{
    tipo_propiedad tprop = Consultar(Tipo_Propiedad.id_tipo_propiedad);
    if (tprop == null)
    {
        return "el id no es valido";
    }
    DBInmobiliaria.tipo_propiedad.AddOrUpdate(Tipo_Propiedad);
    DBInmobiliaria.SaveChanges();
    return "se ha actualizado el tipo de propiedad correctamente";


}
public tipo_propiedad Consultar(int id)
{
    tipo_propiedad tprop = DBInmobiliaria.tipo_propiedad.FirstOrDefault(e => e.id_tipo_propiedad == id);
    return tprop;
}

public List<tipo_propiedad> ConsultarTodos()
{
    return DBInmobiliaria.tipo_propiedad
        .OrderBy(e => e.descripcion)
        .ToList();
}

public String Eliminar()
{
    try
    {
        tipo_propiedad tprop = Consultar(Tipo_Propiedad.id_tipo_propiedad);
        if (tprop == null)
        {
            return "el id no es valido";
        }
        DBInmobiliaria.tipo_propiedad.Remove(tprop);
        DBInmobiliaria.SaveChanges();
        return "se ha eliminado el tipo de propiedad correctamente";

    }
    catch (Exception ex)
    {
        return ex.Message;
    }
}

public String EliminarXid(int id)
{
    try
    {
        tipo_propiedad tprop = Consultar(id);
        if (tprop == null)
        {
            return "el id no es valido";
        }
        DBInmobiliaria.tipo_propiedad.Remove(tprop);
        DBInmobiliaria.SaveChanges();
        return "se ha eliminado el tipo de propiedad correctamente";

    }
    catch (Exception ex)
    {
        return ex.Message;
    }


}
    }
}
