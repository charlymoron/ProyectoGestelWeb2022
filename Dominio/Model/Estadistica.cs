using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class Estadistica : Entidad
    {
        public Estadistica()
        {
            DetalleEstadisticaPorEnlaces = new HashSet<DetalleEstadisticaPorEnlace>();
            DetalleEstadisticas = new HashSet<DetalleEstadistica>();
        }

        public long Id { get; set; }
        public long ClienteId { get; set; }
        public long DominioId { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public long TipoEstadisticaId { get; set; }
        public decimal? DuracionExcluida { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual Dominio Dominio { get; set; } = null!;
        public virtual TipoEstadistica TipoEstadistica { get; set; } = null!;
        public virtual ICollection<DetalleEstadisticaPorEnlace> DetalleEstadisticaPorEnlaces { get; set; }
        public virtual ICollection<DetalleEstadistica> DetalleEstadisticas { get; set; }
    }
}
