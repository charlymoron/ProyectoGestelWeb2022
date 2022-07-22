    using System;

    namespace Dominio.DTO
    {
        public class DetalleEstadisticaPorEnlaceDTO
        {
        
                public long Id { get; set; }
                public long EstadisticaId { get; set; }
                public long EnlaceId { get; set; }
                public int? CantidadDeFallas { get; set; }
                public decimal? Tmef { get; set; }
                public decimal? Disponibilidad { get; set; }
                public decimal? Tdf { get; set; }
                public decimal? TdfconRespaldo { get; set; }
                public decimal? DisponibilidadConRespaldo { get; set; }

    }
    }