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
    [RoutePrefix("api/Clientes")]
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClientesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<cliente> ConsultarTodos()
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXDocumento")]
        public cliente ConsultarXDocumento(string identificacion)
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.Consultar(identificacion);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXDocumento")]
        public string EliminarXDocumento(string identificacion)
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.EliminarXIdentificacion(identificacion);
        }
    }
}