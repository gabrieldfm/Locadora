using FluentValidation;
using Locadora.Aplicacao.Dto.Base;
using Locadora.Aplicacao.Utils;
using System;

namespace Locadora.Aplicacao.Dto
{
    public class LocacaoDto : DtoBase
    {
        private string cpfCliente;
        public string CpfCliente { get { return cpfCliente.SemFormatacao(); } set { value = cpfCliente.SemFormatacao(); } }
        public DateTime DataLocacao { get; set; }
    }

    public class LocacaoDtoValidator : AbstractValidator<LocacaoDto>
    {
        public LocacaoDtoValidator()
        {
            RuleFor(x => x.CpfCliente)
                .NotEmpty().WithMessage("Informe o CPF do cliente")
                .MaximumLength(14).WithMessage("O CPF deve conter no maximo 14 caracteres");

            RuleFor(x => x.DataLocacao)
                .GreaterThan(DateTime.Now.AddDays(-5)).WithMessage("A data de locação deve ter um intervalod de 5 dias")
                .LessThan(DateTime.Now.AddDays(5)).WithMessage("A data de locação deve ter um intervalod de 5 dias");
        }
    }
}
