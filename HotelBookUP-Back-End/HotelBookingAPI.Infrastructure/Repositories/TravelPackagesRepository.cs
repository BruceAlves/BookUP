using HotelBookingAPI.Domain;
using HotelBookingAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Infrastructure;

public class TravelPackagesRepository : ITravelPackagesRepository
{
    private readonly ApplicationDbContext _context;

    public TravelPackagesRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<TravelPackages>> GetTravelPackagesAsync()
    {
        return await _context.pacotes_viagem.ToListAsync();
    }

    public async Task<List<TravelPackages>> GetTravelPackagesOfferAsync()
    {
        return await _context.pacotes_viagem
              .Where(v => v.Offer == true)
              .ToListAsync();
    }
}
