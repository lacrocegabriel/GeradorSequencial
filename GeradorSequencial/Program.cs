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

            string encerra = "n";

            while (encerra != "s")
            {
                Console.Clear();
                Console.Write("Quantas sequencias deseja gerar? ");
                int sequencias = int.Parse(Console.ReadLine());


                Console.Write("Digite quantos números irá gerar: ");
                var quantidadeNumeros = int.Parse(Console.ReadLine());
                Console.Write("Digite o numero inicial da geração: ");
                var numeroInicial = int.Parse(Console.ReadLine());
                Console.Write("Digite o numero final da geração: ");

                var numeroFinal = int.Parse(Console.ReadLine());

                var parametro = new ParametroGeracao(quantidadeNumeros, numeroInicial, numeroFinal);

                for (int i = 1; i <= sequencias; i++)
                {
                    sequencialService.AdicionaSequencia(parametro, list);

                    Console.WriteLine(sequencialService.RetornaSequencia(list));

                    list = new Sequencia(new List<int>());
                }
                Console.WriteLine("Deseja encerrar o sistema? s/n");
                encerra = Console.ReadLine();
            }
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISequencialService, SequencialService>()
                .AddScoped<IGeradorSequencialService, GeradorSequencialService>()
                .AddScoped<ISequencialRepository, SequencialRepository>();
        }
    }
}







