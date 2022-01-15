using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeAreTheChampions.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string TeamName { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<Player>Players{ get; set; }
        public virtual ICollection<Match> Team1Matches { get; set; }
        public virtual ICollection<Match> Team2Matches { get; set; }

    }
}
