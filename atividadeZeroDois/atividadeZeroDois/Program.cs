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

            int valor;
            int total = 0;
            int i = 0;

            do
            {
                Console.Write("Digite um número par: ");
                valor = int.Parse(Console.ReadLine());


                if (valor % 2 == 0)
                {
                    if (valor > 0)  // O zero não é par nem impar então precisa dessa verificação
                                    // para cortar ele aqui caso não, iria fazer o I++ incrementar e afetar o calculo
                    {
                        total = valor + total;
                        i++;
                    }

                }


            } while (valor != 0);

            
            Console.WriteLine(total / i);

            Console.ReadKey();

        }
    }
}
