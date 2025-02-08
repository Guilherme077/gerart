using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gerart.Models;

namespace Gerart.Data
{
    public class GerartContext : DbContext
    {
        public GerartContext (DbContextOptions<GerartContext> options)
            : base(options)
        {
        }

        public DbSet<Gerart.Models.Product> Product { get; set; } = default!;
    }
}
