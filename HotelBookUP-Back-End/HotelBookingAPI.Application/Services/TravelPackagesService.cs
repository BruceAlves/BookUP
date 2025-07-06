using AutoMapper;
using HotelBookingAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Application;

public class TravelPackagesService
{
    private readonly ITravelPackagesRepository _travelPackagesRepository;
    private readonly IMapper _mapper;

    public TravelPackagesService(IMapper mapper, ITravelPackagesRepository travelPackagesRepository)
    {
        _mapper = mapper;
        _travelPackagesRepository = travelPackagesRepository;
    }

    public async Task<List<TravelPackagesDto>> GetAllTravelPackagesAsync()
    {
        var Packages = await _travelPackagesRepository.GetTravelPackagesAsync();
        return _mapper.Map<List<TravelPackagesDto>>(Packages);
    }

    public async Task<List<TravelPackagesDto>> GetTravelPackagesOfferAsync()
    {
        var travelPackagesDto = await _travelPackagesRepository.GetTravelPackagesOfferAsync();
        return _mapper.Map<List<TravelPackagesDto>>(travelPackagesDto);
    }
}
