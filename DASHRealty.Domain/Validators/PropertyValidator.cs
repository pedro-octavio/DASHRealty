using DASHRealty.Domain.Entities;
using FluentValidation;

namespace DASHRealty.Domain.Validators
{
    public class PropertyValidator : AbstractValidator<Property>
    {
        public PropertyValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("The Id cannot be null.");

            RuleFor(x => x.Description)
                .MaximumLength(150).WithMessage("The maximum length of Description is 150.");

            RuleFor(x => x.Location)
                .Length(10, 80).WithMessage("The minimum size of the Name is 3 and the maximum is 100.");
        }
    }
}
