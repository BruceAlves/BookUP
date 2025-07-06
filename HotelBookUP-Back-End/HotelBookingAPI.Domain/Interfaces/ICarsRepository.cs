using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Domain;

public interface ICarsRepository
{
    Task<List<Cars>> GetCarsAsync();
    Task<List<Cars>> GetCarsOfferAsync();
}
