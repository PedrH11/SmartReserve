using FluentValidation;
using SmartReserve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Services.Validators
{
    public class ReservasValidator : AbstractValidator<Reservas>
    {
        public ReservasValidator()
        {
            RuleFor(r => r.HoraReserva)
                .NotEmpty().WithMessage("Por favor informe a hora da reserva.")
                .NotNull().WithMessage("Por favor informe a hora da reserva.");

            RuleFor(r => r.Alunos)
                .NotEmpty().WithMessage("Por favor informe o aluno.")
                .NotNull().WithMessage("Por favor informe o aluno.");

            RuleFor(r => r.Aulas)
                .NotEmpty().WithMessage("Por favor informe a aula.")
                .NotNull().WithMessage("Por favor informe a aula.");
        }
    }
}
