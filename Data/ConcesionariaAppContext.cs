using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConcesionariaApp.Models;

namespace ConcesionariaApp.Data
{
    public class ConcesionariaAppContext : DbContext
    {
        public ConcesionariaAppContext (DbContextOptions<ConcesionariaAppContext> options)
            : base(options)
        {
        }

        public DbSet<ConcesionariaApp.Models.Auto> Auto { get; set; }
    }
}
