using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OnlineChallange3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly ILogger<VeiculosController> _logger;

        private readonly IVeiculosService _veiculosService;

        public VeiculosController(ILogger<VeiculosController> logger, IVeiculosService  veiculosService)
        {
            _veiculosService = veiculosService;
            _logger = logger;
                    }

        [HttpGet("marcas")]
        public List<Marcas> GetMarcas()
        {
            return _veiculosService.GetMarcas();               
        }

        [HttpGet("modelos/{modeloID}")]
        public List<Modelos> GetModelos(int modeloID)
        {
            return _veiculosService.GetModelos(modeloID);
        }

        [HttpGet("versoes/{versaoID}")]
        public List<Veiculos> GetVersoes(int versaoID)
        {
            return _veiculosService.GetVersoes(versaoID);
        }

     }
}
