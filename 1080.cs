using System;

class URI
{

    static void Main(string[] args)
    {

        int[] N = new int[100];
        int maiorvalor = 0;

        for (int i = 0; i < 100; i++) 
        {

            string input = Console.ReadLine();

            int convert = int.Parse(input);

            N[i]  = convert;

        }


        for (int i = 0; i < 100; i++)
        {
            if (N[i] > maiorvalor)
            {
                maiorvalor = N[i];
            }

        }

        Console.WriteLine(maiorvalor);
        int indice = Array.IndexOf(N, maiorvalor);
        Console.WriteLine(indice+1);



    }

}