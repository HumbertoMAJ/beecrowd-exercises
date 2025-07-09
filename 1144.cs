using System;


namespace _1144
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
                           
            int numero = 0;
            int numero2 = 0;
            int numero3 = 0;

            if (N > 1 && N < 1000)
            {
                N = N * 2;
                for (int i = 0; i < N; i++)
                {
                    ++numero;

                    numero2 = numero * numero;
                    numero3 = numero * numero2;

                    Console.WriteLine(numero + " " + numero2 + " " + numero3);
                    Console.WriteLine(numero + " " + ++numero2 + " " + ++numero3);
                   

                    numero2 = 0;
                    numero3 = 0;
                    N--;
                }

            }



        }
    }
}
