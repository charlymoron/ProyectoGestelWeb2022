using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.DTO;
using Microsoft.AspNetCore.Mvc;
using Servicios.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class DetalleEstadisticaPorEnlaceController : Controller
    {

        private readonly IDetalleEstadisticaPorEnlaceServicio _detalleEstadisticaServicio;
        private readonly IMapper _mapper;


        public DetalleEstadisticaPorEnlaceController(IDetalleEstadisticaPorEnlaceServicio detalleEstadisticaServicio,
                IMapper mapper)
        {
            _detalleEstadisticaServicio = detalleEstadisticaServicio;
            _mapper = mapper;
        }


        // GET: api/values
        [HttpGet]
        public IActionResult GetDetalleEstadisticaPorEnlace (long Id)
        {
            var lista = _detalleEstadisticaServicio.GetDetalleEstadisticaPorEnlaceId(Id);

          // var result = _mapper.Map<IEnumerable<DetalleEstadisticaPorEnlaceDTO>>(lista);


            return Ok(lista);

        }
    }
}

