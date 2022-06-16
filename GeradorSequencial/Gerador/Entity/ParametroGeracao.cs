namespace GeradorSequencial.Gerador
{
    public class ParametroGeracao
    {
        public int QuantidadeNumeros { get; set; }
        public int NumeroInicial { get; set; }
        public int NumeroFinal { get; set; }

        public ParametroGeracao(int quantidadeNumeros, int numeroInicial, int numeroFinal)
        {
            QuantidadeNumeros = quantidadeNumeros;
            NumeroInicial = numeroInicial;
            NumeroFinal = numeroFinal;
        }
    }
}
