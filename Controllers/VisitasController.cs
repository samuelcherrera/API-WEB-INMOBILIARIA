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
    
        [RoutePrefix("api/Visitas")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]

    public class VisitasController : ApiController

        {

            [HttpGet]

            [Route("ConsultarTodos")]

            public List<visita> ConsultarTodos()

            {

                clsVisita visita = new clsVisita();

                return visita.ConsultarTodos();

            }

            [HttpGet]

            [Route("ConsultarXId")]

            public visita ConsultarXId(int IdVisita)

            {

                clsVisita visita = new clsVisita();

                return visita.Consultar(IdVisita);

            }

            [HttpPost]

            [Route("Insertar")]

            public string Insertar([FromBody] visita visita)

            {

                clsVisita Visita = new clsVisita();

                Visita.visita = visita;

                return Visita.Insertar();

            }

            [HttpPut]

            [Route("Actualizar")]

            public string Actualizar([FromBody] visita visita)

            {

                clsVisita Visita = new clsVisita();

                Visita.visita = visita;

                return Visita.Actualizar();

            }

            [HttpDelete]

            [Route("Eliminar")]

            public string Eliminar([FromBody] visita visita)

            {

                clsVisita Visita = new clsVisita();

                Visita.visita = visita;

                return Visita.Eliminar();

            }

            [HttpDelete]

            [Route("EliminarXId")]

            public string EliminarXId(int IdVisita)

            {

                clsVisita Visita = new clsVisita();

                return Visita.EliminarXId(IdVisita);

            }

        }
}
