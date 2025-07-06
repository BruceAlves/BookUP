
using AutoMapper;
using HotelBookingAPI.Domain;

namespace HotelBookingAPI.Application;

public class AccommodationService
{
    private readonly IAccommodationRepository _accommodationRepository;
    private readonly IMapper _mapper;

    public AccommodationService(IAccommodationRepository hospedagenRepository, IMapper mapper)
    {
        _accommodationRepository = hospedagenRepository;
        _mapper = mapper;
    }

    public async Task<List<AccommodationDto>> GetAllAccommodationAsync()
    {
        var hospedagens = await _accommodationRepository.GetAccommodationAsync();
        return _mapper.Map<List<AccommodationDto>>(hospedagens);
    }
    public async Task<List<AccommodationDto>> GetAccommodationOfferAsync()
    {
        var hospedagens = await _accommodationRepository.GetAccommodationOfferAsync();
        return _mapper.Map<List<AccommodationDto>>(hospedagens);
    }
}
