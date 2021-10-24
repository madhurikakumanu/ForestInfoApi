using AutoMapper;
using ForestInfoApi.Dtos;
using ForestInfoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForestInfoApi.Profiles
{
    public class DivisionsProfile : Profile
    {
        public DivisionsProfile()
        {
            CreateMap<Division, DivisionReadDto>();
            CreateMap<DivisionCreateDto, Division>();
        }
    }
}
