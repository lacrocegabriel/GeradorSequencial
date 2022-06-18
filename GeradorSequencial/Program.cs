using GeradorSequencial.Gerador;
using GeradorSequencial.Gerador.Services;
using GeradorSequencial.Gerador.Repository;
using Microsoft.Extensions.DependencyInjection;
using GeradorSequencial.Gerador.Interfaces;

namespace GeradorSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var sequencialService = serviceProvider.GetService<ISequencialService>();

            var list = new Sequencia(new List<int>());

            Console.Write("Digite quantos números irá gerar: ");
            var quantidadeNumeros = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero inicial da geração: ");
            var numeroInicial = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero final da geração: ");
            
            var numeroFinal = int.Parse(Console.ReadLine());

            var parametro = new ParametroGeracao(quantidadeNumeros, numeroInicial, numeroFinal);

            sequencialService.AdicionaSequencia(parametro, list);

            Console.WriteLine(sequencialService.RetornaSequencia(list));
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISequencialService, SequencialService>()
                .AddScoped<IGeradorSequencialService, GeradorSequencialService>()
                .AddScoped<ISequencialRepository, SequencialRepository>();
        }
    }
}







