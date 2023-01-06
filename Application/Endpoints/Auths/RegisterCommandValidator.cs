using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aesir.Application.Endpoints.Identity.Commands;
using FluentValidation;

namespace Application.Endpoints.Auths
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.UserName)
                .NotEmpty()
                .Length(1, 100);

            RuleFor(x => x.Email)
                .EmailAddress()
                .NotEmpty();

            RuleFor(x => x.DateOfBirth)
                .NotEmpty();

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .Length(1, 20);

            RuleFor(x => x.Password)
                .NotEmpty()
                .Equal(x => x.PasswordConfirmation)
                .MinimumLength(8);
        }
    }
}
