using AutoMapper;
using HotelBookingAPI.Domain;

namespace HotelBookingAPI.Application;

public class CarsService
{
    private readonly IMapper _mapper;
    private readonly ICarsRepository _carsRepository;

    public CarsService(IMapper mapper, ICarsRepository carsRepository)
    {
        _mapper = mapper;
        _carsRepository = carsRepository;
    }

    public async Task<List<CarsDto>> GetAllCarsAsync()
    {
        var cars = await _carsRepository.GetCarsAsync();
        return _mapper.Map<List<CarsDto>>(cars);
    }
    public async Task<List<CarsDto>> GetCarsOfferAsync()
    {
        var cars = await _carsRepository.GetCarsOfferAsync();
        return _mapper.Map<List<CarsDto>>(cars);
    }
}
