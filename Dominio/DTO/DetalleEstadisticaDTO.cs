﻿using System;
namespace Dominio.DTO
{
    public class DetalleEstadisticaDTO
    {
        public long Id { get; set; }
        public long EstadisticaId { get; set; }
        public int? CantidadFallas { get; set; }
        public decimal? PorcentajeDisponibilidad { get; set; }
        public decimal? TiempoMuerto { get; set; }
        public decimal? TiempoMuertoEntreFallas { get; set; }
        public decimal? TiempoMuertoConRespaldo { get; set; }
        public decimal? PorcentajeDisponibilidadConRespaldo { get; set; }
        public decimal? TiempoMuertoDelRespaldo { get; set; }
        public long ObjetoId { get; set; }
        public long EnlaceId { get; set; }
        public decimal? Tdfneto { get; set; }
        public decimal? Tmef { get; set; }
        public decimal? Tmr { get; set; }
        public decimal? Tdf { get; set; }
    }
}

