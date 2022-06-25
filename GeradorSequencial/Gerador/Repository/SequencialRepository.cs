using GeradorSequencial.Gerador.Interfaces;

namespace GeradorSequencial.Gerador.Repository
{
    public class SequencialRepository : ISequencialRepository

    {
        public string BuscaSequencia(Sequencia sequencia)
        {
            var resultado = string.Join(" - ", sequencia.SequenciaNumerica.OrderBy(i => i));
            return resultado.ToString();
        }

        public void AdicionaSequencia(Sequencia sequencia, int numero)
        {
            sequencia.SequenciaNumerica.Add(numero);
        }
    }
}
