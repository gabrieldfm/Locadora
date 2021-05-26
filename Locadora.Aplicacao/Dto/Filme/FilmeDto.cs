using FluentValidation;
using FluentValidation.Results;
using Locadora.Aplicacao.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.Dto.Filme
{
    public class FilmeDto : DtoBase
    {
        public string Nome { get; set; }
        public int GeneroId { get; set; }
        public int Ativo { get; set; }
        //Mantendo private set para que a data seja setada uma vez só na criação do registro
        public DateTime DataCriacao { get; private set; }

    }

    public class FilmeDtoValidator : AbstractValidator<FilmeDto>
    {
        public FilmeDtoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe o nome do filme")
                .Length(3, 200).WithMessage("O nome do filme deve conter de 3 a 200 caractres");

            RuleFor(x => x.GeneroId)
                .GreaterThan(0).WithMessage("Deve ser informado o genero do filme(consulte os generos para obter uma lista)");

            RuleFor(x => x.Ativo)
                .InclusiveBetween(0, 1).WithMessage("Apenas 0 ou 1");
        }
    }


}
