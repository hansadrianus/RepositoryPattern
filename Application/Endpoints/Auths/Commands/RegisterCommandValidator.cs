using FluentValidation;

namespace Application.Endpoints.Auths.Commands
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
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now);
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
