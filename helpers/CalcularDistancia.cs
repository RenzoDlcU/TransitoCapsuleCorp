namespace TransitoCapsuleCorp.Helpers;

public class CalcularDistancia
{
    int x;
    int y;
    int xNorte = -500;
    int yNorte = -200;
    int xSur = 100;
    int ySur = -100;
    int xEste = 500;
    int yEste = 100;
    int xOeste = 200;
    int yOeste = 100;

    public string CiudadMasCercana { get; set; }
    public double Distancia { get; set; }

    public CalcularDistancia(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void CalcularDistancias()
    {
        var distanceNorte = Math.Sqrt((Math.Pow(x - xNorte, 2) + Math.Pow(y - yNorte, 2)));
        var distanceSur = Math.Sqrt((Math.Pow(x - xSur, 2) + Math.Pow(y - ySur, 2)));
        var distanceEste = Math.Sqrt((Math.Pow(x - xEste, 2) + Math.Pow(y - yEste, 2)));
        var distanceOeste = Math.Sqrt((Math.Pow(x - xOeste, 2) + Math.Pow(y - yOeste, 2)));

        if (distanceNorte < distanceSur && distanceNorte < distanceEste && distanceNorte < distanceOeste)
        {
            CiudadMasCercana = "Ciudad del norte.";
            Distancia = distanceNorte;
        }
        else if (distanceSur < distanceNorte && distanceSur < distanceEste && distanceSur < distanceOeste)
        {
            CiudadMasCercana = "Ciudad del sur.";
            Distancia = distanceSur;
        }
        else if (distanceEste < distanceNorte && distanceEste < distanceSur && distanceEste < distanceOeste)
        {
            CiudadMasCercana = "Ciudad del este.";
            Distancia = distanceEste;
        }
        else if (distanceOeste < distanceNorte && distanceOeste < distanceSur && distanceOeste < distanceEste)
        {
            CiudadMasCercana = "Ciudad del oeste.";
            Distancia = distanceOeste;
        }
    }
}