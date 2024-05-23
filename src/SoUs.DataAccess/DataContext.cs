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
        }
    }
}


