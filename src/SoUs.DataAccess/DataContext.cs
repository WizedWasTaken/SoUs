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
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<CareCenter> CareCenters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Assignment>(entity =>
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

                entity.HasMany(e => e.Roles)
                      .WithMany(r => r.Employees)
                      .UsingEntity<Dictionary<string, object>>(
                          "EmployeeRole",
                          j => j.HasOne<Role>().WithMany().HasForeignKey("RoleId"),
                          j => j.HasOne<Employee>().WithMany().HasForeignKey("EmployeeId")
                      );

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
                new { CareCenterId = 1, Name = "Middelfart Plejehjem", AddressId = 1 },
                new { CareCenterId = 2, Name = "Roskilde Plejehjem", AddressId = 2 },
                new { CareCenterId = 3, Name = "København Plejehjem", AddressId = 3 },
                  new { CareCenterId = 4, Name = "Viborg Plejehjem", AddressId = 4 },
                  new { CareCenterId = 5, Name = "Herning Plejehjem", AddressId = 5 },
                  new { CareCenterId = 6, Name = "Odense Plejehjem", AddressId = 6 },
                  new { CareCenterId = 7, Name = "Aalborg Plejehjem", AddressId = 7 },
                  new { CareCenterId = 8, Name = "Esbjerg Plejehjem", AddressId = 8 },
                  new { CareCenterId = 9, Name = "Horsens Plejehjem", AddressId = 9 },
                  new { CareCenterId = 10, Name = "Randers Plejehjem", AddressId = 10 }
                );

            modelBuilder.Entity<Medicine>().HasData(
                new Medicine() { MedicineId = 1, Name = "Paracetamol", Unit = "mg", Amount = 500, Administered = false },
                new Medicine() { MedicineId = 2, Name = "Ibuprofen", Unit = "mg", Amount = 400, Administered = true },
                new Medicine() { MedicineId = 3, Name = "Vitamin D", Unit = "ug", Amount = 10, Administered = false },
                new Medicine() { MedicineId = 4, Name = "Vitamin C", Unit = "mg", Amount = 100, Administered = false },
                new Medicine() { MedicineId = 5, Name = "Vitamin B12", Unit = "ug", Amount = 2, Administered = false },
                new Medicine() { MedicineId = 6, Name = "Magnesium", Unit = "mg", Amount = 200, Administered = true }
                );


            modelBuilder.Entity<Diagnosis>().HasData(
                new Diagnosis() { DiagnosisId = 1, Name = "Alzheimer", Description = "Alzheimer er en sygdom, der angriber hjernen og fører til hukommelsestab og nedsat kognitiv funktion." },
                new Diagnosis() { DiagnosisId = 2, Name = "Demens", Description = "Demens er en samlet betegnelse for en række symptomer, der skyldes sygdomme i hjernen." },
                new Diagnosis() { DiagnosisId = 3, Name = "Parkinson", Description = "Parkinson er en kronisk sygdom, der angriber hjernen og fører til rysten, stivhed og langsomme bevægelser." },
                new Diagnosis() { DiagnosisId = 4, Name = "KOL", Description = "KOL er en samlet betegnelse for en række lungesygdomme, der gør det svært at trække vejret." }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role() { RoleId = 1, RoleName = "SoSu Hjælper" },
                new Role() { RoleId = 2, RoleName = "Task planner" },
                new Role() { RoleId = 3, RoleName = "Administrativ medarbejder" }
                );

            modelBuilder.Entity<Employee>().HasData(
                new { EmployeeId = 1, Name = "Mette Jensen", CareCenterId = 1 },
                new { EmployeeId = 2, Name = "Lars Nielsen", CareCenterId = 1 },
                new { EmployeeId = 3, Name = "Helle Pedersen", CareCenterId = 1 },
                new { EmployeeId = 4, Name = "Mads Hansen", CareCenterId = 1 },
                new { EmployeeId = 5, Name = "Lone Madsen", CareCenterId = 1 },
                new { EmployeeId = 6, Name = "Jens Pedersen", CareCenterId = 1 },
                new { EmployeeId = 7, Name = "Lise Jensen", CareCenterId = 2 },
                new { EmployeeId = 8, Name = "Hans Nielsen", CareCenterId = 2 },
                new { EmployeeId = 9, Name = "Mette Pedersen", CareCenterId = 2 },
                new { EmployeeId = 10, Name = "Lars Hansen", CareCenterId = 2 },
                new { EmployeeId = 11, Name = "Helle Madsen", CareCenterId = 2 },
                new { EmployeeId = 12, Name = "Mads Pedersen", CareCenterId = 2 },
                new { EmployeeId = 13, Name = "Lone Hansen", CareCenterId = 3 },
                new { EmployeeId = 14, Name = "Jens Madsen", CareCenterId = 3 },
                new { EmployeeId = 15, Name = "Lise Pedersen", CareCenterId = 3 },
                new { EmployeeId = 16, Name = "Hans Jensen", CareCenterId = 3 },
                new { EmployeeId = 17, Name = "Mette Nielsen", CareCenterId = 4 },
                new { EmployeeId = 18, Name = "Lars Pedersen", CareCenterId = 4 },
                new { EmployeeId = 19, Name = "Helle Hansen", CareCenterId = 4 },
                new { EmployeeId = 20, Name = "Mads Madsen", CareCenterId = 4 }
                );

            modelBuilder.Entity("EmployeeRole").HasData(
                new { EmployeeId = 1, RoleId = 1 },
                new { EmployeeId = 1, RoleId = 2 },
                new { EmployeeId = 2, RoleId = 2 },
                new { EmployeeId = 3, RoleId = 1 },
                new { EmployeeId = 3, RoleId = 3 },
                new { EmployeeId = 4, RoleId = 1 },
                new { EmployeeId = 5, RoleId = 1 },
                new { EmployeeId = 6, RoleId = 1 },
                new { EmployeeId = 7, RoleId = 1 },
                new { EmployeeId = 8, RoleId = 1 },
                new { EmployeeId = 9, RoleId = 1 },
                new { EmployeeId = 10, RoleId = 1 },
                new { EmployeeId = 11, RoleId = 1 },
                new { EmployeeId = 12, RoleId = 1 },
                new { EmployeeId = 13, RoleId = 1 },
                new { EmployeeId = 14, RoleId = 1 },
                new { EmployeeId = 15, RoleId = 1 },
                new { EmployeeId = 16, RoleId = 1 },
                new { EmployeeId = 17, RoleId = 1 },
                new { EmployeeId = 18, RoleId = 1 },
                new { EmployeeId = 19, RoleId = 1 },
                new { EmployeeId = 20, RoleId = 1 }
            );

            modelBuilder.Entity<Resident>().HasData(
                new { ResidentId = 1, Name = "Hans Hansen", BirthDate = new DateTime(1930, 1, 1), RoomNumber = "101", CareCenterId = 1, Notes = "Hans har brug for hjælp til at komme op om morgenen.", Diagnoses = 4 },
                new { ResidentId = 2, Name = "Lise Jensen", BirthDate = new DateTime(1940, 2, 2), RoomNumber = "102", CareCenterId = 1, Notes = "Lise har brug for hjælp til at tage medicin.", Diagnoses = 3 },
                new { ResidentId = 3, Name = "Mads Nielsen", BirthDate = new DateTime(1950, 3, 3), RoomNumber = "103", CareCenterId = 1, Notes = "Mads har brug for hjælp til at komme i bad.", Diagnoses = 2 },
                new { ResidentId = 4, Name = "Lone Pedersen", BirthDate = new DateTime(1960, 4, 4), RoomNumber = "104", CareCenterId = 1, Notes = "Lone har brug for hjælp til at komme i tøj.", Diagnoses = 1 },
                new { ResidentId = 5, Name = "Jens Madsen", BirthDate = new DateTime(1970, 5, 5), RoomNumber = "105", CareCenterId = 1, Notes = "Jens har brug for hjælp til at komme i seng.", Diagnoses = 4 },
                new { ResidentId = 6, Name = "Helle Hansen", BirthDate = new DateTime(1980, 6, 6), RoomNumber = "106", CareCenterId = 1, Notes = "Helle har brug for hjælp til at komme i kørestol.", Diagnoses = 1 },
                new { ResidentId = 7, Name = "Mette Jensen", BirthDate = new DateTime(1990, 7, 7), RoomNumber = "107", CareCenterId = 1, Notes = "Mette har brug for hjælp til at komme i stol.", Diagnoses = 3 },
                new { ResidentId = 8, Name = "Lars Nielsen", BirthDate = new DateTime(2000, 8, 8), RoomNumber = "108", CareCenterId = 1, Notes = "Lars har brug for hjælp til at komme i seng.", Diagnoses = 2 }
                );

        }
    }
}


