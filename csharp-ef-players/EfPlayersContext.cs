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
        DbSet<FootballPlayer> footballPlayers { get; set; }
        DbSet<Team> teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = dbPlayers02; Integrated Security = True; Pooling = False;TrustServerCertificate=True");
        }
    }
}
