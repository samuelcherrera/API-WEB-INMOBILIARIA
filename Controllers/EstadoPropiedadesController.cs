using API_WEB_INMOBILIARIA.Classes;
using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_WEB_INMOBILIARIA.Controllers
{
    [RoutePrefix("api/estadoPropiedades")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EstadoPropiedadesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<estado_propiedad> ConsultarTodos()
        {
            clsEstadoPropiedad estadoPropiedad = new clsEstadoPropiedad();
            return estadoPropiedad.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public estado_propiedad ConsultarXId(int id)
        {
            clsEstadoPropiedad estadoPropiedad = new clsEstadoPropiedad();
            return estadoPropiedad.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] estado_propiedad Estado_Propiedad)
        {
            clsEstadoPropiedad estadoPropiedad = new clsEstadoPropiedad
            {
                Estado_Propiedad = Estado_Propiedad
            };

            return estadoPropiedad.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] estado_propiedad Estado_Propiedad)
        {
            clsEstadoPropiedad estadoPropiedad = new clsEstadoPropiedad
            {
                Estado_Propiedad = Estado_Propiedad
            };

            return estadoPropiedad.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] estado_propiedad Estado_Propiedad)
        {
            clsEstadoPropiedad estadoPropiedad = new clsEstadoPropiedad
            {
                Estado_Propiedad = Estado_Propiedad
            };

            return estadoPropiedad.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id)
        {
            clsEstadoPropiedad estadoPropiedad = new clsEstadoPropiedad();
            return estadoPropiedad.EliminarXid(id);
        }
    }
}