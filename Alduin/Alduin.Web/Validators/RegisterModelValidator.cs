using FluentValidation;
using Alduin.Web.Models;

namespace Alduin.Web.Validators
{
    public class RegisterModelValidator : AbstractValidator<RegisterModel>
    {
        public RegisterModelValidator()
        {
            RuleFor(x => x.User).InjectValidator();

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required!");

            RuleFor(x => x.PasswordRe)
                .Equal(x => x.Password).WithMessage("Passwords don't match!");
        }
    }
}
