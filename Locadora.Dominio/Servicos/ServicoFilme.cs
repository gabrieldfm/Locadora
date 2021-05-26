using Locadora.Dominio.Entidades;
using Locadora.Dominio.Interfaces.Repositorios;
using Locadora.Dominio.Interfaces.Servicos;

namespace Locadora.Dominio.Servicos
{
    public class ServicoFilme : ServicoBase<Filme>, IServicoFilme
    {
        public ServicoFilme(IFilmeRepositorio repositorio) : base(repositorio)
        {
        }

    }
}
