using Microsoft.AspNetCore.Mvc;

using TransitoCapsuleCorp.Models;
using TransitoCapsuleCorp.Services;
using TransitoCapsuleCorp.Helpers;

namespace TransitoCapsuleCorp.Controllers;

public class MultaController : ControllerBase
{
    IMultaService multaService;

    public MultaController(IMultaService service)
    {
        multaService = service;
    }

    [HttpGet]
    [Route("multas")]
    public IActionResult Get()
    {
        // MultasResponse multas = new MultasResponse();
        // multas.multasInvadas = multaService.Get().Where(x => !x.Valida);
        // multas.multasValidas = multaService.Get().Where(x => x.Valida);
        // return Ok(multas);
        return Ok("Hola Despliegue");
    }

    [HttpGet]
    [Route("multas/{matricula}")]
    public IActionResult GeyByMatricula(string matricula)
    {
        return Ok(multaService.GetByMatricula(matricula));
    }

    [HttpPost]
    [Route("multas/levantarmulta")]
    public IActionResult Post([FromBody] Multa multa)
    {
        multa.Valida = false;

        #region  Valida multa
        if (multa.TipoAuto == TipoAuto.Terrestre)
        {
            if (multa.Velocidad > 120) multa.Valida = true;
        }
        else if (multa.TipoAuto == TipoAuto.Volador)
        {
            if (multa.AlturaVuelo > 50 || multa.Velocidad > 120) multa.Valida = true;
        }
        #endregion

        #region Valida ciudad
        CalcularDistancia helper = new CalcularDistancia(multa.LocalizacionX, multa.LocalizacionY);
        helper.CalcularDistancias();
        multa.Ciudad = helper.CiudadMasCercana;
        multa.Distancia = helper.Distancia;

        Console.WriteLine(helper.CiudadMasCercana);
        Console.WriteLine(helper.Distancia);
        Console.WriteLine(multa);
        #endregion

        multaService.Save(multa);
        return Ok(multa);
    }
}