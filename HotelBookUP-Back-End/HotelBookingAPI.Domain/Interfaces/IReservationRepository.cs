using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Domain;

public interface IReservationRepository
{
    Task<List<Reservation>> GetReservationsAsync();
    Task AddReservationAsync(Reservation reservation);
}
