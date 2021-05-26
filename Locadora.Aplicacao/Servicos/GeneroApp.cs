using AutoMapper;
using Locadora.Aplicacao.Dto;
using Locadora.Aplicacao.Dto.Genero;
using Locadora.Aplicacao.Interfaces;
using Locadora.Dominio.Entidades;
using Locadora.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.Servicos
{
    public class GeneroApp : ServicoBaseApp<Genero, GeneroDto>, IGeneroApp
    {
        public GeneroApp(IMapper mapper, IServicoGenero servico) : base(mapper, servico)
        {
        }

        public int Adicionar(GeneroDto entidade)
        {
            var entidadeMapeada = _mapper.Map<Genero>(entidade);
            entidadeMapeada.SetarDataCriacaoAdicao(entidadeMapeada);
            return _servico.Adicionar(entidadeMapeada);
        }

        public void Editar(GeneroDto entidade)
        {
            var dataCriacao = _servico.BuscarPorId(entidade.Id).DataCriacao;
            var entidadeMapeada = _mapper.Map<Genero>(entidade);
            entidadeMapeada.DataCriacao = dataCriacao;
            _servico.Editar(entidadeMapeada);
        }
    }
}
