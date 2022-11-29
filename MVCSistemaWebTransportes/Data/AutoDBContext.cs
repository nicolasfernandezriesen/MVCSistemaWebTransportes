using MVCSistemaWebTransportes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCSistemaWebTransportes.Data
{
    public class AutoDBContext : DbContext
    {
        public AutoDBContext() : base("KeyDBAuto") { }

        public DbSet<Auto> Autos { get; set; }
    }
}