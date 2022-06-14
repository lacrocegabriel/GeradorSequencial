var random = new Random();
var list = new List<int>();
int NumeroGerado = 0;
int quantidade;
int j = 0;


Console.WriteLine("Digite a sequencia de números que irá utilizar");
quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidade; i++)
{
    j = 0;
    NumeroGerado = random.Next(1, 60);
    
    while (j == 0)
    {
        if (list.Contains(NumeroGerado))
        {
            NumeroGerado = random.Next(1, 60);
            j = 0;
        }
        else
        {
            j = 1;
        }
    }
    list.Add(NumeroGerado);

}


foreach (int n in list)
{
    Console.Write(n.ToString()," - ");
}






