using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double I = 0;
        double J = 1;
        int cont = 0;

        while (I <= 2.01) 
        {
            
            string iFormat = (Math.Round(I, 1) % 1 == 0) ? I.ToString("0", CultureInfo.InvariantCulture) : I.ToString("0.0", CultureInfo.InvariantCulture);

            
            string jFormat = (Math.Round(J, 1) % 1 == 0) ? J.ToString("0", CultureInfo.InvariantCulture) : J.ToString("0.0", CultureInfo.InvariantCulture);

           
            Console.WriteLine($"I={iFormat} J={jFormat}");

            J++;
            cont++;

            if (cont == 3)
            {
                J = 1;
                I += 0.2;
                J += I;
                cont = 0;
            }
        }
    }
}
