using FluentValidation;
using SmartReserve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Services.Validators
{
    public class AlunosValidator : AbstractValidator<Alunos>
    {
        public AlunosValidator()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .Length(0, 100).WithMessage("Nome pode ter no máximo 100 caracteres");

            RuleFor(u => u.Datanasc)
               .NotEmpty().WithMessage("Por favor informe a data.")
               .NotNull().WithMessage("Por favor informe a data.");

            RuleFor(u => u.CPF)
               .NotEmpty().WithMessage("Por favor informe o CPF.")
               .NotNull().WithMessage("Por favor informe o CPF.");

            RuleFor(u => u.Telefone)
               .NotEmpty().WithMessage("Por favor informe o telefone.")
               .NotNull().WithMessage("Por favor informe o telefone.");


        }
    }
}
