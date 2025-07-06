using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Domain;

public interface IAccommodationRepository
{
    Task<List<Accommodation>> GetAccommodationAsync();
    Task<List<Accommodation>> GetAccommodationOfferAsync();

}
