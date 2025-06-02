using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsCiudad
    {

        private INMOBILIARIAAEntities DBInmobiliaria = new INMOBILIARIAAEntities();
        public ciudad Ciudad { get; set; }
        public String Insertar()
        {
            try
            {
                DBInmobiliaria.ciudads.Add(Ciudad);
                DBInmobiliaria.SaveChanges();
                return "Ciudad ingresada correctamente " + Ciudad.id_ciudad;
            }
            catch (Exception ex)
            {
                return "error al insertar la propiedad " + ex.Message;
            }

        }

        public String Actualizar()
        {
            ciudad ciu = Consultar(Ciudad.id_ciudad);
            if (ciu == null)
            {
                return "el id no es valido";
            }
            DBInmobiliaria.ciudads.AddOrUpdate(Ciudad);
            DBInmobiliaria.SaveChanges();
            return "se ha actualizado la propiedad correctamente";


        }
        public ciudad Consultar(int id)
        {
            ciudad ciu = DBInmobiliaria.ciudads.FirstOrDefault(e => e.id_ciudad == id);
            return ciu;
        }

        public List<ciudad> ConsultarTodos()
        {
            return DBInmobiliaria.ciudads
                .OrderBy(e => e.nombre)
                .ToList();
        }

        public String Eliminar()
        {
            try
            {
                ciudad ciu = Consultar(Ciudad.id_ciudad);
                if (ciu == null)
                {
                    return "el id no es valido";
                }
                DBInmobiliaria.ciudads.Remove(ciu);
                DBInmobiliaria.SaveChanges();
                return "se ha eliminado la ciudad correctamente";

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
                ciudad ciu = Consultar(id);
                if (ciu == null)
                {
                    return "el id no es valido";
                }
                DBInmobiliaria.ciudads.Remove(ciu);
                DBInmobiliaria.SaveChanges();
                return "se ha eliminado la ciudad correctamente";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
    }
}