using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AfectacionMedioAmbiental.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AfectacionMedioAmbiental
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            Facturacion facturas = new Facturacion();

            decimal monto = 100.15M;

            Console.WriteLine("El IGV es: " + facturas.CalcularIgv(monto).ToString());
            Console.WriteLine("El monto redondeado es: " + facturas.redondeaMonto(monto).ToString());
            Console.WriteLine();


            CSuma s = new CSuma();
            s.calcular(4.5, 6.7);
            s.mostrar();


            ImpactoAmbiental impacto = new ImpactoAmbiental();

            impacto.Contaminacion = new Contaminacion();
            var resutadoAfectacion = impacto.Afectar();
            Console.WriteLine(resutadoAfectacion);

            impacto.Contaminacion = new ContaminacionMundial();
            resutadoAfectacion = impacto.Afectar();
            Console.WriteLine(resutadoAfectacion);

            Console.Read();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

