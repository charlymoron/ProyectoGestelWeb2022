using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class Provincium
    {
        public Provincium()
        {
            Edificios = new HashSet<Edificio>();
        }

        public long Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Edificio> Edificios { get; set; }
    }
}
