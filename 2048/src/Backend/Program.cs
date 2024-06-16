using System;
using System.Windows.Forms;
using _2048.src;
using _2048.src.Backend.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace _2048
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Setup Dependency Injection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Resolve the main form and run the application
            var formMenu = serviceProvider.GetRequiredService<FormMenu>();
            Application.Run(formMenu);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Register your DbContext
            services.AddDbContext<HighscoreDataContext>(options =>
                options.UseSqlServer(@"Server=localhost;Database=2048_VulpesDev;Uid=root;Pwd=123321;"));

            // Register your FormMenu (or other forms/services)
            services.AddTransient<FormMenu>();
        }
    }
}
