using System;
using System.Linq; 

namespace _1149
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
           
            string[] a = entrada.Split(' '); 

            int A = int.Parse(a[0]);
            int N = int.Parse(a[1]);
            int resposta = 0;

            
            int valorMaiorQueZero = a
                .Skip(2)
                .Select(int.Parse)
                .FirstOrDefault(x => x > 0);

          
            while (N <= 0 && valorMaiorQueZero <= 0)
            {
                N = int.Parse(Console.ReadLine());
            }

           
            if (valorMaiorQueZero > 0)
            {
                N = valorMaiorQueZero;
            }

            if (N > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    resposta += A + i;
                }

                Console.WriteLine(resposta);
            }
        }
    }
}
