using FluentValidation;

namespace Application.Endpoints.Auths.Commands
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull()
                .Length(1, 100);
            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .Length(1, 100);
            RuleFor(x => x.UserName)
                .NotEmpty()
                .NotNull()
                .Length(1, 100);
            RuleFor(x => x.Email)
                .EmailAddress()
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.DateOfBirth)
                .NotEmpty()
                .NotNull()
                .LessThanOrEqualTo(DateTime.Parse(DateTime.Now.ToShortDateString()));
            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Length(1, 20);
            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .Equal(x => x.PasswordConfirmation)
                .MinimumLength(8);
        }
    }
}
