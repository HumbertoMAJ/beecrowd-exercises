using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {


        string entrada = Console.ReadLine();

        string[] separar = entrada.Split(' ');

        int conver = int.Parse(separar[0]);
        double conver2 = double.Parse(separar[1]);


        double[] n = { 0, 4.00, 4.50, 5.00, 2.00, 1.50 };

        double calculo = n[conver] * conver2;

        Console.WriteLine("Total: R$ "+calculo.ToString("0.00", CultureInfo.InvariantCulture));



    }

}