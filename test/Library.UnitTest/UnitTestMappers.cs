using Application.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UnitTest
{
    public class UnitTestMappers
    {
        public IMapper GetMapper<TMapper>() where TMapper : Profile, new()
        {
            TMapper mappingProfile = new TMapper();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
            return new Mapper(configuration);
        }
    }
}
