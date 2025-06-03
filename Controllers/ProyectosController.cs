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
[RoutePrefix("api/Proyectos")]
[EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]

    public class ProyectosController : ApiController
{
    [HttpGet]
    [Route("ConsultarTodos")]
    public List<proyecto> ConsultarTodos()
    {
        clsProyecto obj = new clsProyecto();
        return obj.ConsultarTodos();
    }

    [HttpGet]
    [Route("ConsultarPorId")]
    public proyecto ConsultarPorId(int id)
    {
        clsProyecto obj = new clsProyecto();
        return obj.ConsultarPorId(id);
    }

    [HttpPost]
    [Route("Insertar")]
    public string Insertar([FromBody] proyecto proy)
    {
        clsProyecto obj = new clsProyecto();
        obj.Proyecto = proy;
        return obj.Insertar();
    }

    [HttpPut]
    [Route("Actualizar")]
    public string Actualizar([FromBody] proyecto proy)
    {
        clsProyecto obj = new clsProyecto();
        obj.Proyecto = proy;
        return obj.Actualizar();
    }

    [HttpDelete]
    [Route("Eliminar")]
    public string Eliminar([FromBody] proyecto proy)
    {
        clsProyecto obj = new clsProyecto();
        obj.Proyecto = proy;
        return obj.Eliminar();
    }

    [HttpDelete]
    [Route("EliminarPorId")]
    public string EliminarPorId(int id)
    {
        clsProyecto obj = new clsProyecto();
        return obj.EliminarPorId(id);
    }
}
}
