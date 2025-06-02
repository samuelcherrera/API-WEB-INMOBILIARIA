using API_WEB_INMOBILIARIA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_WEB_INMOBILIARIA.Controllers
{
    [RoutePrefix("UploadFiles")]
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class UploadFilesController : ApiController
    {
        [HttpPost]
        public async Task<HttpResponseMessage> GrabarArchivo(HttpRequestMessage Request, string Datos, string Proceso)
        {
            clsUpload UploadFiles = new clsUpload();
            UploadFiles.request = Request;
            UploadFiles.Datos = Datos;
            UploadFiles.Proceso = Proceso;
            return await UploadFiles.GrabaArchivo(false);
        }
        [HttpGet]
        public HttpResponseMessage Get(string NombreImagen)
        {
            clsUpload upload = new clsUpload();
            return upload.ConsultarArchivo(NombreImagen);
        }
        [HttpPut]
        public async Task<HttpResponseMessage> ActualizarArchivo(HttpRequestMessage Request, string Datos, string Proceso)
        {
            clsUpload UploadFiles = new clsUpload();
            UploadFiles.request = Request;
            UploadFiles.Datos = Datos;
            UploadFiles.Proceso = Proceso;
            return await UploadFiles.GrabaArchivo(true);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public HttpResponseMessage EliminarArchivo(string NombreImagen)
        {
            clsUpload UploadFiles = new clsUpload();
            return UploadFiles.EliminarArchivo(NombreImagen);
        }
    }
}