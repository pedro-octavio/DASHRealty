using DASHRealty.Domain.Entities;
using FluentValidation;

namespace DASHRealty.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("The Id cannot be null.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("The Email cannot be empty.")
                .NotNull().WithMessage("The Email cannot be null.")
                .EmailAddress().WithMessage("Insert a valid Email.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("The Password cannot be empty.")
                .NotNull().WithMessage("The Password cannot be null.")
                .Length(6, 80).WithMessage("The minimum size of the Password is 6 and the maximum is 80.");
        }
    }
}
