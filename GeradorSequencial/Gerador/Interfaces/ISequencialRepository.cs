using GeradorSequencial.Gerador;

namespace GeradorSequencial.Gerador.Interfaces
{
    public interface ISequencialRepository
    {
        string BuscaSequencia(Sequencia sequencia);
        void AdicionaSequencia(Sequencia sequencia,int numero);
    }
}
