using DTOLayer.DTOs.AnnoncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnoncementValidator : AbstractValidator<AnnoncementAddDTOs>
    {
        public AnnoncementValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin.");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş geçmeyin.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Duyuru en az 5 karakter olabilir");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("İçerik en az 20 karakter olabilir");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Duyuru en fazla 50 karakter olabilir");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("İçerik en fazla 500 karakter olabilir");
        }
    }
}
