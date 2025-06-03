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
    [RoutePrefix("api/TipoProveedor")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]


    public class TipoProveedorController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<tipo_proveedor> ConsultarTodos()
        {
            clsTipoProovedor tp = new clsTipoProovedor();
            return tp.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarPorId")]
        public tipo_proveedor ConsultarPorId(int id)
        {
            clsTipoProovedor tp = new clsTipoProovedor();
            return tp.ConsultarPorId(id);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] tipo_proveedor proveedor)
        {
            clsTipoProovedor tp = new clsTipoProovedor();
            tp.TipoProveedor = proveedor;
            return tp.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] tipo_proveedor proveedor)
        {
            clsTipoProovedor tp = new clsTipoProovedor();
            tp.TipoProveedor = proveedor;
            return tp.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] tipo_proveedor proveedor)
        {
            clsTipoProovedor tp = new clsTipoProovedor();
            tp.TipoProveedor = proveedor;
            return tp.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarPorId")]
        public string EliminarPorId(int id)
        {
            clsTipoProovedor tp = new clsTipoProovedor();
            return tp.EliminarPorId(id);
        }
    }
}
