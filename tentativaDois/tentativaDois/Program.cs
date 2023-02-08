using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeZero
{
    class Program
    {
        static void Main(string[] args)
        {

            int vezes;
            int valor;
            int total = 0;
            int valorFinal;
            int i = 1;

            Console.Write("insira quantos vezes deseja somar: ");
            vezes = int.Parse(Console.ReadLine());


            do
            {
                Console.Write("Digite um número (não vale impar ou 0): ");
                valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    Console.WriteLine("Valor digitado 0, fim");
                    Console.ReadKey();
                    return;
                }

                else
                {
                    if (valor % 2 == 0)
                    {
                        total = valor + total;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Valor digitado impar, tente novamente");
                       // Console.ReadKey();
                        //return;
                    }
                }

                
                

            } while (vezes >= i);

            valorFinal = total / vezes;

            Console.WriteLine("O resultado deu: " + valorFinal);

            Console.ReadKey();

        }
    }
}
