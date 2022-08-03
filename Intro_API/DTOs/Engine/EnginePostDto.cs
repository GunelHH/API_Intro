using System;
using FluentValidation;

namespace Intro_API.DTOs
{
    public class EnginePostDto
    {

        public string Name { get; set; }

        public string HP { get; set; }

        public string Value { get; set; }

        public short Torque { get; set; }

    }
    public class EnginePostDtoValidation : AbstractValidator<EnginePostDto>
    {
        public EnginePostDtoValidation()
        {
            RuleFor(c => c.HP).NotNull().WithMessage("You can't keep  HP field empty").MaximumLength(50).WithMessage("Length is over 50 ");
            RuleFor(c => c.Name).NotNull().WithMessage("You can't keep  Name field empty").MaximumLength(50).WithMessage("Length is over 50 ");
            RuleFor(c => c.Torque).NotNull().WithMessage("You can't keep  Torque field empty");
            RuleFor(c => c.Value).NotNull().WithMessage("You can't keep Value field empty").MaximumLength(50).WithMessage("Length is over 50 ");
        }
    }
}

