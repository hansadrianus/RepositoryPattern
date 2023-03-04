using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Auths.Queries
{
    public class GetUserRolesQuery : IRequest<EndpointResult<IEnumerable<UserRolesViewModel>>>
    {
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
    }
}
