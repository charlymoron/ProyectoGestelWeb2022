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
     //[Route("api/cliente")]
    
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cliente")]
    [ApiController]
    public class ClienteController : Controller
    {

        private readonly IServicio<Cliente> _clienteServicio;
        private IMapper _mapper;

        public ClienteController(IServicio<Cliente> clienteServicio, IMapper mapper)
        {
            _clienteServicio = clienteServicio;
            _mapper = mapper;
           
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var lista = _clienteServicio.GetAll();
            var result = _mapper.Map<IEnumerable<ClienteDTO>>(lista);
            return Ok(result);


        }
    }
}

