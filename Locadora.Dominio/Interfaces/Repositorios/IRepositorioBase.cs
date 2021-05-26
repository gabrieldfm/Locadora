using System.Collections.Generic;

namespace Locadora.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntidade>
    {
        IEnumerable<TEntidade> BuscarTodos();
        TEntidade BuscarPorId(int id);
        int Adicionar(TEntidade entidade);
        void Editar(TEntidade entidade);
        void ExcluirPorId(int id);
        void ExcluirVarios(List<int> ids);
    }
}
