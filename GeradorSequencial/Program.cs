using GeradorSequencial.Gerador;

namespace GeradorSequencial
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a sequencia de números que irá utilizar");
            int numero = int.Parse(Console.ReadLine());

            GeradorSequencia quantidadeSequencia = new GeradorSequencia(numero);
            quantidadeSequencia.GeraSequencial(numero);

            foreach (int i in quantidadeSequencia.Sequencia)
            {
                Console.Write(i + "  ");
            }
        }
    }
}







