using Locadora.Dominio.Entidades;
using Locadora.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Infra.Data.Repositorios
{
    public class FilmeRepositorio : RepositorioBase<Filme>, IFilmeRepositorio
    {
        public FilmeRepositorio(Contexto.Contexto contexto) : base(contexto)
        {
        }
    }
}
