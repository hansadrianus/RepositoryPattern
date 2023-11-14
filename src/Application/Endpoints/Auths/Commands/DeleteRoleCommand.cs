using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Auths.Commands
{
    public class DeleteRoleCommand : IRequest<EndpointResult<RoleViewModel>>
    {
        public Guid Uid { get; set; }
    }
}
