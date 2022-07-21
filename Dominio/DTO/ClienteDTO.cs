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

        //public  ICollection<ArchivosImportado> ArchivosImportados { get; set; }
        //public  ICollection<Edificio> Edificios { get; set; }
        //public  ICollection<Estadistica> Estadisticas { get; set; }
        //public  ICollection<TipoEstadistica> TipoEstadisticas { get; set; }

    }
}

