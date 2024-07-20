using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaJapSoftware.Shared;

namespace TiendaJapSoftware.Server.Repositorio
{
    public interface IRepositorioMasivo
    {
        public Task<IEnumerable<Curso>> PrimerVolcadoDatos();

        public Task<IEnumerable<Curso>> DameCursos();
    }
}
