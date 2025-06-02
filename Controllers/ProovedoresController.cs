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
    [RoutePrefix("api/Proveedores")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProveedoresController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<proveedor> ConsultarTodos()
        {
            clsProovedor Proveedor = new clsProovedor();
            return Proveedor.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarPorId")]
        public proveedor ConsultarPorId(int id)
        {
            clsProovedor Proveedor = new clsProovedor();
            return Proveedor.ConsultarPorId(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] proveedor proveedor)
        {
            clsProovedor Proveedor = new clsProovedor();
            Proveedor.proveedor = proveedor;
            return Proveedor.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] proveedor proveedor)
        {
            clsProovedor Proveedor = new clsProovedor();
            Proveedor.proveedor = proveedor;
            return Proveedor.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] proveedor proveedor)
        {
            clsProovedor Proveedor = new clsProovedor();
            Proveedor.proveedor = proveedor;
            return Proveedor.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarPorId")]
        public string EliminarPorId(int id)
        {
            clsProovedor Proveedor = new clsProovedor();
            return Proveedor.EliminarPorId(id);
        }
    }
}