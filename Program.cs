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
            EstruturasSequencias();
            Console.ReadKey();
        }

        static void EstruturasSequencias()
        {
            string nome;
            int n1, n2, r;

            Console.Write("Informe seu nome: ");   //comando para exibir mensagem ao usuário
            nome = Console.ReadLine();             //comando para receber valor digitado pelo user
            Console.Write("Informe um numero: ");   //comando para exibir mensagem ao usuário
            n1 = int.Parse(Console.ReadLine());     //parse receber string e converte em inteiro

            Console.Write("Informe outro numero: ");  
            n2 = int.Parse(Console.ReadLine());
            r = n1 + n2;
            Console.Write(nome + ", a soma dos dois número é " + r);

        }
    }
}
