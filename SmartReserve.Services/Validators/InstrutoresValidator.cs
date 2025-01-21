using FluentValidation;
using SmartReserve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Services.Validators
{
    public class InstrutoresValidator : AbstractValidator<Instrutores>
    {
        public InstrutoresValidator()
        {
            RuleFor(i => i.nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(i => i.especialidade)
                .NotEmpty().WithMessage("Por favor informe a especialidade.")
                .NotNull().WithMessage("Por favor informe a especialidade.");

            RuleFor(i => i.CPF)
                .NotEmpty().WithMessage("Por favor informe o CPF.")
                .NotNull().WithMessage("Por favor informe O CPF.");
        }
    }
}
