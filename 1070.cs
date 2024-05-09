using System;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();
        int convert = int.Parse(entrada);
        int contador = 0;

        for(int i = 0; i <= 20; i++)
        {
            if (convert % 2 != 0)
            {
                Console.WriteLine(convert);
                contador++;
            }
            convert++;

            if(contador == 6)
            {
                break;
            }
        }

    }

}