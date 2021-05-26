using Locadora.Aplicacao.Dto.Filme;
using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.Interfaces
{
    public interface IFilmeApp : IBaseApp<Filme, FilmeDto>
    {
        void Editar(FilmeDto entidade);
        int Adicionar(FilmeDto entidade);
    }
}
