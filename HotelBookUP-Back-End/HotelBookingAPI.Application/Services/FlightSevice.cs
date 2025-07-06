using AutoMapper;
using HotelBookingAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Application;

public class FlightSevice
{
    private readonly IMapper _mapper;
    private readonly IFlightRepository _flightRepository;

    public FlightSevice(IMapper mapper, IFlightRepository flightRepository)
    {
        _mapper = mapper;
        _flightRepository = flightRepository;
    }

    public async Task<List<FlightDto>> GetAllFlightAsync()
    {
        var Flight = await _flightRepository.GetFlightAsync();
        return _mapper.Map<List<FlightDto>>(Flight);
    }

    public async Task<List<FlightDto>> GetFlightOfferAsync()
    {
        var Flight = await _flightRepository.GetFlightOfferAsync();
        return _mapper.Map<List<FlightDto>>(Flight);
    }
}
