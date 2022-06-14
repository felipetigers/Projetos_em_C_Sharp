using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoEletricoResidencial
{
    class Aparelho
    {
        //atributos
        public string Nome;
        public float Potencia, TempoUso;
        public int Qtde;

        //método
        public float solucao(string op)
        {
            float res;

            switch (op)
            {
                case "verde": res = 0.5f; break;
                case "amarelo": res = 0.02f; break;
                case "vermelho": res = 0.035f; break;
                default: res = 0; break;
            }

            return res;
        }

        public float calculoConsumo()
        {
            return Potencia * TempoUso * Qtde;
        }

    }
}
