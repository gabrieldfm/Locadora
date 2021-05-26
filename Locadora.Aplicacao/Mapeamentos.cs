using AutoMapper;
using Locadora.Aplicacao.Dto;
using Locadora.Aplicacao.Dto.Filme;
using Locadora.Aplicacao.Dto.Genero;
using Locadora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao
{
    public class Mapeamentos : Profile
    {
        public Mapeamentos()
        {
            ViewParaDominio();
            DominioParaView();
        }

        private void ViewParaDominio()
        {
            CreateMap<FilmeDto, Filme>();
            CreateMap<GeneroDto, Genero>();
            CreateMap<LocacaoDto, Locacao>();
        }

        private void DominioParaView()
        {
            CreateMap<Filme, FilmeDto>();
            CreateMap<Genero, GeneroDto>();
            CreateMap<Locacao, LocacaoDto>();
        }
    }
}
