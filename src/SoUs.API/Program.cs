
using Microsoft.EntityFrameworkCore;
using SoUs.DataAccess;
using SoUs.Entities;
using System.Text.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;

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
                options.UseSqlServer(builder.Configuration.GetConnectionString("CONNECTION_STRING")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
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

            builder.Services.AddControllers()
                   // Handle cyclic dependencies in JSON:
                   .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            builder.Services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });


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
