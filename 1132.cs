using System;

namespace _1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int entrada2 = int.Parse(Console.ReadLine());
            int calculado = 0;

            
            if (entrada > entrada2)
            {
                int temp = entrada;
                entrada = entrada2;
                entrada2 = temp;
            }

            
            for (int i = entrada; i <= entrada2; i++)
            {
                if (i % 13 != 0)
                {
                    calculado += i;
                }
            }

            Console.WriteLine(calculado);
        }
    }
}
