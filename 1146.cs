using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            int entrada = int.Parse(Console.ReadLine());

            if (entrada == 0)
                break;

            List<string> numeros = new List<string>();
            for (int i = 1; i <= entrada; i++)
            {
                numeros.Add(i.ToString());
            }

            Console.WriteLine(string.Join(" ", numeros));
        }
    }
}
