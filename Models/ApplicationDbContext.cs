using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea9._0.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<PersonaModel> Personas { get; set; }
        public virtual DbSet<ProvinciaModel> Provincias { get; set; }
        public virtual DbSet<SangreModel> Sangres { get; set; }
    }
}
