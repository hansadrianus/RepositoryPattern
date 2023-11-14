using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Auths.Commands
{
    public class UserRolesCommandValidator : AbstractValidator<UserRolesCommand>
    {
        public UserRolesCommandValidator()
        {
            RuleFor(x => x.RoleId)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.IsSelected)
                .NotNull();
        }
    }
}
