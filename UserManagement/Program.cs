using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using UserManagement.Api.Middleware;
using UserManagement.BLL.Interfaces;
using UserManagement.BLL.Mapping;
using UserManagement.BLL.Services;
using UserManagement.BLL.Validators;
using UserManagement.DAL.Data;
using UserManagement.DAL.Interfaces;
using UserManagement.DAL.Repositories;

namespace UserManagement.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
           

            var builder = WebApplication.CreateBuilder(args); ;

            // Add services to the container

            // 1. Add Controllers
            builder.Services.AddControllers();

            // 2. Add DbContext
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection"),
                    sqlOptions => sqlOptions.CommandTimeout(30))
            );

            // 3. Add Repository Pattern
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            // 4. Add Business Logic Services
            builder.Services.AddScoped<IUserService, UserService>();

            // 5. Add AutoMapper
            builder.Services.AddAutoMapper(typeof(UserProfile));

            // 6. Add FluentValidation
            builder.Services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();
            builder.Services.AddScoped<UserRequestValidator>();

            // 7. Add Swagger/OpenAPI
            //builder.Services.AddOpenApi();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // 8. Add Logging
            builder.Services.AddLogging(config =>
            {
                config.AddConsole();
                config.AddDebug();
            });

            // 9. Add CORS (if needed)
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline

            // 1. Use Swagger in Development
            if (app.Environment.IsDevelopment())
            {
                //app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "User Management API v1");
                    c.RoutePrefix = string.Empty; // Swagger at root
                });
            }

            // 2. Middleware Pipeline
            app.UseHttpsRedirection();
            app.UseCors("AllowAll");
            app.UseAuthorization();

            // 3. Map Controllers
            app.MapControllers();

            // 4. Global Exception Handling Middleware (see Section 8)
            app.UseMiddleware<GlobalExceptionHandlingMiddleware>();

            app.Run();
        }
    }
}
