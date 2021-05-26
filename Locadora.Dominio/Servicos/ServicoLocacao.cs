using Locadora.Dominio.Entidades;
using Locadora.Dominio.Interfaces.Repositorios;
using Locadora.Dominio.Interfaces.Servicos;

namespace Locadora.Dominio.Servicos
{
    public class ServicoLocacao : ServicoBase<Locacao>, IServicoLocacao
    {
        public ServicoLocacao(ILocacaoRepositorio repositorio) : base(repositorio)
        {
        }
    }
}
