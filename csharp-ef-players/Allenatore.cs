using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    [Table("Allenatore")]
    [Index(nameof(AllenatoreId))]
    public class Allenatore
    {
        [Key]
        public int AllenatoreId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public int GameNumber { get; set; }

        [Required]
        public int WinNumber { get; set; }

        public int? TeamId { get; set; }

        public Team? Team { get; set; }


        public Allenatore(string name, string surname)
        {
            Name = name;
            Surname = surname;
            GameNumber = gamenumber(1,101);
            WinNumber = gamenumber(1,this.GameNumber);
        }

        private int gamenumber(int min, int max)
        {
            Random random=new Random();
            return random.Next(min, max);
        }

        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }
    }
}
