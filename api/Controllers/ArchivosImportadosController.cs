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

    [Route("api/archivosimportados")]
    [ApiController]
    public class ArchivosImportadosController : Controller
    {

        private readonly IServicio<ArchivosImportado> _archivoImportadoServicio;
        private readonly IMapper _mapper;

        public ArchivosImportadosController (IServicio<ArchivosImportado> archivosImportadoServicio, IMapper mapper)
        {
            _archivoImportadoServicio = archivosImportadoServicio;
            _mapper = mapper;

        }

        [HttpGet]
        public IActionResult Index()
        {
            var lista = _archivoImportadoServicio.GetAll();
            var result = _mapper.Map<IEnumerable<ArchivosImportadosDTO>>(lista);
            return Ok(result);

        }
    }
}

