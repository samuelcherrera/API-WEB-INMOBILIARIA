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
    [RoutePrefix("api/DetalleOrden")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DetalleOrdenController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodas")]
        public List<detalle_orden> ConsultarTodas()
        {
            clsDetalleOrden detalle = new clsDetalleOrden();
            return detalle.ConsultarTodas();
        }

        [HttpGet]
        [Route("ConsultarPorId")]
        public detalle_orden ConsultarPorId(int id)
        {
            clsDetalleOrden detalle = new clsDetalleOrden();
            return detalle.ConsultarPorId(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] detalle_orden detalleOrden)
        {
            clsDetalleOrden detalle = new clsDetalleOrden();
            detalle.detalle = detalleOrden;
            return detalle.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] detalle_orden detalleOrden)
        {
            clsDetalleOrden detalle = new clsDetalleOrden();
            detalle.detalle = detalleOrden;
            return detalle.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] detalle_orden detalleOrden)
        {
            clsDetalleOrden detalle = new clsDetalleOrden();
            detalle.detalle = detalleOrden;
            return detalle.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarPorId")]
        public string EliminarPorId(int id)
        {
            clsDetalleOrden detalle = new clsDetalleOrden();
            return detalle.EliminarPorId(id);
        }
    }
}