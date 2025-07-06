
namespace HotelBookingAPI.Application;

public class TravelPackagesDto
{
    public string? NomePacote { get; set; }

    public string? Destino { get; set; }

    public string? PastaImagem { get; set; }

    public string? Descricao { get; set; }

    public int Dias { get; set; }

    public decimal Preco { get; set; }

    public string? Inclui { get; set; }

    public DateTime DataSaida { get; set; }

    public DateTime DataRetorno { get; set; }
    public bool Offer { get; set; }
}
