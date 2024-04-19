using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pinewood.Models;

namespace Pinewood.Data
{
    public class PinewoodContext : DbContext
    {
        public PinewoodContext (DbContextOptions<PinewoodContext> options)
            : base(options)
        {
        }

        public DbSet<Pinewood.Models.Customer> Customer { get; set; } = default!;
    }
}
