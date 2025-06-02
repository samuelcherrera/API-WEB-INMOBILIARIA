using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsCliente
    {
        private INMOBILIARIAAEntities DBinmobiliaria = new INMOBILIARIAAEntities();

        public cliente cliente { get; set; }

        public string Insertar()
        {
            try
            {
                DBinmobiliaria.clientes.Add(cliente);
                DBinmobiliaria.SaveChanges();
                return "Cliente insertado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al insertar el cliente: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            cliente cli = Consultar(cliente.identificacion);
            if (cli == null)
            {
                return "La identificación del cliente no es válida";
            }

            DBinmobiliaria.clientes.AddOrUpdate(cliente);
            DBinmobiliaria.SaveChanges();
            return "Se actualizó el cliente correctamente";
        }

        public cliente Consultar(string identificacion)
        {
            return DBinmobiliaria.clientes.FirstOrDefault(c => c.identificacion == identificacion);
        }

        public List<cliente> ConsultarTodos()
        {
            return DBinmobiliaria.clientes
                .OrderBy(c => c.apellidos)
                .ToList();
        }

        public string Eliminar()
        {
            try
            {
                cliente cli = Consultar(cliente.identificacion);
                if (cli == null)
                {
                    return "La identificación del cliente no es válida";
                }

                DBinmobiliaria.clientes.Remove(cli);
                DBinmobiliaria.SaveChanges();
                return "Se eliminó el cliente correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: " + ex.Message;
            }
        }

        public string EliminarXIdentificacion(string identificacion)
        {
            try
            {
                cliente cli = Consultar(identificacion);
                if (cli == null)
                {
                    return "El documento del cliente no es válido";
                }

                DBinmobiliaria.clientes.Remove(cli);
                DBinmobiliaria.SaveChanges();
                return "Se eliminó el cliente correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar el cliente: " + ex.Message;
            }
        }
    }
}