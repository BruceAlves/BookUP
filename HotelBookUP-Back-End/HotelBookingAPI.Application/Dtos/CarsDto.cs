
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Application;

public class CarsDto
{
    public int Id { get; set; }
    public string? Modelo { get; set; }
    public string? Marca { get; set; }
    public int Ano { get; set; }
    public string? Tipo { get; set; }
    public string? Cor { get; set; }
    public string? Cambio { get; set; }
    public int Passageiros { get; set; }
    public int Portas { get; set; }
    public bool ar_condicionado { get; set; }
    public decimal? Preco_diaria { get; set; }
    public string? Local_retirada { get; set; }
    public string? pasta_imagem { get; set; }
    [Column("oferta")]
    public bool Offer { get; set; }
}
