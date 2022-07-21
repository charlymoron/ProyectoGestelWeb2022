using System;
using Dominio.Model;

namespace Dominio.DTO
{
    public class ClienteDTO
    {

            public string? Id { get; set; }
            public string? RazonSocial { get; set; }
            public string? Activo { get; set; }
            public DateTime FechaDeAlta { get; set; }
            public DateTime? FechaDeBaja { get; set; }

        

    }
}

