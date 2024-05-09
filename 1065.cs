using System;

class URI
{

    static void Main(string[] args)
    {

        int numero = 0;

        for (int i =0; i <= 4; i++)
        {
            string entrada = Console.ReadLine();

            int convert = int.Parse(entrada);

            int[] valores = new int[5];

            valores[i] = convert;

           

            if (valores[i] % 2 == 0)
            {
                numero++;
            }
           

        };

        Console.WriteLine(numero + " valores pares");

    }

}