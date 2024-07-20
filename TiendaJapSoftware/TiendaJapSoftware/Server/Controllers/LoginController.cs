using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TiendaJapSoftware.Shared;

namespace TiendaJapSoftware.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<LoginController> log;
        public LoginController(IConfiguration configuration, ILogger<LoginController> l)
        {
            this.configuration = configuration;
            this.log = l;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<UsuarioAPI>> Login(LoginAPI usuarioLogin)
        {
            UsuarioAPI infoUsuario = null;
            try
            {
                infoUsuario = await AutenticarUsuarioAsync(usuarioLogin.usuarioAPI, usuarioLogin.passAPI);
                if (infoUsuario == null)
                    throw new Exception("Credenciales no válidas");
                else
                    infoUsuario = GenerarTokenJWT(infoUsuario);
            }
            catch (Exception ex)
            {
                infoUsuario = new UsuarioAPI();
                log.LogError("Se produjo un error al autenticar en el método Login" + ex.ToString());

                infoUsuario.error = new Error();
                infoUsuario.error.mensaje = ex.ToString();
                infoUsuario.error.mostrarEnPantalla = false;
            }
            return infoUsuario;
        }


        private async Task<UsuarioAPI> AutenticarUsuarioAsync(string usuario, string password)
        {

            //Validamos que el usuario exista en nuestro fichero de configuración.
            // Podriamos validarlo contra la BBDD
            if (configuration["UsuarioAPI"] == usuario && configuration["PassAPI"] == password)
            {
                return new UsuarioAPI()
                {
                    Nombre = configuration["NombreUsuario"],
                    Apellidos = configuration["ApellidosUsuario"],
                    Email = configuration["EmmailUsuario"],
                };
            }

            return null;
        }

        // Generamos Token
        private UsuarioAPI GenerarTokenJWT(UsuarioAPI usuarioInfo)
        {
            // Cabecera
            var _symmetricSecurityKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(configuration["JWT:ClaveSecreta"])
                );
            var _signingCredentials = new SigningCredentials(
                    _symmetricSecurityKey, SecurityAlgorithms.HmacSha256
                );
            var _Header = new JwtHeader(_signingCredentials);

            // Claims
            var _Claims = new[] {
                new Claim("nombre", usuarioInfo.Nombre),
                new Claim("apellidos", usuarioInfo.Apellidos),
                new Claim(JwtRegisteredClaimNames.Email, usuarioInfo.Email),
            };

            //Payload
            var _Payload = new JwtPayload(
                    issuer: configuration["JWT:Issuer"],
                    audience: configuration["JWT:Audience"],
                    claims: _Claims,
                    notBefore: DateTime.UtcNow,
                     expires: DateTime.UtcNow.AddHours(24)
                );

            // Token
            var _Token = new JwtSecurityToken(
                    _Header,
                    _Payload
                );
            usuarioInfo.Token = new JwtSecurityTokenHandler().WriteToken(_Token);

            return usuarioInfo;
        }
    }
}
