using System;
using System.Collections.Generic;

namespace Dominio.Model
{ 
    public partial class Edificio : Entidad
    {
        public Edificio()
        {
            Enlaces = new HashSet<Enlace>();
        }

        public long Id { get; set; }
        public long? ClienteId { get; set; }
        public long ProvinciaId { get; set; }
        public string Nombre { get; set; } = null!;
        public short Sucursal { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Responsable { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? Observaciones { get; set; }
        public string? Email { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual Provincium Provincia { get; set; } = null!;
        public virtual ICollection<Enlace> Enlaces { get; set; }
    }
}
