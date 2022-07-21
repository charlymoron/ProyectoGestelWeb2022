using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Servicios.Contracts;
using Servicios.Implem;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{

 


    [Route("api/tipoevento")]
    [ApiController]
    public class TipoEventoController : Controller
    {
        private readonly ITipoEventoServicio _tipoEventoServicio;
        private IMapper _mapper;

        public TipoEventoController(ITipoEventoServicio tipoEventoServicio, IMapper mapper)
        {
            _tipoEventoServicio = tipoEventoServicio;
            _mapper = mapper;
                 
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var lista = _tipoEventoServicio.GetAll();
            var result = _mapper.Map<IEnumerable<TipoEventoDTO>>(lista);
            return Ok(result);

        }
    }
}

