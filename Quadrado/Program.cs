using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilizarQuadrado();
            Console.ReadKey();      //permite pausar a tela para ver os dados de saida
        }

        static void UtilizarQuadrado()
        {
            float l, p;
            Quadrado q = new Quadrado();  //cria-se um objeto e o instancia na memoria heap ao mesmo tempo
            
            //console.write usado pra mostrar informacaoes na tela
            Console.Write("Informe o valor do lado: ");
            l = float.Parse(Console.ReadLine());    //atribui o valor recebido à variável "l"
            q.Lado = l;
            p = q.Perimetro();
            
            Console.WriteLine("O lado é " + l);            
            Console.WriteLine("O perimetro do quadrado eh " + p);
            
            

        }
    }
}
