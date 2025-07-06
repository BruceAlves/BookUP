using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Domain;

public class Reservation
{
    public int Id { get; set; }
    public string? GuestName { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public int QtdAdulto { get; set; }
    public int QtdKids { get; set; }
    public string? PaymentMethod { get; set; }
    public double AmountPayable { get; set; }
}
