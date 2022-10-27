using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntendendoMvc.Models;

namespace EntendendoMvc.Data
{
    public class EntendendoMvcContext : DbContext
    {
        public EntendendoMvcContext (DbContextOptions<EntendendoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<EntendendoMvc.Models.Filme> Filme { get; set; } = default!;
    }
}
