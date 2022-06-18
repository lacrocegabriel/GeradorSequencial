using GeradorSequencial.Gerador.Interfaces;

namespace GeradorSequencial.Gerador.Repository
{
    public class SequencialRepository : ISequencialRepository

    {
        public string BuscaSequencia(Sequencia sequencia)
        {
            var resultado = string.Join(" - ", sequencia.SequenciaNumerica);
            return resultado.ToString();
        }

        public void AdicionaSequencia(Sequencia seq, int numero)
        {
            seq.SequenciaNumerica.Add(numero);
        }
    }
}
