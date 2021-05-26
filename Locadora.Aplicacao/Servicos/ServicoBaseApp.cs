using AutoMapper;
using Locadora.Aplicacao.Dto.Base;
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
    public class ServicoBaseApp<TEntidade, TEntidadeDto> : IBaseApp<TEntidade, TEntidadeDto>
        where TEntidade : EntidadeBase
        where TEntidadeDto : DtoBase
    {

        protected readonly IServicoBase<TEntidade> _servico;
        protected readonly IMapper _mapper;

        public ServicoBaseApp(IMapper mapper, IServicoBase<TEntidade> servico)
        {
            _mapper = mapper;
            _servico = servico;
        }

        public TEntidadeDto BuscarPorId(int id)
        {
            return _mapper.Map<TEntidadeDto>(_servico.BuscarPorId(id));
        }

        public IEnumerable<TEntidadeDto> BuscarTodos()
        {
            return _mapper.Map<IEnumerable<TEntidadeDto>>(_servico.BuscarTodos());
        }

        public void ExcluirPorId(int id)
        {
            _servico.ExcluirPorId(id);
        }

        public void ExcluirVarios(List<int> ids)
        {
            _servico.ExcluirVarios(ids);
        }
    }
}
