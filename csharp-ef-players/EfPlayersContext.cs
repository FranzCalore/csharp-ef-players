using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    public class EfPlayersContext:DbContext
    {
        public DbSet<FootballPlayer> FootballPlayers { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Allenatore> Allenatori { get; set; }

        public DbSet<Sponsor> Sponsors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = dbPlayers3.0; Integrated Security = True; Pooling = False;TrustServerCertificate=True");
        }
    }
}
