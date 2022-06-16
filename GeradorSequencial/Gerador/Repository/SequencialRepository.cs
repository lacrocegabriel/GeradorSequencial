using GeradorSequencial.Gerador.Interfaces;

namespace GeradorSequencial.Gerador.Repository
{
    public class SequencialRepository : ISequencialRepository

    {
        public Sequencia Entity { get; set; }

        public SequencialRepository(Sequencia entity)
        {
            Entity = entity;
        }
        public void AdicionaSequencia(int numero)
        {
            Entity.SequenciaNumerica.Add(numero);

        }
    }
}
