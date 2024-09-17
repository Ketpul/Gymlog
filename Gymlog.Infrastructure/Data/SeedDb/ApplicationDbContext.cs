using Gymlog.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gymlog.Infrastructure.Data.SeedDb
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Entity<CardReading>()
                .HasKey(cr => cr.Id); 

            modelBuilder.Entity<CardReading>()
                .HasOne(cr => cr.Card) 
                .WithMany(c => c.CardReadings)
                .HasForeignKey(cr => cr.CardId);

            modelBuilder.Entity<CardReading>()
                .HasOne(cr => cr.ReadingDate) 
                .WithMany(rd => rd.CardReadings)
                .HasForeignKey(cr => cr.ReadingDateId);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Card> Cards { get; set;}
        public DbSet<ReadingDate> ReadingDates { get; set; }
        public DbSet<CardReading> CardReadings { get; set; }
    }
}
