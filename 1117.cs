using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int cont = 5;
        int vezes = 0;
        double calculo = 0;

        for (int i = 0; i < cont; i++)
        { 
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
                                 
            if (N >= 0 && N <= 10)
            {
                calculo += N;

                vezes++;
            }else if(N < 0 || N > 10)
            {
                Console.WriteLine("nota invalida");
                cont++;

            }

            if (vezes == 2)
            {
                double numero = calculo / 2;
                Console.WriteLine("media = " +numero.ToString("0.00", CultureInfo.InvariantCulture));
                break;
            }
        
        }

    }

}