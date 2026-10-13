
using CompanyMangmentSystem.Data;
using CompanyMangmentSystem.Repo.Contract;
using CompanyMangmentSystem.Repo.Implementation;
using CompanyMangmentSystem.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace CompanyMangmentSystem
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
            builder.Services.AddDbContext<App_Database_Context>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Con")));
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
            builder.Services.AddScoped(typeof(IGenericRepo<>),typeof(GenericRepo<>));
            builder.Services.AddScoped<IUnitOfWork, UnitOfWorkIMP>();

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
