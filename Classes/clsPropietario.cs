using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsPropietario
    {
        private INMOBILIARIAAEntities DBinmobiliaria = new INMOBILIARIAAEntities();

public propietario propietario { get; set; }

public string Insertar()
{
    try
    {
        DBinmobiliaria.propietarios.Add(propietario);
        DBinmobiliaria.SaveChanges();
        return "Propietario insertado correctamente";
    }
    catch (Exception ex)
    {
        string mensajeError = "Error al insertar el propietario: " + ObtenerMensajesExcepcion(ex);
        return mensajeError;
    }
}

private string ObtenerMensajesExcepcion(Exception ex)
{
    string mensaje = ex.Message;
    if (ex.InnerException != null)
    {
        mensaje += " | Interna: " + ObtenerMensajesExcepcion(ex.InnerException);
    }
    return mensaje;
}



public string Actualizar()
{
    propietario prop = Consultar(propietario.identificacion);
    if (prop == null)
    {
        return "La identificación del propietario no es válida";
    }

    DBinmobiliaria.propietarios.AddOrUpdate(propietario);
    DBinmobiliaria.SaveChanges();
    return "Propietario actualizado correctamente";
}

public propietario Consultar(string identificacion)
{
    return DBinmobiliaria.propietarios.FirstOrDefault(p => p.identificacion == identificacion);
}

public List<propietario> ConsultarTodos()
{
    return DBinmobiliaria.propietarios
        .OrderBy(p => p.apellidos)
        .ToList();
}

public string Eliminar()
{
    try
    {
        propietario prop = Consultar(propietario.identificacion);
        if (prop == null)
        {
            return "La identificación del propietario no es válida";
        }

        DBinmobiliaria.propietarios.Remove(prop);
        DBinmobiliaria.SaveChanges();
        return "Propietario eliminado correctamente";
    }
    catch (Exception ex)
    {
        return "Error al eliminar el propietario: " + ex.Message;
    }
}

public string EliminarPorIdentificacion(string identificacion)
{
    try
    {
        propietario prop = Consultar(identificacion);
        if (prop == null)
        {
            return "La identificación del propietario no es válida";
        }

        DBinmobiliaria.propietarios.Remove(prop);
        DBinmobiliaria.SaveChanges();
        return "Propietario eliminado correctamente";
    }
    catch (Exception ex)
    {
        return "Error al eliminar el propietario: " + ex.Message;
    }
}
    }
}
