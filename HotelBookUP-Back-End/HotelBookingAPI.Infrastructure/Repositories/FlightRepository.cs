using HotelBookingAPI.Domain;
using HotelBookingAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace HotelBookingAPI.Infrastructure;

public class FlightRepository : IFlightRepository
{
    private readonly ApplicationDbContext _context;

    public FlightRepository(ApplicationDbContext Context)
    {
        _context = Context;
    }
    public async Task<List<Flight>> GetFlightAsync()
    {
        return await _context.Voos.ToListAsync();
    }

    public async Task<List<Flight>> GetFlightOfferAsync()
    {
        return await _context.Voos
             .Where(v => v.Offer == true)
             .ToListAsync();
    }
}
