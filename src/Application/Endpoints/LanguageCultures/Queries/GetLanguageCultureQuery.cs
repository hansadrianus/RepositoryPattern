using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.LanguageCultures.Queries
{
    public class GetLanguageCultureQuery : IRequest<EndpointResult<IEnumerable<LanguageCultureViewModel>>>
    {
        public int? Id { get; set; }
        public int? LCID { get; set; }
        public string? Description { get; set; }
        public bool? IsDefaultLanguage { get; set; }
    }
}
