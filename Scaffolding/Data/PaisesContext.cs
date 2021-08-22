using Microsoft.EntityFrameworkCore;
using Scaffolding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding.Data
{
    public class PaisesContext: DbContext
    {
        public PaisesContext(DbContextOptions<PaisesContext> options): base(options) { }

        public DbSet<Pais> Paises { get; set; }
    }
}
