﻿using System;
using System.Collections.Generic;

namespace Dominio.Model
{
    public partial class TipoEvento 
    {
        public TipoEvento()
        {
            Eventos = new HashSet<Evento>();
        }

        public long Id { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Evento> Eventos { get; set; }
    }
}
