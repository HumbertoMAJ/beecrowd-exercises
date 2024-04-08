using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int cont = 0;
        double conta= 0;
        double valores = 0;

        for (int i = 0; i < 6; i++)
        {
            
            string entrada = Console.ReadLine();
            double converter = double.Parse(entrada, CultureInfo.InvariantCulture);
            double[] v = new double[6];
            v[i] = converter;
            
            
            if (v[i] > 0)
            {
                 cont++;

                valores = valores + v[i];
            }

            if(i == 5)
            {
                conta = valores / cont;
                Console.WriteLine(cont + " valores positivos");
                Console.WriteLine(conta.ToString("F1", CultureInfo.InvariantCulture) );
            }

        }

    }
}