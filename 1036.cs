using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string valores = Console.ReadLine();
        //---------------------------------

        string[] separar = valores.Split(' ');
        //---------------------------------
        double A = Double.Parse(separar[0], CultureInfo.InvariantCulture);
        double B = Double.Parse(separar[1], CultureInfo.InvariantCulture);
        double C = Double.Parse(separar[2], CultureInfo.InvariantCulture);
        //---------------------------------
        double delta = (Math.Pow(B, 2) - (4 * A * C));            
        //---------------------------------
        double r1 = (-B + (Math.Sqrt(delta))) / (2 * A);
        double r2 = (-B - (Math.Sqrt(delta))) / (2 * A);
        //--------------------------------
        if (A != 0 && delta > 0)
        {
            Console.WriteLine("R1 = " + r1.ToString("F5",CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
        }

        }


    

}
