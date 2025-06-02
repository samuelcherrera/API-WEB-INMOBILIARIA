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
    [RoutePrefix("api/TipoVisita")]
    //[Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class TipoVisitaController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<tipo_visita> ConsultarTodos()
        {
            clsTipoVisita tipoVisita = new clsTipoVisita();
            return tipoVisita.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public tipo_visita ConsultarXId(int idTipoVisita)
        {
            clsTipoVisita tipoVisita = new clsTipoVisita();
            return tipoVisita.Consultar(idTipoVisita);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] tipo_visita tipoVisitaObj)
        {
            clsTipoVisita tipoVisita = new clsTipoVisita();
            tipoVisita.tipoVisita = tipoVisitaObj;
            return tipoVisita.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] tipo_visita tipoVisitaObj)
        {
            clsTipoVisita tipoVisita = new clsTipoVisita();
            tipoVisita.tipoVisita = tipoVisitaObj;
            return tipoVisita.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] tipo_visita tipoVisitaObj)
        {
            clsTipoVisita tipoVisita = new clsTipoVisita();
            tipoVisita.tipoVisita = tipoVisitaObj;
            return tipoVisita.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int idTipoVisita)
        {
            clsTipoVisita tipoVisita = new clsTipoVisita();
            return tipoVisita.EliminarXId(idTipoVisita);
        }
    }
}