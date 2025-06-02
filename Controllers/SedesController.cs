using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_WEB_INMOBILIARIA.Controllers
{
    public class SedesController : ApiController
    {
        [RoutePrefix("api/Sedes")]
 [EnableCors(origins: "*", headers: "*", methods: "*")]


 // [Authorize]

 public class SedesController : ApiController

 {

     [HttpGet]

     [Route("ConsultarTodos")]
     public List<sede> ConsultarTodos()
     {

         clsSede Sede = new clsSede();

         return Sede.ConsultarTodos();

     }

     [HttpGet]
     [Route("ConsultarXId")]

     public sede ConsultarXId(int idSede)
     {

         clsSede Sede = new clsSede();

         return Sede.Consultar(idSede);

     }

     [HttpPost]

     [Route("Insertar")]
     public string Insertar([FromBody] sede sede)
     {

         clsSede Sede = new clsSede();

         Sede.sede = sede;

         return Sede.Insertar();

     }

     [HttpPut]

     [Route("Actualizar")]
     public string Actualizar([FromBody] sede sede)
     {

         clsSede Sede = new clsSede();

         Sede.sede = sede;

         return Sede.Actualizar();

     }

     [HttpDelete]

     [Route("Eliminar")]
     public string Eliminar([FromBody] sede sede)
     {

         clsSede Sede = new clsSede();

         Sede.sede = sede;

         return Sede.Eliminar();

     }

     [HttpDelete]

     [Route("EliminarXId")]
     public string EliminarXId(int idSede)
     {

         clsSede Sede = new clsSede();

         return Sede.EliminarXId(idSede);

     }

 }
}
