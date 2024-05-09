using System;

class URI
{

    static void Main(string[] args)
    {

        int pares = 0;
        int impares = 0;
        int positivo = 0;
        int negativo = 0;

        for (int i = 0; i <= 4; i++)
        {
            string entrada = Console.ReadLine();

            int convert = int.Parse(entrada);

            int[] valores = new int[5];

            valores[i] = convert;



            if (valores[i] % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }

            if (valores[i] > 0)
            {
                positivo++;
            }
            else if(valores[i] < 0)
            {
                negativo++;
            }

        };

        Console.WriteLine(pares + " valor(es) par(es)");
        Console.WriteLine(impares + " valor(es) impar(es)");
        Console.WriteLine(positivo + " valor(es) positivo(s)");
        Console.WriteLine(negativo + " valor(es) negativo(s)");

    }

}