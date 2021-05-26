using FluentValidation;
using Locadora.Aplicacao.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Aplicacao.Dto.Genero
{
    public class GeneroDto : DtoBase
    {
        public string Nome { get; set; }
        public int Ativo { get; set; }
        //Mantendo private set para que a data seja setada uma vez só na criação do registro
        public DateTime DataCriacao { get; private set; }
    }

    public class GeneroDtoValidator : AbstractValidator<GeneroDto>
    {
        public GeneroDtoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Informe o nome do genero")
                .Length(3, 200).WithMessage("O nome do genero deve conter de 3 a 100 caractres");

            RuleFor(x => x.Ativo)
                .InclusiveBetween(0, 1).WithMessage("Apenas 0 ou 1");
        }
    }
}
