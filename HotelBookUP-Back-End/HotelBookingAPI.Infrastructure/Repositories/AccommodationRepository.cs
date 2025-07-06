using HotelBookingAPI.Domain;
using HotelBookingAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Infrastructure;

public class AccommodationRepository : IAccommodationRepository
{
    private readonly ApplicationDbContext _context;

    public AccommodationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Accommodation>> GetAccommodationAsync()
    {
        return await _context.Hospedagens.ToListAsync();
    }

    public async Task<List<Accommodation>> GetAccommodationOfferAsync()
    {
        return await _context.Hospedagens
         .Where(v => v.Offer == true)
         .ToListAsync();
    }

}
