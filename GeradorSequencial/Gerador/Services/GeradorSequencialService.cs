using GeradorSequencial.Gerador.Interfaces;

namespace GeradorSequencial.Gerador.Services
{
    public class GeradorSequencialService : IGeradorSequencialService
    {
        public int GeraNumero(ParametroGeracao parametro) 
        {
            int NumeroGerado = new Random().Next(parametro.NumeroInicial, parametro.NumeroFinal);
            return NumeroGerado;
        }
    }
}
