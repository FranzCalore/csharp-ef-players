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
        public int Team_Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string città { get; set; }
        [Required]
        public string allenatore { get; set; }
        [Required]
        public string colori { get; set; }

        public List<FootballPlayer> listaGiocatori { get; set; }

    }
}
