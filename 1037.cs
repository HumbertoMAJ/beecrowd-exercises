using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();
        double conversao = Double.Parse(entrada, CultureInfo.InvariantCulture);

        if (conversao < 0 || conversao > 100.0000000)
        {
            Console.WriteLine("Fora de intervalo");

        }
        else if (conversao >= 0 && conversao <= 25.0000)
        {
            Console.WriteLine("Intervalo [0,25]");

        }
        else if (conversao >= 25.00001 && conversao <= 50.0000000)
        {
            Console.WriteLine("Intervalo (25,50]");

        }
        else if (conversao >= 50.0000001 && conversao <= 75.0000000)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (conversao >= 75.0000001 && conversao <= 100.0000000)
        {
            Console.WriteLine("Intervalo (75,100]");
        }



    }

}