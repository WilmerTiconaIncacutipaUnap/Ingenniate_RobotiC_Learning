using System;
using System.Threading.Tasks;
using TiendaJapSoftware.Shared;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace TiendaJapSoftware.Client.Servicios
{
    public class ServiciosTienda : IServicesTienda
    {
        IConfiguration Configuration;
        private readonly HttpClient ClienteHttp;
        private  Task<string> miToken;
        public  ServiciosTienda(HttpClient httpClient, IConfiguration configuration)
        {
            ClienteHttp = httpClient;
            Configuration = configuration;
            miToken =  ObtenerToken();
         }
        private async Task<string> ObtenerToken()
        {
             LoginAPI loginApi = new LoginAPI();

            string token = String.Empty;
            loginApi.usuarioAPI = Configuration.GetValue<string>("DatosVarios:UsuarioAPI");
            loginApi.passAPI = Configuration.GetValue<string>("DatosVarios:PassAPI");

            var respuesta =  await ClienteHttp.PostAsJsonAsync("api/Login", loginApi);

            if (respuesta.IsSuccessStatusCode)
            {
                UsuarioAPI usuarioAPI =  await respuesta.Content.ReadFromJsonAsync<UsuarioAPI>();
                comprobarError(usuarioAPI.error);
                token = usuarioAPI.Token;
               
            }
            else
                throw new Exception("Se produjo un error");

            return token;
        }
        public async Task<string> AltaUsuario(Usuario nuevoUsuario)
        {
            await miToken;
            String urlResultado = String.Empty;

            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            var respuesta = await ClienteHttp.PostAsJsonAsync("api/AltaUsuario", nuevoUsuario);

            if (respuesta.IsSuccessStatusCode)
            {
                Usuario usuarioRespuesta = await respuesta.Content.ReadFromJsonAsync<Usuario>();

                if (usuarioRespuesta.error == null || usuarioRespuesta.error.mensaje == String.Empty)
                {
                    //Generamos el enlace que llegaría  por email para confirmar el alta
                    string parametro = await ClienteHttp.GetStringAsync("api/Cifrar/" + usuarioRespuesta.Email);
                    urlResultado = "https://localhost:44312/ConfirmarAlta/" + parametro;
                }
                else
                {
                    comprobarError(usuarioRespuesta.error);
                }
            }
            else
                throw new Exception("Intentelo de nuevo se produjo un error");

            return urlResultado;
        }
        public async Task<HttpResponseMessage> ConfirmarAlta(String emailCifrado)
        {
            await miToken;
            UsuarioLogIn usuarioLogin = new UsuarioLogIn();
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            string email = await DesCifrar(emailCifrado);
            usuarioLogin.EmailLogin = email;
            usuarioLogin.Password = "NO SE UTILIZA";
            var respuesta = await ClienteHttp.PostAsJsonAsync("api/ConfirmarAlta", usuarioLogin);
            return respuesta;
        }

        public async Task<HttpResponseMessage> CambiarPass(UsuarioLogIn usuarioLogin)
        {
            await miToken;
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            var respuesta = await ClienteHttp.PostAsJsonAsync("api/CambiarPass", usuarioLogin);
            return respuesta;
        }

        public async Task<Usuario> DatosUsaurio(String Email)
        {
            await miToken;
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            return await ClienteHttp.GetFromJsonAsync<Usuario>("api/DatosUsaurio/" + Email);
       
        }

        public async Task<List<Curso>> DameCursosUsuario(Usuario usuario)
        {
            await miToken;
            List<Curso> resultado = new List<Curso>();
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            resultado = await ClienteHttp.GetFromJsonAsync<List<Curso>>("api/DameCursosUsuario/" + usuario.Id);
            if (resultado.Count > 0)
                comprobarError(resultado[0].error);

            return resultado;
        }

        public async Task<string> Cifrar(String Email)
        {
            await miToken;
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            return await ClienteHttp.GetStringAsync("api/Cifrar/" + Email);
        }

        public async Task<HttpResponseMessage> ValidarUsuario(UsuarioLogIn usuarioLogin)
        {
            await miToken;
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            return await ClienteHttp.PostAsJsonAsync("api/ValidarUsuario", usuarioLogin);
     
        }

        public async Task<List<Curso>> DameCursos(String Email)
        {
            await miToken;
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            return await ClienteHttp.GetFromJsonAsync<List<Curso>>("api/DameCursos/" + Email);
        
        }

        public async Task<List<Curso>> DameCursos()
        {
            await miToken;
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",  miToken.Result);
            return await ClienteHttp.GetFromJsonAsync<List<Curso>>("api/DameCursos");
                
        }

        public async Task<HttpResponseMessage> GuardarCursos(Usuario u)
        {
            await miToken;
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            return await ClienteHttp.PostAsJsonAsync("api/GuardarCursos", u);
        }

        public async Task<string> DesCifrar(String EmailCifrado)
        {
            await miToken;
            ClienteHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", miToken.Result);
            return await ClienteHttp.GetStringAsync("api/DesCifrar/" + EmailCifrado);

        }

        public  void comprobarError(Error error)
        {
            if (error != null)
            {
                if (error.mostrarEnPantalla)
                {
                    throw new Exception(error.mensaje);
                }
                else
                {
                    throw new Exception("Intentelo de nuevo se produjo un error");
                }
            }
        }


    }
}
