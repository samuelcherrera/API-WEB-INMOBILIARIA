using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsEmpleado
    {
        private INMOBILIARIAAEntities DBinmobilaria = new INMOBILIARIAAEntities();

        public empleado empleado { get; set; }

        public string Insertar()
        {
            try
            {
                DBinmobilaria.empleadoes.Add(empleado);
                DBinmobilaria.SaveChanges();
                return "Empleado insertado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al insertar el empleado: " + ex.Message;
            }
        }
        public string Actualizar()
        {
            empleado emp = Consultar(empleado.identificacion);
            if (emp == null)
            {
                return "la identificación del empleado no es válido";
            }
            DBinmobilaria.empleadoes.AddOrUpdate(empleado);
            DBinmobilaria.SaveChanges();
            return "Se actualizó el empleado correctamente";
        }
        public empleado Consultar(string identificacion)
        {
            empleado emp = DBinmobilaria.empleadoes.FirstOrDefault(e => e.identificacion == identificacion);
            return emp;
        }
        public List<empleado> ConsultarTodos()
        {
            return DBinmobilaria.empleadoes
                .OrderBy(e => e.apellidos)
                .ToList();
        }
        public string Eliminar()
        {
            try
            {
                empleado emp = Consultar(empleado.identificacion);
                if (emp == null)
                {
                    return "la identificación del empleado no es válida";
                }
                DBinmobilaria.empleadoes.Remove(emp);
                DBinmobilaria.SaveChanges();
                return "se eliminó el empleado correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string EliminarXIdentificacion(string identificacion)
        {
            try
            {
                empleado emp = Consultar(identificacion);
                if (emp == null)
                {
                    return "El documento del empleado no es válido";
                }
                DBinmobilaria.empleadoes.Remove(emp);
                DBinmobilaria.SaveChanges();
                return "se eliminó el empleado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}