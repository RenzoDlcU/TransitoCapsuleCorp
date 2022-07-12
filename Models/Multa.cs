using System.Text.Json.Serialization;

namespace TransitoCapsuleCorp.Models;

public class Multa
{
    [JsonIgnore]
    public int MultaId { get; set; }
    public int LocalizacionX { get; set; }
    public int LocalizacionY { get; set; }
    public string Imagen { get; set; }
    public int AlturaVuelo { get; set; }
    public int Velocidad { get; set; }
    public string Matricula { get; set; }
    public TipoAuto TipoAuto { get; set; }
    public string Ciudad { get; set; }
    public bool Valida { get; set; }
    public double Distancia { get; set; }
}

public enum TipoAuto
{
    Volador,
    Terrestre
}
