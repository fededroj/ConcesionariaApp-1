
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using ConcesionariaApp.Models;

namespace ConcesionariaApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ConcesionariaAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ConcesionariaAppContext>>()))
            {
                // Look for any movies.
                if (context.Auto.Any())
                {
                    return;   // DB has been seeded
                }

                context.Auto.AddRange(
                    new Auto
                    {
                        Id = 1,
                        Modelo = "Palio",
                        AñoDelModelo = "2008",
                        Marca = "Fiat",
                        PrecioTotal = 1300000
                    }

                );
                context.SaveChanges();
            }
        }
    }

}


