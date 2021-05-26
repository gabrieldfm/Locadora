using Locadora.Aplicacao.Dto;
using Locadora.Aplicacao.Dto.Genero;
using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.Interfaces
{
    public interface IGeneroApp : IBaseApp<Genero, GeneroDto>
    {
        void Editar(GeneroDto entidade);
        int Adicionar(GeneroDto entidade);
    }
}
