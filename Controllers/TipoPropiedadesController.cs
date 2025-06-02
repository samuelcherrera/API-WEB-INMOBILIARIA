using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_WEB_INMOBILIARIA.Controllers
{
    [RoutePrefix("api/TipoPropiedades")]
[EnableCors(origins: "*", headers: "*", methods: "*")]

public class TipoPropiedadesController : ApiController

{
    [HttpGet]
    [Route("ConsultarTodos")]
    public List<tipo_propiedad> ConsultarTodos()
    {
        clsTipo_Propiedad TipoPropiedad = new clsTipo_Propiedad();

        return TipoPropiedad.ConsultarTodos();
    }


    [HttpGet]
    [Route("ConsultarXId")]
    public tipo_propiedad ConsultarXDocumento(int id)
    {
        clsTipo_Propiedad TipoPropiedad = new clsTipo_Propiedad();

        return TipoPropiedad.Consultar(id);
    }


    [HttpPost]
    [Route("Insertar")]
    public string Insertar([FromBody] tipo_propiedad Tipo_Propiedad)
    {
        clsTipo_Propiedad _TipoPropiedad = new clsTipo_Propiedad();
        _TipoPropiedad.Tipo_Propiedad = Tipo_Propiedad;

        return _TipoPropiedad.Insertar();
    }


    [HttpPut]
    [Route("Actualizar")]
    public string Actualizar([FromBody] tipo_propiedad Tipo_Propiedad)
    {
        clsTipo_Propiedad _TipoPropiedad = new clsTipo_Propiedad();
        _TipoPropiedad.Tipo_Propiedad = Tipo_Propiedad;

        return _TipoPropiedad.Actualizar();
    }


    [HttpDelete]
    [Route("Eliminar")]
    public string Eliminar([FromBody] tipo_propiedad Tipo_Propiedad)
    {
        clsTipo_Propiedad _TipoPropiedad = new clsTipo_Propiedad();
        _TipoPropiedad.Tipo_Propiedad = Tipo_Propiedad;

        return _TipoPropiedad.Eliminar();
    }


    [HttpDelete]
    [Route("EliminarXId")]
    public string EliminarXDocumento(int id)
    {
        clsTipo_Propiedad _TipoPropiedad = new clsTipo_Propiedad();
        return _TipoPropiedad.EliminarXid(id);
    }
}
}
