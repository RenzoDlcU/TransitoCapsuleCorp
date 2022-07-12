
namespace TransitoCapsuleCorp.Models;

public class Multa
{
    public int MultaId { get; set; }
    public int LocalizacionX { get; set; }
    public int LocalizacionY { get; set; }
    public string Imagen { get; set; }
    public int AlturaVuelo { get; set; }
    public int Velocidad { get; set; }
    public string Matricula { get; set; }
    public Ciudad Ciudad { get; set; }
    public TipoAuto TipoAuto { get; set; }
}

public enum Ciudad
{
    Norte,
    Sur,
    Este,
    Oeste
}

public enum TipoAuto
{
    Volador,
    Terrestre
}

