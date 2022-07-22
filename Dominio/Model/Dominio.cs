using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class Dominio 
    {
        public Dominio()
        {
            Estadisticas = new HashSet<Estadistica>();
            Enlaces = new HashSet<Enlace>();
        }

        public long Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Estadistica> Estadisticas { get; set; }

        public virtual ICollection<Enlace> Enlaces { get; set; }
    }
}
