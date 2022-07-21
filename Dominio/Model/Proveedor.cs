using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class Proveedor : Entidad
    {
        public Proveedor()
        {
            Objetos = new HashSet<Objeto>();
        }

        public long Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Contacto { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Objeto> Objetos { get; set; }
    }
}
