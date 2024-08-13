using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());


        for (int i = 0; i < N; i++) 
        {

            string Ent = Console.ReadLine();

            string[] separar = Ent.Split(' ');

            double a1 = double.Parse(separar[0], CultureInfo.InvariantCulture);
            double a2 = double.Parse(separar[1], CultureInfo.InvariantCulture);
            double a3 = double.Parse(separar[2], CultureInfo.InvariantCulture);

            double calc = (a1*2 + a2*3 + a3*5) / 10;
            Console.WriteLine(calc.ToString("0.0", CultureInfo.InvariantCulture));


        }




    }

}