using FluentValidation;
using SmartReserve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Services.Validators
{
    public class AulasValidator : AbstractValidator<Aulas>
    {
        public AulasValidator()
        {
            RuleFor(a => a.Descricao)
                .NotEmpty().WithMessage("Por favor informe a descricao.")
                .NotNull().WithMessage("Por favor informe a descricao.");

            RuleFor(a => a.Descricao)
                .NotEmpty().WithMessage("Por favor informe a capacidade.")
                .NotNull().WithMessage("Por favor informe a capacidade.");

            RuleFor(a => a.Horario)
                .NotEmpty().WithMessage("Por favor informe o horario.")
                .NotNull().WithMessage("Por favor informe o horario.");

            RuleFor(a => a.Instrutores)
                .NotEmpty().WithMessage("Por favor informe o instrutor.")
                .NotNull().WithMessage("Por favor informe o instrutor.");

            RuleFor(a => a.CategoriaAula)
                .NotEmpty().WithMessage("Por favor informe a categoria da aula.")
                .NotNull().WithMessage("Por favor informe a categoria da aula.");
        }
    }
}
