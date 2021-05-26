using AutoMapper;
using Locadora.Aplicacao.Dto;
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
    public class LocacaoApp : ServicoBaseApp<Locacao, LocacaoDto>, ILocacaoApp
    {
        public LocacaoApp(IMapper mapper, IServicoLocacao servico) : base(mapper, servico)
        {
        }

        public int Adicionar(LocacaoDto entidade)
        {
            return _servico.Adicionar(_mapper.Map<Locacao>(entidade));
        }
        public void Editar(LocacaoDto entidade)
        {
            _servico.Editar(_mapper.Map<Locacao>(entidade));
        }
    }
}
