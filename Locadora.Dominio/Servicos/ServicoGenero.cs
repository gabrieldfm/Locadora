using Locadora.Dominio.Entidades;
using Locadora.Dominio.Interfaces.Repositorios;
using Locadora.Dominio.Interfaces.Servicos;

namespace Locadora.Dominio.Servicos
{
    public class ServicoGenero : ServicoBase<Genero>, IServicoGenero
    {
        public ServicoGenero(IGeneroRepositorio repositorio) : base(repositorio)
        {
        }
    }
}
