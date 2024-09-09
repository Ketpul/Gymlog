using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymlog.Infrastructure.Data.Models
{
    public class EditCard
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime End { get; set; }
        public DateTime Start { get; set; }
        public string CardId { get; set; }

        public string FullName
        {
            get => $"{FirstName} {LastName}";
            set
            {
                var names = value.Split(' ');
                if (names.Length > 1)
                {
                    FirstName = names[0];
                    LastName = names[1];
                }
                else
                {
                    FirstName = value;
                    LastName = string.Empty;
                }
            }
        }
    }
}
