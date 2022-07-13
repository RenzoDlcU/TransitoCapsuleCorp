
namespace TransitoCapsuleCorp.Models;

public class MultasResponse
{
    public IEnumerable<Multa> multasValidas { get; set; }
    public IEnumerable<Multa> multasInvalidas { get; set; }
}