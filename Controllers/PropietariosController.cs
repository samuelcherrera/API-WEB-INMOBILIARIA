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
    [RoutePrefix("api/Propietarios")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    public class PropietariosController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<propietario> ConsultarTodos()
        {
            clsPropietario Propietario = new clsPropietario();
            return Propietario.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXDocumento")]
        public propietario ConsultarXDocumento(string identificacion)
        {
            clsPropietario Propietario = new clsPropietario();
            return Propietario.Consultar(identificacion);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] propietario propietario)
        {
            clsPropietario Propietario = new clsPropietario();
            Propietario.propietario = propietario;
            return Propietario.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] propietario propietario)
        {
            clsPropietario Propietario = new clsPropietario();
            Propietario.propietario = propietario;
            return Propietario.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] propietario propietario)
        {
            clsPropietario Propietario = new clsPropietario();
            Propietario.propietario = propietario;
            return Propietario.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXDocumento")]
        public string EliminarXIdentificacion(string identificacion)
        {
            clsPropietario Propietario = new clsPropietario();
            return Propietario.EliminarPorIdentificacion(identificacion);
        }
    }
}
