using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GCP_CF.Models
{
    public class GCPContext : DbContext
    {
        public GCPContext()
           : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<GCP_CF.Models.Actividades> Actividades { get; set; }

        public System.Data.Entity.DbSet<GCP_CF.Models.ContratosMarco> ContratosMarcoes { get; set; }

        public System.Data.Entity.DbSet<GCP_CF.Models.EstadosFases> EstadosFases { get; set; }

        public System.Data.Entity.DbSet<GCP_CF.Models.TiposNaturaleza> TiposNaturalezas { get; set; }

        public System.Data.Entity.DbSet<GCP_CF.Models.TiposPersona> TiposPersonas { get; set; }

        public System.Data.Entity.DbSet<GCP_CF.Models.Personas> Personas { get; set; }

        public System.Data.Entity.DbSet<GCP_CF.Models.TiposContratos> TiposContratos { get; set; }

        public System.Data.Entity.DbSet<GCP_CF.Models.TiposEstadoContrato> TiposEstadoContratoes { get; set; }

        public System.Data.Entity.DbSet<GCP_CF.Models.Contratos> Contratos { get; set; }
    }
}