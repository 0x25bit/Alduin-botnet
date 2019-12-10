using FluentValidation;
using Alduin.Shared.DTOs;

namespace Alduin.Web.Validators
{
    public class UserDTOValidator : AbstractValidator<UserDTO>
    {
        public UserDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required!");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("E-mail is required!")
                .EmailAddress().WithMessage("Format is incorrect!");
        }
    }
}
