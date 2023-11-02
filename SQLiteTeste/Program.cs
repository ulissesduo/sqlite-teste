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

        // É necessário criar o provedor de serviços e adicionar todos os serviços que se deseja prover por injeção de dependência
        // Use ServiceProvider.GetRequiredService<FormQualquer>() sempre que for necessário instanciar novos formulários e adicione-os ao repositório de serviços no corpo do método a seguir.
        public static IServiceProvider? ServiceProvider { get; private set; }

        // Método de configuração de injeção de dependência
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {

                    // Forms da Aplicação
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