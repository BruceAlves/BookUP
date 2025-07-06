using HotelBookingAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingAPI.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Accommodation> Hospedagens { get; set; }
    public DbSet<Flight> Voos { get; set; }
    public DbSet<Cars> Cars { get; set; }
    public DbSet<TravelPackages> pacotes_viagem { get; set; }

}
