using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beca.Domain.Entity;

namespace Beca.Infrastructure.Common
{
    public class BecaContext: DbContext
    {
        public BecaContext() : base("ConexionBD")
        {

        }
        public virtual DbSet<Pregrado> Estudiantes { get; set; }
        public virtual DbSet<Grado> Grados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BecaContext>(null);
            modelBuilder.Entity<Pregrado>().ToTable("Estudiante");
            modelBuilder.Entity<Grado>().ToTable("Grado");
            base.OnModelCreating(modelBuilder);
        }

    }
}
