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
    [RoutePrefix("api/Consignaciones")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    public class ConsignacionesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<consignacion> ConsultarTodos()
        {
            clsConsignacion Consignacion = new clsConsignacion();
            return Consignacion.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public consignacion ConsultarXId(int id)
        {
            clsConsignacion Consignacion = new clsConsignacion();
            return Consignacion.Consultar(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] consignacion consignacion)
        {
            clsConsignacion Consignacion = new clsConsignacion();
            Consignacion.consignacion = consignacion;
            return Consignacion.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] consignacion consignacion)
        {
            clsConsignacion Consignacion = new clsConsignacion();
            Consignacion.consignacion = consignacion;
            return Consignacion.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] consignacion consignacion)
        {
            clsConsignacion Consignacion = new clsConsignacion();
            Consignacion.consignacion = consignacion;
            return Consignacion.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id)
        {
            clsConsignacion Consignacion = new clsConsignacion();
            return Consignacion.EliminarXId(id);
        }
    }
}