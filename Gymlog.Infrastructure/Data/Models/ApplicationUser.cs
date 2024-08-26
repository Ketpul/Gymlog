using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Gymlog.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(30)]
        [Required]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(30)]
        [Required]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;

    }
}