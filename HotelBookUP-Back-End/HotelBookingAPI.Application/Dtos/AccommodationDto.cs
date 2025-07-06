using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Application;

public class AccommodationDto
{
    public string? Nome { get; set; }        
    public string? Descricao { get; set; }   
    public decimal Preco { get; set; }      
    public string? pasta_imagem { get; set; }
    public bool Offer { get; set; }
    public int Star { get; set; }

}
