using API_WEB_INMOBILIARIA.Classes;
using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_WEB_INMOBILIARIA.Controllers
{
    [RoutePrefix("api/Propiedades")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]


    public class PropiedadesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodas")]
        public List<propiedad> ConsultarTodas()
        {
            clsPropiedad Propiedad = new clsPropiedad();
            return Propiedad.ConsultarTodas();
        }

        [HttpGet]
        [Route("ConsultarPorId")]
        public propiedad ConsultarPorId(int id)
        {
            clsPropiedad Propiedad = new clsPropiedad();
            return Propiedad.ConsultarPorId(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] propiedad propiedad)
        {
            clsPropiedad Propiedad = new clsPropiedad();
            Propiedad.propiedad = propiedad;
            return Propiedad.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] propiedad propiedad)
        {
            clsPropiedad Propiedad = new clsPropiedad();
            Propiedad.propiedad = propiedad;
            return Propiedad.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] propiedad propiedad)
        {
            clsPropiedad Propiedad = new clsPropiedad();
            Propiedad.propiedad = propiedad;
            return Propiedad.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarPorId")]
        public string EliminarPorId(int id)
        {
            clsPropiedad Propiedad = new clsPropiedad();
            return Propiedad.EliminarPorId(id);
        }
    }
}

