using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class TipoIdentificador
    {
        public TipoIdentificador()
        {
            IdentificadorObjetos = new HashSet<IdentificadorObjeto>();
        }

        public long Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? Observaciones { get; set; }

        public virtual ICollection<IdentificadorObjeto> IdentificadorObjetos { get; set; }
    }
}
