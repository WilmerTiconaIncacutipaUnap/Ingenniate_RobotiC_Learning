using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaJapSoftware.Shared;

namespace TiendaJapSoftware.Server.Repositorio
{
    public interface IRepositorioGeneral
    {
        public Task<Usuario> GuardarCursos(Usuario u);
        public Task<Usuario> AltaUsuario(Usuario u);
        public Task<UsuarioLogIn> ValidarUsuario(String email);
        public Task<Usuario> DameUsuario(string email);
        public Task<IEnumerable<Curso>> DameCursos(string email);
        public Task<IEnumerable<Curso>> DameCursos(int idUsuario);
        public Task<UsuarioLogIn> CambiarPass(UsuarioLogIn usuarioLogIn);
        public Task<UsuarioLogIn> ConfirmarAlta(String email);
    }
}
