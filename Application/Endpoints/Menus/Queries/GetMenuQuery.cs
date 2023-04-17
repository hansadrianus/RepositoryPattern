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
    public class GetMenuQuery : IRequest<EndpointResult<IEnumerable<MenuViewModel>>>
    {
        public int? Id { get; set; }
        public string? MenuName { get; set; }
        public short? RowStatus { get; set; }
    }
}
