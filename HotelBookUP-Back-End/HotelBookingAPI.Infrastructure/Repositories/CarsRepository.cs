using HotelBookingAPI.Domain;
using HotelBookingAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Infrastructure;

public class CarsRepository : ICarsRepository
{
    private readonly ApplicationDbContext _context;

    public CarsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Cars>> GetCarsAsync()
    {
        return await _context.Cars.ToListAsync();
    }

    public async Task<List<Cars>> GetCarsOfferAsync()
    {
        return await _context.Cars
            .Where(v => v.Offer == true)
            .ToListAsync();
    }
}
