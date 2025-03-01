﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TiendaJapSoftware.Server.Repositorio;
using TiendaJapSoftware.Shared;

namespace TiendaJapSoftware.Server.Controllers
{

    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TiendaController : ControllerBase
    {
        private readonly IRepositorioMasivo masivoRepositorio;
        private readonly IRepositorioGeneral generalRepositorio;
        private readonly ILogger<RepositorioGeneral> log;
        public TiendaController(IRepositorioMasivo masivoRepositorio,
                IRepositorioGeneral generalRepositorio, ILogger<RepositorioGeneral> l)
        {
            this.masivoRepositorio = masivoRepositorio;
            this.generalRepositorio = generalRepositorio;
            this.log = l;


        }

        [Route("api/CargaInical")]
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Curso>>> CargaInical()
        {
            List<Curso> resultado = new List<Curso>();
            try
            {
                resultado = (List<Curso>)await masivoRepositorio.PrimerVolcadoDatos();


            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al cargar los datos en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al cargar los datos: " + ex.ToString());
            }

            return resultado;

        }

        [Route("api/DameCursos")]
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Curso>>> DameCursos()
        {
            List<Curso> resultado = new List<Curso>();
            try
            {
                resultado = (List<Curso>)await masivoRepositorio.DameCursos();
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al cargar los datos en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al cargar los datos: " + ex.ToString());
            }

            return resultado;

        }

        [Route("api/GuardarCursos")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Usuario>> GuardarCursos(Usuario u)
        {
            Usuario usuario = null;

            try
            {
                if (u.ListaCursos == null)
                    return BadRequest();

                usuario = await generalRepositorio.GuardarCursos(u);

            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al guardar el pedido en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al guardar el pedido: " + ex.ToString());
            }
            return usuario;
        }

        [Route("api/AltaUsuario")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Usuario>> AltaUsuario(Usuario u)
        {
            Usuario usuario = null;

            try
            {
                if (u == null)
                    return BadRequest();

                usuario = await generalRepositorio.AltaUsuario(u);

            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al dar de alta nuestro usuario en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al guardar el nuevo usuario: " + ex.ToString());

            }
            return usuario;
        }


        [Route("api/ValidarUsuario")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<UsuarioLogIn>> ValidarUsuario(UsuarioLogIn login)
        {

            UsuarioLogIn resultado = new UsuarioLogIn();
            try
            {
                if (login == null)
                    return BadRequest();

                resultado = await generalRepositorio.ValidarUsuario(login.EmailLogin);

                if (resultado == null || login.EmailLogin != resultado.EmailLogin || resultado.Password != login.Password)
                {
                    if (resultado == null)
                         resultado = new UsuarioLogIn();

                    resultado.error = new Error();
                    resultado.error.mensaje = "Credenciales no válidas";
                    resultado.error.mostrarEnPantalla = true;
                }

            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al iniciar sesión en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al iniciar sesión: " + ex.ToString());

            }
            return resultado;
        }


        [Route("api/DatosUsaurio/{email}")]
        [Authorize]
        public async Task<ActionResult<Usuario>> DatosUsaurio(string email)
        {
            Usuario u = null;
            try
            {
                u = await generalRepositorio.DameUsuario(email);

                if (u == null)
                {
                   u = new Usuario();

                    u.error = new Error();
                    u.error.mensaje = "Usuario no valido";
                    u.error.mostrarEnPantalla = true;
                }

            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al obtener usuario en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al obtener usuario: " + ex.ToString());
            }

            return u;
        }


        [Route("api/DameCursos/{email}")]
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Curso>>> DameCursos(string email)
        {
            List<Curso> resultado = new List<Curso>();
            try
            {
                resultado = (List<Curso>)await generalRepositorio.DameCursos(email);
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al cargar los datos de este usuario en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al cargar los datos de este usuario: " + ex.ToString());
            }

            return resultado;

        }

        [Route("api/DameCursosUsuario/{idUsuario}")]
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<Curso>>> DameCursosUsuario(int idUsuario)
        {
            List<Curso> resultado = new List<Curso>();
            try
            {
                resultado = (List<Curso>)await generalRepositorio.DameCursos(idUsuario);
            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al cargar los datos de este usuario en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al cargar los datos de este usuario: " + ex.ToString());
            }

            return resultado;

        }


        [Route("api/Cifrar/{cadena}")]
        [HttpGet]
        [Authorize]
        public String Cifrar(String cadena)
        {
            return Seguridad.Encriptar(cadena);
        }

        [Route("api/DesCifrar/{cadena}")]
        [HttpGet]
        [Authorize]
        public String DesCifrar(String cadena)
        {
            return Seguridad.DesEncriptar(cadena);
        }

        [Route("api/CambiarPass")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<UsuarioLogIn>> CambiarPass(UsuarioLogIn login)
        {

            UsuarioLogIn resultado = new UsuarioLogIn();
            try
            {
                if (login == null)
                    return BadRequest();

                resultado = await generalRepositorio.CambiarPass(login);

            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al cambiar password  en el controlador: " + ex.ToString());
                throw new Exception("Se produjo un error al  al cambiar password : " + ex.ToString());

            }
            return resultado;
        }

        [Route("api/ConfirmarAlta")]
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<UsuarioLogIn>> ConfirmarAlta(UsuarioLogIn login)
        {

            UsuarioLogIn resultado = new UsuarioLogIn();
            try
            {
              
                resultado = await generalRepositorio.ConfirmarAlta(login.EmailLogin);

            }
            catch (Exception ex)
            {
                log.LogError("Se produjo un error al activar el usuario : " + ex.ToString());
                throw new Exception("Se produjo un error al activar el usuario: " + ex.ToString());

            }
            return resultado;
        }

        

    }
}
