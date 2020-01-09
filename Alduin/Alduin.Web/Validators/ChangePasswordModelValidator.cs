using Alduin.Web.Models;
using FluentValidation;

namespace Alduin.Web.Validators
{
    public class ChangePasswordModelValidator : AbstractValidator<ChangePasswordModel>
    {
        public ChangePasswordModelValidator()
        {
            RuleFor(x => x.OldPassword)
                .NotEmpty().WithMessage("Password is required!")
                .NotEqual(x => x.NewPassword).WithMessage("Passwords match!");

            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("Password is required!")
                .Equal(x => x.RePassword).WithMessage("Passwords don't match!");
            RuleFor(x => x.RePassword)
                .NotEmpty().WithMessage("Password is required!");
        }
    }
}
