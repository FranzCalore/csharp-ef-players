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
    [Table("FootballPlayer")]
    [Index(nameof(player_Id))]
    public class FootballPlayer
    {
        [Key]
        public int player_Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string surname { get; set; }

        [Required]
        public int vote { get; set; }

        [Required]
        public int gameNumber { get; set; }

        [Required]
        public int winNumber { get; set; }

    }
}
