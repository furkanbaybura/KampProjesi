using KampYeri.BLL.Managers.Concrete;
using KampYeri.DAL.Context;
using KampYeri.DAL.Repositories.Concrete;
using KampYeri.DAL.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace KampYeri
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<KampYeriDbContext>( c =>
            {
                c.UseSqlServer(
                    builder.Configuration.GetConnectionString("KampYeriConStr"));
            }, ServiceLifetime.Singleton);

            builder.Services.AddAutoMapper(typeof(Assembly));

            builder.Services.AddSingleton<CadirRepo>();
            builder.Services.AddSingleton<CadirService>();
            builder.Services.AddSingleton<CadirManager>();

            // Kategori Implimentation
            builder.Services.AddSingleton<KapasiteRepo>();
            builder.Services.AddSingleton<KapasiteService>();
            builder.Services.AddSingleton<KapasiteManager>();

            builder.Services.AddSingleton<KampBolgesiRepo>();
            builder.Services.AddSingleton<KampBolgesiService>();
            builder.Services.AddSingleton<KampBolgesiManager>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
