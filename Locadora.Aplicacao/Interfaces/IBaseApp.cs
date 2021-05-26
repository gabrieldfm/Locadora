using Locadora.Aplicacao.Dto.Base;
using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.Interfaces
{
    public interface IBaseApp<TEntidade, TEntidadeDto>
        where TEntidade :EntidadeBase
        where TEntidadeDto : DtoBase
    {
        IEnumerable<TEntidadeDto> BuscarTodos();
        TEntidadeDto BuscarPorId(int id);              
        void ExcluirPorId(int id);
        void ExcluirVarios(List<int> ids);
    }
}
