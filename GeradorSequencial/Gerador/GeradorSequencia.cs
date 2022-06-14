using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSequencial.Gerador
{
    public class GeradorSequencia
    {
        public int Numero { get; private set; }
        public List<int> Sequencia {  get; private set; }
        protected int ValidaInsercao { get; set; }

        public GeradorSequencia(int numero)
        {
            Numero = numero;
            Sequencia = new List<int>();
        }

        public void GeraSequencial(int numero) 
        {
            for (int i = 0; i < numero; i++)
            {
                ValidaInsercao = 0;
                int NumeroGerado = new Random().Next(1,60);

                while (ValidaInsercao == 0)
                {
                    if (Sequencia.Contains(NumeroGerado))
                    {
                        NumeroGerado = new Random().Next(1, 60);
                        ValidaInsercao = 0;
                    }
                    else
                    {
                        ValidaInsercao = 1;
                    }
                }
                Sequencia.Add(NumeroGerado);
               
            }

        }

    }
}
