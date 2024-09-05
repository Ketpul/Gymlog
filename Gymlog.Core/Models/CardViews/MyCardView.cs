namespace Gymlog.Core.Models.CardViews
{
    public class MyCardView
    {
        public int Id { get; set; } 

        public string CardId { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;
        
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
     
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int Daily { get; set; }
        public int Мonth { get; set; }

    }
}
