using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeAreTheChampions.Models
{
    public class Color
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string ColorName { get; set; }

        public byte Red { get; set; }
        
        public byte Green { get; set; }

        public byte Blue { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

    }
}
