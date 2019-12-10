using Microsoft.AspNetCore.Identity;

namespace Alduin.Logic.Identity
{
    public class AppIdentityErrorDescriber : IdentityErrorDescriber
    {
        // TODO localization
        public override IdentityError ConcurrencyFailure()
        {
            return base.ConcurrencyFailure();
        }

        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = "default_error",
                Description = "Unexpected error!"
            };
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = "duplicate_email",
                Description = "E-mail is already taken!"
            };
        }

        public override IdentityError DuplicateRoleName(string role)
        {
            return base.DuplicateRoleName(role);
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = "duplicate_username", // email == username
                Description = "E-mail is already taken!"
            };
        }

        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError
            {
                Code = "invalid_email",
                Description = "Invalid e-mail!"
            };
        }

        public override IdentityError InvalidRoleName(string role)
        {
            return base.InvalidRoleName(role);
        }

        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = "invalid_token",
                Description = "Invalid token!"
            };
        }

        public override IdentityError InvalidUserName(string userName)
        {
            return base.InvalidUserName(userName);
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return base.LoginAlreadyAssociated();
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = "password_mismatch",
                Description = "Passwords don't match!"
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "password_requires_digit",
                Description = "Password must contain a digit!"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "password_requires_lower",
                Description = "Password must contain a lowercase letter!"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "password_requires_nonalphanumeric",
                Description = "Password must contain a non-alphanumberic character! (;,* etc.)"
            };
        }

        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return base.PasswordRequiresUniqueChars(uniqueChars);
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "password_requires_upper",
                Description = "Password must contain an uppercase letter"
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "password_too_short",
                Description = $"Password is too short! It must be at least {length} characters long!"
            };
        }

        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return base.RecoveryCodeRedemptionFailed();
        }

        public override IdentityError UserAlreadyHasPassword()
        {
            return base.UserAlreadyHasPassword();
        }

        public override IdentityError UserAlreadyInRole(string role)
        {
            return base.UserAlreadyInRole(role);
        }

        public override IdentityError UserLockoutNotEnabled()
        {
            return base.UserLockoutNotEnabled();
        }

        public override IdentityError UserNotInRole(string role)
        {
            return base.UserNotInRole(role);
        }
    }
}
