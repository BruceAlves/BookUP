
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingAPI.Domain;

public class TravelPackages
{
    public int Id { get; set; }
    [Column("nome_pacote")]
    public string? NomePacote { get; set; }

    public string? Destino { get; set; }
    [Column("pasta_imagem")]
    public string? PastaImagem { get; set; }

    public string? Descricao { get; set; }

    public int Dias { get; set; }

    public decimal Preco { get; set; }

    public string? Inclui { get; set; }

    [Column("data_saida")]
    public DateTime DataSaida { get; set; }
    [Column("data_retorno")]
    public DateTime DataRetorno { get; set; }
    [Column("oferta")]
    public bool Offer { get; set; }
}
