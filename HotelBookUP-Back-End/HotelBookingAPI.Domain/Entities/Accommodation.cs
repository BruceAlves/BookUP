using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAPI.Domain;

public class Accommodation
{
    public int Id { get; set; }             
    public string? Nome { get; set; }        
    public string? Descricao { get; set; }   
    public decimal Preco { get; set; }
    public string? pasta_imagem { get; set; }
    [Column("oferta")]
    public bool Offer { get; set; }
    public int Star { get; set; }

}
