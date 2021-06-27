using Microsoft.EntityFrameworkCore;


namespace SingleStoneExercise.Models
{
    public class ContactEntryContext : DbContext
    {
        public ContactEntryContext(DbContextOptions<ContactEntryContext> options)
            : base(options)
        {
            
        }

        public DbSet<Name> Names { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Name>()
            //   .HasOne<Address>(a => a.Address)
            //   .WithOne(b => b.Name)
            //   .HasForeignKey<Address>(b => b.NameId);

            //modelBuilder.Entity<Address>()
            //.HasMany(p => p.Phones)
            //.WithOne(a => a.Address)
            //.IsRequired();


        }
    }
}
