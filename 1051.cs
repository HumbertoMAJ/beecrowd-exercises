using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();
        double valor = double.Parse(entrada, CultureInfo.InvariantCulture);
        double resto;
        double calculo;


        if (valor <= 2000.0)
        {
            Console.WriteLine("Isento");

        }
        else
        {
            if(valor > 2000.00 && valor <= 3000.00)
            {
                valor += -2000.00;
                calculo = (valor * 0.08);
            }
            else if (valor > 3000.00 && valor <= 4500.00)
            {
                resto = 1000.00;
                calculo = (resto * 0.08);
                valor += -3000.00;
                calculo += valor * 0.18;
            }
            else
            {
                resto = 1000.00;
                calculo = resto * 0.08;
                resto = 1500.00;
                calculo += resto * 0.18;
                valor += -4500.00;
                calculo += valor * 0.28;
            }

            Console.WriteLine("R$ "+ calculo.ToString("0.00", CultureInfo.InvariantCulture));

        }




    }

}
