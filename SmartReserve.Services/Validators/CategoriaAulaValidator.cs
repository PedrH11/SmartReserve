using FluentValidation;
using SmartReserve.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartReserve.Services.Validators
{
    public class CategoriaAulaValidator : AbstractValidator<CategoriaAula>
    {
        public CategoriaAulaValidator()
        {
            RuleFor(c => c.nome)
                .NotEmpty().WithMessage("Por favor informe o nome")
                .NotNull().WithMessage("Por favor informe o nome");
        }
    }
}
