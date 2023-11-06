﻿using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class LanguageCultureProfileMapper : Profile
    {
        public LanguageCultureProfileMapper()
        {
            CreateMap<LanguageCulture, LanguageCultureViewModel>()
                .ReverseMap();
        }
    }
}
