using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        protected MappingProfiles()
        {
            CreateMap<Pais,PaisDto>().ReverseMap();
        }
    }
}