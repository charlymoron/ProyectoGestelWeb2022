using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.DTO;
using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using Servicios.Contracts;
using Servicios.Implem;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{

    [Route("api/tipoidentificador")]
    [ApiController]
    public class TipoIdentificadorController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IServicio<TipoIdentificador> _tipoIdentificadorServicio;


        public TipoIdentificadorController(IServicio<TipoIdentificador> tipoIdentificadorServicio,
            IMapper mapper)
        {

            _tipoIdentificadorServicio = tipoIdentificadorServicio;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var lista = _tipoIdentificadorServicio.GetAll();
            var result = _mapper.Map<IEnumerable<TipoIdentificadorDTO>>(lista);
            return Ok(result);
        }
    }
}

