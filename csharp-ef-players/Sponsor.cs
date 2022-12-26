using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    public class Sponsor
    {
        [Key]
        public int SponsorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]

        public DateTime Scadenza { get; set; }

        public List<Team>? Team { get; set; }

        public Sponsor(string name, double value, DateTime scadenza)
        {
            Name = name;
            Value = value;
            Scadenza = scadenza;
        }
    }
}
