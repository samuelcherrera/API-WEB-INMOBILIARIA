using API_WEB_INMOBILIARIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_WEB_INMOBILIARIA.Classes
{
    public class clsLogin
    {
        public clsLogin()
        {
            loginRespuesta = new LoginRespuesta();
        }
        private INMOBILIARIAAEntities DBInmobiliaria = new INMOBILIARIAAEntities();
        public libLogin.Login login { get; set; }
        public LoginRespuesta loginRespuesta { get; set; }
        private bool ValidarUsuario()
        {
            try
            {

                //SE CONSULTA EL USUARIO SOLO CON EL NOMBRE, PARA OBTENER LA INFO BASICA DE USUARIO:SALT Y CLAVE ENCRIPTADA
                empleado empleado = DBInmobiliaria.empleadoes.FirstOrDefault(u => u.usuario == login.Usuario);
                if (empleado == null)
                {
                    loginRespuesta.Autenticado = false;
                    loginRespuesta.Mensaje = "Usuario no existe";
                    return false;
                }


                //SE OBTIENE LA CLAVE CIFRADA
                login.Clave = empleado.clave;
                return true;
            }
            catch (Exception ex)
            {
                loginRespuesta.Autenticado = false;
                loginRespuesta.Mensaje = ex.Message;
                return false;
            }
        }
        private bool ValidarClave()
        {
            try
            {

                //SE CONSULTA EL USUARIO CON LA CLAVE ENCRIPTADA Y EL USUARIO PARA VALIDAR SI EXISTE 
                empleado empleado = DBInmobiliaria.empleadoes.FirstOrDefault(u => u.usuario == login.Usuario && u.clave == login.Clave);
                if (empleado == null)
                {
                    //SI NO EXISTE LA CLAVE ES INCORRECTA

                    loginRespuesta.Autenticado = false;
                    loginRespuesta.Mensaje = "La clave no coincide";
                    return false;
                }

                //LA CLAVE Y EL USUARIO SON CORRECTOS
                return true;
            }

            catch (Exception ex)
            {
                loginRespuesta.Autenticado = false;
                loginRespuesta.Mensaje = ex.Message;
                return false;
            }
        }
        public IQueryable<LoginRespuesta> Ingresar()
        {
            if (ValidarUsuario() && ValidarClave())
            {
                // Obtener el estudiante autenticado
                var empleado = DBInmobiliaria.empleadoes.FirstOrDefault(E => E.usuario == login.Usuario && E.clave == login.Clave);
                if (empleado == null)
                {
                    loginRespuesta.Autenticado = false;
                    loginRespuesta.Mensaje = "Usuario no encontrado.";
                    return new List<LoginRespuesta> { loginRespuesta }.AsQueryable();
                }

                // Generar el token con el idEstudiante
                string token = TokenGenerator.GenerateTokenJwt(login.Usuario, empleado.id_empleado);

                return new List<LoginRespuesta>
    {
        new LoginRespuesta
        {
            Usuario = empleado.usuario,
            Autenticado = true,
            Perfil = empleado.nombres,
            Documento = empleado.identificacion,
            Token = token,
            Mensaje = ""
        }
    }.AsQueryable();
            }
            else
            {
                return new List<LoginRespuesta> { loginRespuesta }.AsQueryable();
            }
        }


    }
}