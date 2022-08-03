using System;
using Dominio.Model;

namespace Dominio.DTO
{
    public class ClienteDTO
    {

            public string? Id { get; set; }
            public string? RazonSocial { get; set; }
            public string? Activo { get; set; }
            public DateTime FechaAlta { get; set; }
            public DateTime? FechaBaja { get; set; }

        

    }
}

