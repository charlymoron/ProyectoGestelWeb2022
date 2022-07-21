using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class Cliente : Entidad
    {
        public Cliente()
        {
            ArchivosImportados = new HashSet<ArchivosImportado>();
            Edificios = new HashSet<Edificio>();
            Estadisticas = new HashSet<Estadistica>();
            TipoEstadisticas = new HashSet<TipoEstadistica>();
        }

        public long Id { get; set; }
        public string RazonSocial { get; set; } = null!;
        /// <summary>
        /// Activo = 1 Inactivo = 0
        /// </summary>
        public short Activo { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public DateTime? FechaDeBaja { get; set; }

        public virtual ICollection<ArchivosImportado> ArchivosImportados { get; set; }
        public virtual ICollection<Edificio> Edificios { get; set; }
        public virtual ICollection<Estadistica> Estadisticas { get; set; }
        public virtual ICollection<TipoEstadistica> TipoEstadisticas { get; set; }
    }
}
