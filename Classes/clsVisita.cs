using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsVisita
    {
        private INMOBILIARIAAEntities inmobiliaria = new INMOBILIARIAAEntities();
        public visita visita { get; set; }

        public String Insertar()

        {

            try

            {

                inmobiliaria.visitas.Add(visita);

                inmobiliaria.SaveChanges();

                return "Visita ingresado correctamente " + visita.fecha_hora;

            }

            catch (Exception ex)

            {

                return "error al ingresar el rriendo " + ex.Message;
            }
        }

        public List<visita> ConsultarTodos()

        {

            return inmobiliaria.visitas

                .OrderBy(e => e.id_visita)

                .ToList();
        }

        public visita Consultar(int IdVisita)
        {

            visita visita = inmobiliaria.visitas.FirstOrDefault(e => e.id_visita == IdVisita);

            return visita;

        }

        public String Actualizar()
        {

            visita cli = Consultar(visita.id_visita);

            if (cli == null)

            {

                return "la Visita no existe";

            }

            inmobiliaria.visitas.AddOrUpdate(visita);

            inmobiliaria.SaveChanges();

            return "se ha actualizado el arriendo correctamente";
        }


        public String Eliminar()

        {

            try
            {

                visita cli = Consultar(visita.id_visita);

                if (cli == null)

                {

                    return "la Visita no existe";

                }

                inmobiliaria.visitas.Remove(visita);

                inmobiliaria.SaveChanges();

                return "se ha actualizado la Visita correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }

        public String EliminarXId(int IdVisita)

        {

            try
            {

                visita arriendo = Consultar(visita.id_visita);

                if (visita == null)

                {

                    return "la Visita no existe";

                }

                inmobiliaria.visitas.Remove(visita);

                inmobiliaria.SaveChanges();

                return "se ha eliminado la Visita correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }


        }

    }
}