using System;
using System.Collections.Generic;


namespace Dominio.Model
{
    public partial class TipoObjeto
    {
        public TipoObjeto()
        {
            Objetos = new HashSet<Objeto>();
        }

        public long Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Objeto> Objetos { get; set; }
    }
}
