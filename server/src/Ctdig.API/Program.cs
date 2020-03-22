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
                agenciaRepository.ConfigurarAgencia(Guid.Parse("e7021fee-e0d0-47e7-8796-215a1dd9248b"), "CtDigBF Pagamentos", "CtDigBF", "03569262000160", Criptografia.CriptografarComMD5("123456"), "0001", "1");
            }
        }
    }
}
