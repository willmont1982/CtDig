using Agencia.Domain.Agencia.Repository;
using Core.Domain.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Ctdig.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            ConfigurarAgencia(host);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void ConfigurarAgencia(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var agenciaRepository = services.GetRequiredService<IAgenciaRepository>();
                agenciaRepository.ConfigurarAgencia(Guid.Parse("be71a41e-99b2-4d8b-971e-b194657cebfc"), "Ctdig Pagamentos", "Ctdig", "22155606000139", Criptografia.CriptografarComMD5("21032020"), "0001", "1");
            }
        }
    }
}
