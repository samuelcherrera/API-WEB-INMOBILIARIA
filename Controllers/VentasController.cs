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
    [RoutePrefix("api/Ventas")]
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class VentasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<venta> ConsultarTodos()
        {
            clsVenta Venta = new clsVenta();
            return Venta.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXId")]
        public venta ConsultarXId(int idVenta)
        {
            clsVenta Venta = new clsVenta();
            return Venta.Consultar(idVenta);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] venta venta)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = venta;
            return Venta.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] venta venta)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = venta;
            return Venta.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] venta venta)
        {
            clsVenta Venta = new clsVenta();
            Venta.venta = venta;
            return Venta.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int idVenta)
        {
            clsVenta Venta = new clsVenta();
            return Venta.EliminarXId(idVenta);
        }
    }
}