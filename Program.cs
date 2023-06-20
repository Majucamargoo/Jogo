using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int pontos =0;

            Console.WriteLine(" \n ---Bem-Vindo ao jogo do 21");
            Console.WriteLine("Faça 21 pontos para vencer");
          
            while (true)
            {
                Console.WriteLine($"Você tem {pontos} pontos");
                Console.WriteLine("Digite 1 para continuar ou 2 para parar");
                int resp =int.Parse (Console.ReadLine());

                if (resp ==2)
                {
                    Console.WriteLine("FIM DE JOGO!");
                    break;
                }

                Random sorteador = new Random();
                int number = sorteador.Next(1,11);
                
                Console.WriteLine($"Você tirou o número {number}");
                pontos += number;

                if (pontos>=21)
                {
                    Console.WriteLine(" \n\n\n FIM DE JOGO!");
                    break;
                }
                
            }
            
           
           
                
                
            

            Console.ReadKey();
        }
    }
}
