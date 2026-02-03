using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int N = 1;
        int X = 0;
        double cont = 0;

        while (N > 0)
        {
            N = int.Parse(Console.ReadLine());
            


            if (N > 0)
            {
                X++;
                cont = cont + N;
            }

            if(N < 0)
            {
                double resultado = cont / X;
                Console.WriteLine(resultado.ToString("0.00", CultureInfo.InvariantCulture));
            }


        }


    }

}