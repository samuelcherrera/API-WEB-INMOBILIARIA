﻿using API_WEB_INMOBILIARIA.Classes;
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
    [Authorize]
    [RoutePrefix("api/Empleados")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    /*  RoutPrefix, es una directiva que se define antes de la clase, y se utiliza para definir la ruta base de la API.
    *  GET: Se utiliza para consultar información. SELECT
    *  POST: Se utiliza para insertar información: INSERT INTO
    *  PUT: Se utiliza para actualizar información: UPDATE
    *  DELETE: Se utiliza para eliminar información: DELETE
    */
    public class EmpleadosController : ApiController
    {
        /*  Primero se define el método que se va a exponer: HttpGet, HttpPost, HttpPut, HttpDelete 
         *  Luego se define la ruta del método: Route
         *  Finalmente, se define el método que se va a ejecutar
         *  F11, es para depurar línea a línea, se va a los métodos o funciones que se invocan
         *  F10, es para depurar por bloques, las llamadas a los métodos internos no pasan al depurar.
         */
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<empleado> ConsultarTodos()
        {
            //Se crea un objeto de la clase clsEmpleado
            clsEmpleado Empleado = new clsEmpleado();
            //Se llama al método ConsultarTodos de la clase clsEmpleado
            return Empleado.ConsultarTodos();
        }
        [HttpGet]
        [Route("ConsultarXDocumento")]
        public empleado ConsultarXDocumento(string identificacion)
        {
            clsEmpleado Empleado = new clsEmpleado();
            return Empleado.Consultar(identificacion);
        }
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] empleado empleado)
        {
            clsEmpleado Empleado = new clsEmpleado();
            //Se asigna el objeto empleado al objeto empleado de la clase clsEmpleado
            Empleado.empleado = empleado;
            //Se llama al método Insertar de la clase clsEmpleado
            return Empleado.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] empleado empleado)
        {
            clsEmpleado Empleado = new clsEmpleado();
            Empleado.empleado = empleado;
            return Empleado.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] empleado empleado)
        {
            clsEmpleado Empleado = new clsEmpleado();
            Empleado.empleado = empleado;
            return Empleado.Eliminar();
        }
        [HttpDelete]
        [Route("EliminarXDocumento")]
        public string EliminarXIdentificacion(string identificacion)
        {
            clsEmpleado Empleado = new clsEmpleado();
            return Empleado.EliminarXIdentificacion(identificacion);
        }
    }
}