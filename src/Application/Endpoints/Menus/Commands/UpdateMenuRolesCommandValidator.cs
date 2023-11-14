using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Menus.Commands
{
    public class UpdateMenuRolesCommandValidator : AbstractValidator<UpdateMenuRolesCommand>
    {
        public UpdateMenuRolesCommandValidator()
        {
            RuleFor(x => x.AppMenuId)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.IsSelected)
                .NotNull();
        }
    }
}
