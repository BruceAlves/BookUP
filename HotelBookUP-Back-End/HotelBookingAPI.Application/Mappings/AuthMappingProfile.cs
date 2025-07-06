using AutoMapper;
using HotelBookingAPI.Domain;
using HotelBookingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingAPI.Presentation;

namespace HotelBookingAPI.Application.Mappings
{
    public class AuthMappingProfile : Profile
    {
        public AuthMappingProfile()
        {
            CreateMap<User, UserLoginDto>();
            CreateMap<Accommodation, AccommodationDto>();
            CreateMap<Flight, FlightDto>();
            CreateMap<Cars, CarsDto>();
            CreateMap<TravelPackages, TravelPackagesDto>();
        }
    }
}
