using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymlog.Infrastructure.Data.Models
{
    public class ReadingDate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public List<CardReading> CardReadings { get; set; } = new List<CardReading>();
    }
}
