using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleStoneExercise.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
           //CreateMap<Name, DTO>()
            //    .ForMember(dest => dest.First, opt => opt.MapFrom(src => src.name.First))
            //    .ForMember(dest => dest.Middle, opt => opt.MapFrom(src => src.name.Middle))
            //    .ForMember(dest => dest.Last, opt => opt.MapFrom(src => src.name.Last))
            //    .ForMember(dest => dest.Addresses, opt => opt.MapFrom(src => src.address));
        }
    }
}
