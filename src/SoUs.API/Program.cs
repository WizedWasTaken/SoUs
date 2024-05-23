
using Microsoft.EntityFrameworkCore;
using SoUs.DataAccess;
using SoUs.Entities;

namespace SoUs.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("CONNECTION_STRING"));
            });

            builder.Services.AddScoped<IRepository<Assignment>, Repository<Assignment>>();
            builder.Services.AddScoped<IRepository<Address>, Repository<Address>>();
            builder.Services.AddScoped<IRepository<CareCenter>, Repository<CareCenter>>();
            builder.Services.AddScoped<IRepository<Diagnosis>, Repository<Diagnosis>>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IRepository<Medicine>, Repository<Medicine>>();
            builder.Services.AddScoped<IRepository<Prescription>, Repository<Prescription>>();
            builder.Services.AddScoped<IRepository<Resident>, Repository<Resident>>();
            builder.Services.AddScoped<IRepository<Role>, Repository<Role>>();
            builder.Services.AddScoped<IAssignmentRepository, AssignmentRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
