
using AutoMapper;
using on_the_sky.core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_the_sky.core
{
    public class MappingProfile: Profile
    {
       public MappingProfile() {

            CreateMap<Flight, FlightDto>().ReverseMap();
            CreateMap<Travels, TravelDto>().ReverseMap();
            CreateMap<Places, PlaceDto>().ReverseMap();

        }

    }
}
