using AutoMapper;
using Locadora.Aplicacao.Dto.Filme;
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
    public class FilmeApp : ServicoBaseApp<Filme, FilmeDto>, IFilmeApp
    {
        public FilmeApp(IMapper mapper, IServicoFilme servico) : base(mapper, servico)
        {
        }

        public int Adicionar(FilmeDto entidade)
        {
            var entidadeMapeada = _mapper.Map<Filme>(entidade);
            entidadeMapeada.SetarDataCriacaoAdicao(entidadeMapeada);
            return _servico.Adicionar(entidadeMapeada);
        }

        public void Editar(FilmeDto entidade)
        {
            var dataCriacao = _servico.BuscarPorId(entidade.Id).DataCriacao;
            var entidadeMapeada = _mapper.Map<Filme>(entidade);
            entidadeMapeada.DataCriacao = dataCriacao;
            _servico.Editar(entidadeMapeada);
        }
    }
}
