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
    [RoutePrefix("api/OrdenCompra")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrdenCompraController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodas")]
        public List<orden_compra> ConsultarTodas()
        {
            clsOrdenCompra orden = new clsOrdenCompra();
            return orden.ConsultarTodas();
        }

        [HttpGet]
        [Route("ConsultarPorId")]
        public orden_compra ConsultarPorId(int id)
        {
            clsOrdenCompra orden = new clsOrdenCompra();
            return orden.ConsultarPorId(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] orden_compra ordenCompra)
        {
            clsOrdenCompra orden = new clsOrdenCompra();
            orden.ordenCompra = ordenCompra;
            return orden.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] orden_compra ordenCompra)
        {
            clsOrdenCompra orden = new clsOrdenCompra();
            orden.ordenCompra = ordenCompra;
            return orden.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] orden_compra ordenCompra)
        {
            clsOrdenCompra orden = new clsOrdenCompra();
            orden.ordenCompra = ordenCompra;
            return orden.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarPorId")]
        public string EliminarPorId(int id)
        {
            clsOrdenCompra orden = new clsOrdenCompra();
            return orden.EliminarPorId(id);
        }
    }
}