using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymlog.Infrastructure.Data.Models
{
    public class CardReading
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CardId")]
        public int CardId { get; set; }
        public Card Card { get; set; } = null!;

        [ForeignKey("ReadingDateId")]
        public int ReadingDateId { get; set; }
        public ReadingDate ReadingDate { get; set; } = null!;
    }
}
