using FluentValidation;
using Layer.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Validations
{
    public class WriterDtoValidator:AbstractValidator<WriterDto>
    {
        public WriterDtoValidator()
        {
            RuleFor(x => x.WriterName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Biography).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
        }
    }
}
