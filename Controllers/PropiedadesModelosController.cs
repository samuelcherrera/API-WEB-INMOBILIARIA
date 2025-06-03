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
   [RoutePrefix("api/PropiedadModelo")]
    [Authorize]

    [EnableCors(origins: "*", headers: "*", methods: "*")]
public class PropiedadModeloController : ApiController
{
    [HttpGet]
    [Route("ConsultarTodas")]
    public List<propiedad_modelo> ConsultarTodas()
    {
        clsPropiedadModelo modelo = new clsPropiedadModelo();
        return modelo.ConsultarTodas();
    }

    [HttpGet]
    [Route("ConsultarPorId")]
    public propiedad_modelo ConsultarPorId(int id)
    {
        clsPropiedadModelo modelo = new clsPropiedadModelo();
        return modelo.ConsultarPorId(id);
    }

    [HttpPost]
    [Route("Insertar")]
    public string Insertar([FromBody] propiedad_modelo modeloJson)
    {
        clsPropiedadModelo modelo = new clsPropiedadModelo();
        modelo.propiedadModelo = modeloJson;
        return modelo.Insertar();
    }

    [HttpPut]
    [Route("Actualizar")]
    public string Actualizar([FromBody] propiedad_modelo modeloJson)
    {
        clsPropiedadModelo modelo = new clsPropiedadModelo();
        modelo.propiedadModelo = modeloJson;
        return modelo.Actualizar();
    }

    [HttpDelete]
    [Route("Eliminar")]
    public string Eliminar([FromBody] propiedad_modelo modeloJson)
    {
        clsPropiedadModelo modelo = new clsPropiedadModelo();
        modelo.propiedadModelo = modeloJson;
        return modelo.Eliminar();
    }

    [HttpDelete]
    [Route("EliminarPorId")]
    public string EliminarPorId(int id)
    {
        clsPropiedadModelo modelo = new clsPropiedadModelo();
        return modelo.EliminarPorId(id);
    }
}
}
