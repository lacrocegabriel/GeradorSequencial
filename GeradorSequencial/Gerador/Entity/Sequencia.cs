namespace GeradorSequencial.Gerador
{
    public class Sequencia
    {
        public List<int> SequenciaNumerica { get; private set; }
        
        public Sequencia(List<int> sequencia)
        {
            SequenciaNumerica = sequencia;
        }

        public bool Validar(int numero)
        {
            if (SequenciaNumerica.Contains(numero))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string RetornaSequencia()
        {
            var sequencia = string.Join(" - ", SequenciaNumerica);
            return sequencia.ToString();
        }

    } 
}
