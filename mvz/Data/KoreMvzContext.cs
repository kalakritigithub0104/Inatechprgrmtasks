using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KoreMvz.Models;

namespace KoreMvz.Data
{
    public class KoreMvzContext : DbContext
    {
        public KoreMvzContext (DbContextOptions<KoreMvzContext> options)
            : base(options)
        {
        }

        public DbSet<KoreMvz.Models.Customer> Customer { get; set; } = default!;
    }
}
