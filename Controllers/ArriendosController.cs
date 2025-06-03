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
    [Authorize]
    [RoutePrefix("api/Arriendos")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ArriendosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<arriendo> ConsultarTodos()
        {
            clsArriendo arriendo = new clsArriendo();
            return arriendo.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public arriendo ConsultarXId(int IdArriendo)
        {
            clsArriendo arriendo = new clsArriendo();
            return arriendo.Consultar(IdArriendo);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] arriendo arriendo)
        {
            clsArriendo Arriendo = new clsArriendo();
            Arriendo.arriendo = arriendo;
            return Arriendo.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] arriendo arriendo)
        {
            clsArriendo Arriendo = new clsArriendo();
            Arriendo.arriendo = arriendo;
            return Arriendo.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] arriendo arriendo)
        {
            clsArriendo Arriendo = new clsArriendo();
            Arriendo.arriendo = arriendo;
            return Arriendo.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int IdArriendo)
        {
            clsArriendo Arriendo = new clsArriendo();
            return Arriendo.EliminarXId(IdArriendo);
        }

    }
}