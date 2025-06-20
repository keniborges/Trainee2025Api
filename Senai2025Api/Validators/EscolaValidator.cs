using FluentValidation;
using Senai2025Api.DTos;
using Senai2025Api.Entidades;

namespace Senai2025Api.Validators
{
    public class EscolaValidator : AbstractValidator<EscolaDTo>
    {
        public EscolaValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome da escola é obrigatório.")
                .NotNull()
                .WithMessage("O nome da escola é obrigatório.")
                .Length(1, 60)
                .WithMessage("O nome da escola deve ter entre 1 e 60 caracteres.");
        }
    }
    
}
