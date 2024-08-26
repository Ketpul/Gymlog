using Gymlog.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymlog.Infrastructure.Data.SeedDb
{
    public class SeedData
    {
        public ApplicationUser AdminUser { get; set; }

        public SeedData()
        {
            SeedUsers();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();


            AdminUser = new ApplicationUser()
            {
                Id = "df7c92db-9dec-4483-9b0c-39836de8f44a",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                FirstName = "Admin",
                LastName = "Adminov",
                PhoneNumber = "1234567890",
            };


            AdminUser.PasswordHash =
            hasher.HashPassword(AdminUser, "BioSportAdmin123");
        }
    }
}
