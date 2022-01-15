using System.ComponentModel.DataAnnotations;

namespace WeAreTheChampions.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string PlayerName { get; set; }
        public string ImageLink { get; set; }
        public virtual Team Team { get; set; }
        public int? TeamId { get; set; }

    }
}
