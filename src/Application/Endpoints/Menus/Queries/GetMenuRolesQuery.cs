using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Menus.Queries
{
    public class GetMenuRolesQuery : IRequest<EndpointResult<IEnumerable<MenuRoleViewModel>>>
    {
        public int? AppMenuId { get; set; }
        public string? MenuName { get; set; }
        public int? RoleId { get; set; }
        public bool? IsSelected { get; set; }
        public short? RowStatus { get; set; }
    }
}
