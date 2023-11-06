using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Menus.Commands
{
    public class MenuRolesCommandValidator : AbstractValidator<MenuRolesCommand>
    {
        public MenuRolesCommandValidator()
        {
            RuleFor(x => x.AppMenuId)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.IsSelected)
                .NotNull();
        }
    }
}
