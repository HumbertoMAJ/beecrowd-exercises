using System;

namespace _1133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            // Corrigindo a troca de valores
            if (valor > valor2)
            {
                int temp = valor;
                valor = valor2;
                valor2 = temp;
            }

            for (int i = valor + 1; i < valor2; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
