using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Città { get; set; }
        [Required]
        public string Colori { get; set; }

        public List<FootballPlayer> ListaGiocatori { get; set;} = new List<FootballPlayer>() { };

        public List<Sponsor> ListaSponsor { get; set; } = new List<Sponsor>() { };

        public Allenatore Allenatore { get; set; }





        public override string ToString()
        {
            string team = this.Name + "\nAllenato da: " + this.Allenatore + "\n\n";
            foreach (FootballPlayer player in this.ListaGiocatori)
            {
                team += "\t";
                team += player;
                team += "\n";
            }

            return team;
        }
    }


}
