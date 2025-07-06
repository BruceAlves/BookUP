
namespace HotelBookingAPI.Application;

public class FlightDto
{
    public string? companhia { get; set; }
    public string? numero_voo { get; set; }
    public string? origem { get; set; }
    public string? destino { get; set; }
    public DateTime data_partida { get; set; }
    public TimeSpan hora_partida { get; set; }
    public DateTime data_chegada { get; set; }
    public TimeSpan hora_chegada { get; set; }
    public string? duracao { get; set; }
    public decimal preco { get; set; }
    public string? tipo_passagem { get; set; }
    public string? classe { get; set; }
    public int escalas { get; set; }
    public string? pasta_imagem { get; set; }
    public bool Offer { get; set; }
}
