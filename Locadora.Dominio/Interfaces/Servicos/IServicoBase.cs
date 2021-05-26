using Locadora.Dominio.Entidades;
using System.Collections.Generic;

namespace Locadora.Dominio.Interfaces.Servicos
{
    public interface IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        IEnumerable<TEntidade> BuscarTodos();
        TEntidade BuscarPorId(int id);
        int Adicionar(TEntidade entidade);
        void Editar(TEntidade entidade);
        void ExcluirPorId(int id);
        void ExcluirVarios(List<int> ids);
    }
}
