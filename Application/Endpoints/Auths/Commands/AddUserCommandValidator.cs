using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Auths.Commands
{
    public class AddUserCommandValidator : AbstractValidator<AddUserCommand>
    {
        public AddUserCommandValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.UserName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Length(1, 20);
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();
            RuleFor(x => x.DateOfBirth)
                .NotEmpty()
                .NotNull()
                .LessThanOrEqualTo(DateTime.Now.AddDays(1));
        }
    }
}
