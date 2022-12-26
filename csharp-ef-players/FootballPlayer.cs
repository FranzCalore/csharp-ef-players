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
    [Index(nameof(PlayerId))]
    public class FootballPlayer
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public double Vote { get; set; }

        [Required]
        public int GameNumber { get; set; }

        [Required]
        public int WinNumber { get; set; }

        public int? TeamId { get; set; }

        public Team? Team { get; set; }


        public FootballPlayer(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Vote = randomVote();
            GameNumber = gamenumber(1, 101);
            WinNumber = gamenumber(1, this.GameNumber);
        }

        private int gamenumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private double randomVote()
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * 9 + 1 , 1);
        }

        public override string ToString()
        {
            return PlayerId
                + " " 
                + Name
                + " "
                + Surname
                + "\nvoto Medio: "
                + Vote
                + "\nNumero Partite: "
                + GameNumber
                + "\nNumero Partite Vinte: "
                + WinNumber;
        }
    }
}
