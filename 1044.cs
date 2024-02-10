using System;

class URI
{

    static void Main(string[] args)
    {

        string valor = Console.ReadLine();

        string[] v = valor.Split(' ');

        int a = int.Parse(v[0]);
        int b = int.Parse(v[1]);

        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }



    }

}