using System;

class URI
{

    static void Main(string[] args)
    {
        int maior, menor;
        int soma = 0;

        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());

        if( X < Y)
        {
            maior = Y;
            menor = X;
        }
        else
        {
            maior = X;
            menor = Y;
        }
        

        for(int i = menor+1; i < maior; i++)
        {
            if (i % 2 != 0)
            {
                soma = soma + i;
            }
        }
        Console.WriteLine(soma);


    }

}