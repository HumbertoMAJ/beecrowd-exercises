using System;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();

        string[] valores = entrada.Split(' ');

        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int resultado;

        if (a > b)
        {
            resultado = (24 - a) + b;
            Console.WriteLine("O JOGO DUROU "+resultado+" HORA(S)");

        }
        else if (a == b)
        {
            resultado = 24;
            Console.WriteLine("O JOGO DUROU " + resultado + " HORA(S)");

        }
        else if (a < b)
        {
            resultado = b - a;
            Console.WriteLine("O JOGO DUROU " + resultado + " HORA(S)");
        }
        

        

    }

}