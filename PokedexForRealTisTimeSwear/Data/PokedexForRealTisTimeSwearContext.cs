using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokedexForRealTisTimeSwear.Models;

namespace PokedexForRealTisTimeSwear.Data
{
    public class PokedexForRealTisTimeSwearContext : DbContext
    {
        public PokedexForRealTisTimeSwearContext (DbContextOptions<PokedexForRealTisTimeSwearContext> options)
            : base(options)
        {
        }

        public DbSet<PokedexForRealTisTimeSwear.Models.Pokemon> Pokemon { get; set; } = default!;
    }
}
