using Microsoft.EntityFrameworkCore;
using PokedexForRealTisTimeSwear.Data;

namespace PokedexForRealTisTimeSwear.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PokedexForRealTisTimeSwearContext
                (serviceProvider
                .GetRequiredService<DbContextOptions<PokedexForRealTisTimeSwearContext>>()
                ))
            {
                if (context.Pokemon.Any())
                {
                    return;
                }
                context.Pokemon.AddRange(
                    new Pokemon
                    {
                        Name = "BulbaSaur",
                        DiscoveryRegion = "Kanto",
                        PokedexEntryID = 1,
                        ElementType = "Grass",
                        Gender = "Can apper as male or female",
                        ImageURL = "https://static.printler.com/cache/7/f/f/2/0/d/7ff20df8acaa19e14eff479373d97523b28d7dc9.jpg"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
