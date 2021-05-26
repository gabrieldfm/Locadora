using Locadora.Aplicacao.Dto;
using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.Interfaces
{
    public interface ILocacaoApp : IBaseApp<Locacao, LocacaoDto>
    {
        void Editar(LocacaoDto entidade);
        int Adicionar(LocacaoDto entidade);
    }
}
