using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class Objeto : Entidad
    {
        public Objeto()
        {
            DetalleEstadisticas = new HashSet<DetalleEstadistica>();
            Eventos = new HashSet<Evento>();
            IdentificadorObjetos = new HashSet<IdentificadorObjeto>();
            InverseObjetoBackup = new HashSet<Objeto>();
        }

        public long Id { get; set; }
        public long TipoObjetoId { get; set; }
        public long EnlaceId { get; set; }
        public short Activo { get; set; }
        public long ProveedorId { get; set; }
        public long MantenedorId { get; set; }
        public DateTime FechaAlta { get; set; }
        public string? Observaciones { get; set; }
        public long? ObjetoBackupId { get; set; }
        public short? SoloActuaComoBackup { get; set; }
        public string? Nombre { get; set; }

        public virtual Enlace Enlace { get; set; } = null!;
        public virtual Mantenedor Mantenedor { get; set; } = null!;
        public virtual Objeto? ObjetoBackup { get; set; }
        public virtual Proveedor Proveedor { get; set; } = null!;
        public virtual TipoObjeto TipoObjeto { get; set; } = null!;
        public virtual ICollection<DetalleEstadistica> DetalleEstadisticas { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
        public virtual ICollection<IdentificadorObjeto> IdentificadorObjetos { get; set; }
        public virtual ICollection<Objeto> InverseObjetoBackup { get; set; }
    }
}
