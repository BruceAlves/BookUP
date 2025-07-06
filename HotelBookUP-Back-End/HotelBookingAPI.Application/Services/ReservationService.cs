using HotelBookingAPI.Domain;


namespace HotelBookingAPI.Application;

public class ReservationService
{

    private readonly IReservationRepository _reservationRepository;

    public ReservationService(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    public async Task<List<Reservation>> GetAllReservationsAsync()
    {
        return await _reservationRepository.GetReservationsAsync();
    }

    public async Task AddReservationAsync(Reservation reservation)
    {
        await _reservationRepository.AddReservationAsync(reservation);
    }
}
