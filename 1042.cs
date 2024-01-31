using System;

class URI
{

    static void Main(string[] args)
    {

        string valores = Console.ReadLine();

        string[] separar = valores.Split(' ');

        int val1 = int.Parse(separar[0]);
        int val2 = int.Parse(separar[1]);
        int val3 = int.Parse(separar[2]);

        int[] numeros = new int[] { val1, val2, val3 };


        Array.Sort(numeros);

        foreach (int num in numeros) Console.WriteLine(num);

        Console.WriteLine();

        Console.WriteLine(val1);
        Console.WriteLine(val2);
        Console.WriteLine(val3);




    }

}