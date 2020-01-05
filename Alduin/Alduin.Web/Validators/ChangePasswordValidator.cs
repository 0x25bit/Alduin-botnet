using Alduin.Web.Models;
using FluentValidation;

namespace Alduin.Web.Validators
{
    public class ChangePasswordValidator : AbstractValidator<ChangePasswordModel>
    {
        public ChangePasswordValidator()
        {
            RuleFor(x => x.OldPassword)
                .NotEmpty().WithMessage("Password is required!");
            RuleFor(x => x.OldPassword)
                .NotEqual(x => x.NewPassword).WithMessage("Passwords match!");

            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("Password is required!");
            RuleFor(x => x.RePassword)
                .Equal(x => x.NewPassword).WithMessage("Passwords don't match!");
        }
    }
}
