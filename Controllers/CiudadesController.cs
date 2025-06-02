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
    //[Authorize]
    [RoutePrefix("api/Ciudades")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CiudadesController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<ciudad> ConsultarTodos()
        {
            clsCiudad Ciudad = new clsCiudad();

            return Ciudad.ConsultarTodos();
        }


        [HttpGet]
        [Route("ConsultarXId")]
        public ciudad ConsultarXId(int id)
        {
            clsCiudad ciudad = new clsCiudad();
            return ciudad.Consultar(id);
        }


        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] ciudad Ciudad)
        {
            clsCiudad _Ciudad = new clsCiudad();
            _Ciudad.Ciudad = Ciudad;

            return _Ciudad.Insertar();
        }


        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] ciudad Ciudad)
        {
            clsCiudad _Ciudad = new clsCiudad();
            _Ciudad.Ciudad = Ciudad;

            return _Ciudad.Actualizar();
        }


        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] ciudad Ciudad)
        {
            clsCiudad _Ciudad = new clsCiudad();
            _Ciudad.Ciudad = Ciudad;
            return _Ciudad.Eliminar();
        }


        [HttpDelete]
        [Route("EliminarXId")]
        public string EliminarXId(int id)
        {
            clsCiudad _Ciudad = new clsCiudad();
            return _Ciudad.EliminarXid(id);
        }
    }
}