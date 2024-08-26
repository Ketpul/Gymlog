using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Infrastructure.Data.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public string CardId { get; set; } = string.Empty;

        [Required]
        public DateTime DailyCounting { get; set; }

        [Required]
        public int Daily { get; set; }

        [Required]
        public DateTime МonthCounting { get; set; }


        [Required]
        public int Мonth { get; set; }
    }
}
