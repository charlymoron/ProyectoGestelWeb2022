using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class Enlace : Entidad
    {
        public Enlace()
        {
            DetalleEstadisticaPorEnlaces = new HashSet<DetalleEstadisticaPorEnlace>();
            Objetos = new HashSet<Objeto>();
            Dominios = new HashSet<Dominio>();
        }

        public long Id { get; set; }
        public long EdificioId { get; set; }
        public string Referencia { get; set; } = null!;
        public bool? EsDeTerceros { get; set; }

        public virtual Edificio Edificio { get; set; } = null!;
        public virtual ICollection<DetalleEstadisticaPorEnlace> DetalleEstadisticaPorEnlaces { get; set; }
        public virtual ICollection<Objeto> Objetos { get; set; }

        public virtual ICollection<Dominio> Dominios { get; set; }
    }
}
