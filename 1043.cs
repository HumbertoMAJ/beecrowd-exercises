using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string valores = Console.ReadLine();

        string[] separar = valores.Split(' ');

        double a = double.Parse(separar[0]);
        double b = double.Parse(separar[1]);
        double c = double.Parse(separar[2]);


        if (a + b > c && a + c > b && b + c > a)
        {
            double param = ((a + b) + c);

            Console.WriteLine("Perimetro = "+ param.ToString("0.0", CultureInfo.InvariantCulture));

        }
        else
        {
            double area = ((a + b)*c /2);
           
            Console.WriteLine("Area = "+ area.ToString("0.0", CultureInfo.InvariantCulture));
        }



    }

}