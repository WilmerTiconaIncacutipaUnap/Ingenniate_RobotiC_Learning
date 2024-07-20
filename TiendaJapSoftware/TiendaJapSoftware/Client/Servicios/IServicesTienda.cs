using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TiendaJapSoftware.Shared;

namespace TiendaJapSoftware.Client.Servicios
{
	public interface IServicesTienda
	{
		public Task<string> AltaUsuario(Usuario nuevoUsuario);
		public Task<HttpResponseMessage> ConfirmarAlta(String emailCifrado);
		public Task<HttpResponseMessage> CambiarPass(UsuarioLogIn usuarioLogin);
		public Task<Usuario> DatosUsaurio(String Email);
		public Task<List<Curso>> DameCursosUsuario(Usuario usuario);
		public Task<string> Cifrar(String Email);
		public void comprobarError(Error error);
		public Task<HttpResponseMessage> ValidarUsuario(UsuarioLogIn usuarioLogin);
		public Task<List<Curso>> DameCursos(String Email);
		public Task<List<Curso>> DameCursos();
		public Task<HttpResponseMessage> GuardarCursos(Usuario u);
		public Task<string> DesCifrar(String Email);
	}
}
