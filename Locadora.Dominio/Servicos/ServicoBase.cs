using Locadora.Dominio.Entidades;
using Locadora.Dominio.Interfaces.Repositorios;
using Locadora.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace Locadora.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        protected readonly IRepositorioBase<TEntidade> _repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }

        public int Adicionar(TEntidade entidade)
        {
            return _repositorio.Adicionar(entidade);
        }

        public TEntidade BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public IEnumerable<TEntidade> BuscarTodos()
        {
            return _repositorio.BuscarTodos();
        }

        public void Editar(TEntidade entidade)
        {
            _repositorio.Editar(entidade);
        }

        public void ExcluirPorId(int id)
        {
            _repositorio.ExcluirPorId(id);
        }

        public void ExcluirVarios(List<int> ids)
        {
            _repositorio.ExcluirVarios(ids);
        }
    }
}
