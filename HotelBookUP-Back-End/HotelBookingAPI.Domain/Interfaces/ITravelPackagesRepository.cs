using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Domain;

public interface ITravelPackagesRepository
{
    Task<List<TravelPackages>> GetTravelPackagesAsync();
    Task<List<TravelPackages>> GetTravelPackagesOfferAsync();

}
