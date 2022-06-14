var random = new Random();
int quantidade;

Console.WriteLine("Digite a sequencia de números que irá utilizar");
quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine(random.Next(1, 60));
}






