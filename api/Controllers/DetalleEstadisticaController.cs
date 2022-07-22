using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.DTO;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using Servicios.Contracts;
using Servicios.Helpers;
using Servicios.Implem;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{


    [Route("api/detalleEstadistica")]
    [ApiController]
    public class DetalleEstadisticaController : Controller
    {
        private readonly IDetalleEstadisticaServicio _detalleEstadisticaServicio;
        private readonly IMapper _mapper;


        public DetalleEstadisticaController(IDetalleEstadisticaServicio detalleEstadisticaServicio,
            IMapper mapper)
        {
            _detalleEstadisticaServicio = detalleEstadisticaServicio;
            _mapper = mapper;
        }



        [HttpGet]
        public IActionResult Index()
        {
            var lista = _detalleEstadisticaServicio.GetAll();
            var result = _mapper.Map<IEnumerable<DetalleEstadisticaDTO>>(lista);
            return Ok(result);
        }

        [HttpGet]
        [Route("api/getpage")]
        public IActionResult GetPage([FromQuery] ParametersGrid param)
        {
            var lista = _detalleEstadisticaServicio.GetPage(param);
            //_logger.LogInfo($"Returned {owners.Count()} owners from database.");
            return Ok(lista);

        }
    }
}

