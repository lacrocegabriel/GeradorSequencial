using GeradorSequencial.Gerador;
using GeradorSequencial.Gerador.Services;
using GeradorSequencial.Gerador.Repository;

namespace GeradorSequencial
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite quantos números irá gerar: ");
                var quantidadeNumeros = int.Parse(Console.ReadLine());
                Console.Write("Digite o numero inicial da geração: ");
                var numeroInicial = int.Parse(Console.ReadLine());
                Console.Write("Digite o numero final da geração: ");
                var numeroFinal = int.Parse(Console.ReadLine());

                var parametro = new ParametroGeracao(quantidadeNumeros, numeroInicial, numeroFinal);
                var sequencia = new Sequencia(new List<int>());
                var geraRepo = new SequencialRepository(sequencia);
                var geraNum = new GeradorSequencialService();
                var geraServ = new SequencialService(geraRepo, geraNum);

                geraServ.AdicionaSequencia(parametro, sequencia);

                Console.WriteLine(sequencia.RetornaSequencia());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}







