using Microsoft.EntityFrameworkCore;
using SoUs.Entities;

namespace SoUs.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medications { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Role> Roles { get; set; }
        // Entities.Task because of name conflict with System.Threading.Tasks.Task
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<CareCenter> CareCenters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CareCenter cc = new CareCenter { CareCenterId = 1, Name = "Care Center 1", Address = new Address(1, "Solsikkevej 52", "Middelfart", "Syddanmark", "5500") };
            Console.WriteLine("Care Center: " + cc.Address.AddressId);
            modelBuilder.Entity<Address>().HasData(
                new Address() { AddressId = 1, Street = "Solsikkevej 55", City = "Middelfart", State = "Syddanmark", ZipCode = "5500" }
            );

            modelBuilder.Entity<CareCenter>().HasData(
                new CareCenter { CareCenterId = 1, Name = "Care Center 1", AddressId = 1 }
            );
        }
    }
}
