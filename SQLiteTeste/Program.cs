using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SQLiteTeste.Models;
using System.Windows.Forms;

namespace SQLiteTeste
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<Form1>());

        }

        // � necess�rio criar o provedor de servi�os e adicionar todos os servi�os que se deseja prover por inje��o de depend�ncia
        // Use ServiceProvider.GetRequiredService<FormQualquer>() sempre que for necess�rio instanciar novos formul�rios e adicione-os ao reposit�rio de servi�os no corpo do m�todo a seguir.
        public static IServiceProvider? ServiceProvider { get; private set; }

        // M�todo de configura��o de inje��o de depend�ncia
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {

                    // Forms da Aplica��o
                    services.AddTransient<Form1>();

                    // Contexto Data Base
                    //services.AddDbContext<DogTreatmentDbContext>(
                    //        options => options.UseSqlite(@"Data Source=C:\\Users\\uliss\\source\\repos\\SQLiteTeste\\SQLiteTeste\\DatabaseTreatments.db;Cache=Shared"));
                    
                    services.AddDbContext<DogTreatmentDbContext>(
                            options => options.UseSqlite("Data Source=DatabaseTreatments.db;Cache=Shared"));
                    

                    //options => options.UseSqlite(@"Data Source=.\\bin\\Degug\\DatabaseTreatments.db;Cache=Shared"));
                    //options => options.UseSqlite("Data Source=.\\SQLiteTeste\\SQLiteTeste\\DatabaseTreatments.db;Cache=Shared"));
                    //services.AddDbContext<DogTreatmentDbContext>(options =>
                    //    options.UseSqlite("Data Source=" +
                    //    Path.Combine(Directory.GetCurrentDirectory(), "DatabaseTreatments.db"))
                    //);
                });
        }
    }
}