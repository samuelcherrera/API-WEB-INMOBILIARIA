using API_WEB_INMOBILIARIA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_WEB_INMOBILIARIA.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/Login")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("Ingresar")]
        public IQueryable<LoginRespuesta> Ingresar(Login login)
        {
            clsLogin _Login = new clsLogin();
            _Login.login = login;

            return _Login.Ingresar();
        }

    }
}