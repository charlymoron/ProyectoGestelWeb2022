using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.DTO;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using Servicios.Contracts;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{


    [Route("api/detalleEstadistica")]
    [ApiController]
    public class DetalleEstadisticaController : Controller
    {
        private readonly IServicio<DetalleEstadistica> _detalleEstadisticaServicio;
        private readonly IMapper _mapper;


        public DetalleEstadisticaController(IServicio<DetalleEstadistica> detalleEstadisticaServicio,
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
    }
}

