using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsImagenesPropiedad
    {

        private INMOBILIARIAAEntities inmobiliaria = new INMOBILIARIAAEntities();
        public string id_propiedad { get; set; }
        public List<string> Archivos { get; set; }
        public string GrabarImagenes()
        {
            try
            {
                if (Archivos.Count > 0)
                {
                    foreach (string Archivo in Archivos)
                    {
                        imagen_propiedad Imagen = new imagen_propiedad();
                        Imagen.id_propiedad = Convert.ToInt32(id_propiedad);
                        Imagen.Nombre = Archivo;
                        inmobiliaria.imagen_propiedad.Add(Imagen);
                        inmobiliaria.SaveChanges();
                    }
                    return "Imagenes guardadas correctamente";
                }
                else
                {
                    return "No se enviaron archivos para guardar";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}