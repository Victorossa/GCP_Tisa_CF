﻿using System;
using System.Collections.Generic;

namespace GCP_CF.Models
{
    public class TiposPersona
    {
        public int TipoPersona_Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Naturaleza_Id { get; set; }
        public string Cargo { get; set; }

        public virtual TiposNaturaleza TiposNaturaleza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personas> Personas { get; set; }
    }
}