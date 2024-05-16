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
    }
}
