using GeradorSequencial.Gerador.Interfaces;

namespace GeradorSequencial.Gerador.Services
{
    public class SequencialService : ISequencialService
    {
        protected readonly ISequencialRepository _sequencia;
        protected readonly IGeradorSequencialService _geradorSequencia;

        public SequencialService(
            ISequencialRepository sequencia,
            IGeradorSequencialService geradorSequencia)
        {
            _sequencia = sequencia;
            _geradorSequencia = geradorSequencia;
        }
        public void AdicionaSequencia(ParametroGeracao parametro,Sequencia sequencia)
        {
            for (int i = 0; i < parametro.QuantidadeNumeros; i++)
            {
                var numero = _geradorSequencia.GeraNumero(parametro);

                while (sequencia.Validar(numero) == false)
                {
                    numero = _geradorSequencia.GeraNumero(parametro);
                }
                _sequencia.AdicionaSequencia(numero);
            }
        }
    }
}
