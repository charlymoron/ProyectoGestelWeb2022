using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class TipoEstadistica : Entidad
    {
        public TipoEstadistica()
        {
            Estadisticas = new HashSet<Estadistica>();
        }

        public long Id { get; set; }
        public long ClienteId { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Observaciones { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;
        public virtual ICollection<Estadistica> Estadisticas { get; set; }
    }
}
