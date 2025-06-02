using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsImagenesPropiedad
    {
        internal string id_propiedad;

        public List<string> Archivos { get; internal set; }

        internal string GrabarImagenes()
        {
            throw new NotImplementedException();
        }
    }
}