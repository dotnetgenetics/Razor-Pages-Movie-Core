using Microsoft.EntityFrameworkCore;
using RazorPagesMovieCore.Data;

namespace RazorPagesMovieCore
{
    /// <summary>
    /// Tutorial: Create a Razor Pages web app with ASP.NET Core
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesMovieContext")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
