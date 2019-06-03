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

        DbSet<TiposNaturaleza> TiposNaturaleza { get; set; }
        DbSet<TiposPersona> TiposPersona { get; set; }
        DbSet<Personas> Personas { get; set; }
    }
}