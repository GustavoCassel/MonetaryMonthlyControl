using AppWeb.Models;

namespace AppWeb;

public class Program
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services
            .AddRazorPages()
            .AddRazorRuntimeCompilation();

        builder.Services.AddDbContext<MyDbContext>();

        WebApplication app = builder.Build();

        app.UseDefaultFiles();

        app.UseStaticFiles();

        app.MapRazorPages();

        app.Run();
    }
}