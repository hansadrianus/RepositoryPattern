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
    public class UpdateRoleCommand : IRequest<EndpointResult<RoleViewModel>>
    {
        public Guid? Uid { get; set; }
        public string Name { get; set; }
        public short RowStatus { get; set; }
    }
}
