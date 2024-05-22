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
            modelBuilder.Entity<Entities.Task>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.Property(e => e.TaskId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TimeStart)
                    .IsRequired();

                entity.Property(e => e.TimeEnd)
                    .IsRequired();

                entity.Property(e => e.IsCompleted)
                    .IsRequired();

                entity.HasOne(e => e.Resident);

                entity.HasMany(e => e.Employees)
                    .WithMany(e => e.Tasks)
                    .UsingEntity(j => j.ToTable("TaskEmployees"));
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasMany(e => e.Employees)
                    .WithMany(e => e.Roles)
                    .UsingEntity(j => j.ToTable("EmployeeRoles"));
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.HasKey(e => e.MedicineId);

                entity.Property(e => e.MedicineId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Administered)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedOnAdd();

                entity.HasMany(entity => entity.Tasks)
                    .WithMany(entity => entity.Employees)
                    .UsingEntity(j => j.ToTable("TaskEmployees"));

                entity.HasMany(entity => entity.Roles)
                    .WithMany(entity => entity.Employees)
                    .UsingEntity(j => j.ToTable("EmployeeRoles"));

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(e => e.CareCenter);
            });

            modelBuilder.Entity<Resident>(entity =>
            {
                entity.HasKey(e => e.ResidentId);

                entity.Property(e => e.ResidentId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BirthDate)
                    .IsRequired();

                entity.Property(e => e.RoomNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasMany(e => e.Diagnoses);

                entity.HasMany(e => e.Prescriptions);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.HasKey(e => e.PrescriptionId);

                entity.Property(e => e.PrescriptionId)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });



            CareCenter cc = new CareCenter { CareCenterId = 1, Name = "Care Center 1", Address = new Address(1, "Solsikkevej 52", "Middelfart", "Syddanmark", "5500") };
            modelBuilder.Entity<Address>().HasData(
                    new Address() { AddressId = 1, Street = "Solsikkevej 55", City = "Middelfart", State = "Syddanmark", ZipCode = "5500" },
                    new Address() { AddressId = 2, Street = "Roskildevej 12", City = "Roskilde", State = "Sjælland", ZipCode = "4000" },
                    new Address() { AddressId = 3, Street = "Hovedgaden 1", City = "København", State = "Hovedstaden", ZipCode = "1000" },
                    new Address() { AddressId = 4, Street = "Viborgvej 5", City = "Viborg", State = "Midtjylland", ZipCode = "8800" },
                    new Address() { AddressId = 5, Street = "Herningvej 10", City = "Herning", State = "Midtjylland", ZipCode = "7400" },
                    new Address() { AddressId = 6, Street = "Odensevej 15", City = "Odense", State = "Syddanmark", ZipCode = "5000" },
                    new Address() { AddressId = 7, Street = "Aalborgvej 20", City = "Aalborg", State = "Nordjylland", ZipCode = "9000" },
                    new Address() { AddressId = 8, Street = "Esbjergvej 25", City = "Esbjerg", State = "Syddanmark", ZipCode = "6700" },
                    new Address() { AddressId = 9, Street = "Horsensvej 30", City = "Horsens", State = "Midtjylland", ZipCode = "8700" },
                    new Address() { AddressId = 10, Street = "Randersvej 35", City = "Randers", State = "Midtjylland", ZipCode = "8900" }
                );

            modelBuilder.Entity<CareCenter>().HasData(
                new CareCenter() { CareCenterId = 1, Name = "GGM (Glade Gamle Mennesker)", AddressId = 4 },
                new CareCenter() { CareCenterId = 2, Name = "Hjemmet", AddressId = 8 },
                new CareCenter() { CareCenterId = 3, Name = "Smilets Hus", AddressId = 5 },
                new CareCenter() { CareCenterId = 4, Name = "SFG (Sjov For Gamle)", AddressId = 2 },
                new CareCenter() { CareCenterId = 5, Name = "Solskinshjemmet", AddressId = 1 },
                new CareCenter() { CareCenterId = 6, Name = "Hyggehuset", AddressId = 3 },
                new CareCenter() { CareCenterId = 7, Name = "De Gamles Hus", AddressId = 6 }
                );
        }
    }
}


