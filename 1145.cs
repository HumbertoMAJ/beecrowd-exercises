using System;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        string[] separar = entrada.Split(' ');

        int X = int.Parse(separar[0]);
        int Y = int.Parse(separar[1]);

        if (X > 1 && X < 20 && Y > X && Y < 100000)
        {
            List<string> lista = new List<string>();

            for (int i = 1; i <= Y; i++)
            {
                lista.Add(i.ToString());

                if (lista.Count == X)
                {
                    Console.WriteLine(string.Join(" ", lista));
                    lista.Clear();
                }
            }

           
            if (lista.Count > 0)
            {
                Console.WriteLine(string.Join(" ", lista));
            }
        }
    }
}
