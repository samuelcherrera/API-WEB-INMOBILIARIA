using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsArriendo
    {
        private INMOBILIARIAAEntities inmobiliaria = new INMOBILIARIAAEntities();
        public arriendo arriendo { get; set; }

        public String Insertar()

        {

            try

            {

                inmobiliaria.arriendoes.Add(arriendo);

                inmobiliaria.SaveChanges();

                return "Arriendo ingresado correctamente " + arriendo.deposito;

            }

            catch (Exception ex)

            {

                return "error al ingresar el rriendo " + ex.Message;
            }
        }

        public List<arriendo> ConsultarTodos()

        {

            return inmobiliaria.arriendoes

                .OrderBy(e => e.id_arriendo)

                .ToList();
        }

        public arriendo Consultar(int IdArriendo)
        {

            arriendo arriendo = inmobiliaria.arriendoes.FirstOrDefault(e => e.id_arriendo == IdArriendo);

            return arriendo;

        }

        public String Actualizar()
        {

            arriendo cli = Consultar(arriendo.id_arriendo);

            if (cli == null)

            {

                return "El arriendo no existe";

            }

            inmobiliaria.arriendoes.AddOrUpdate(arriendo);

            inmobiliaria.SaveChanges();

            return "se ha actualizado el arriendo correctamente";
        }


        public String Eliminar()

        {

            try
            {

                arriendo cli = Consultar(arriendo.id_arriendo);

                if (cli == null)

                {

                    return "El arriendo no existe";

                }

                inmobiliaria.arriendoes.Remove(arriendo);

                inmobiliaria.SaveChanges();

                return "se ha actualizado el arriendo correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }

        }

        public String EliminarXId(int IdArriendo)

        {

            try
            {

                arriendo arriendo = Consultar(IdArriendo);

                if (arriendo == null)

                {

                    return "El arriendo no existe";

                }

                inmobiliaria.arriendoes.Remove(arriendo);

                inmobiliaria.SaveChanges();

                return "se ha eliminado el arriendo correctamente";

            }

            catch (Exception ex)

            {

                return ex.Message;

            }


        }
    }
}