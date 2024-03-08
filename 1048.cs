using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();

        double valor = double.Parse(entrada, CultureInfo.InvariantCulture);

  
        double calculo;
        double salario;


        if(valor <= 400.00)
        {
            
            calculo = valor * 0.15;
            salario = valor + calculo;

            Console.WriteLine("Novo salario: "+salario.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: "+calculo.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 15 %");

        }else if (valor >= 400.01 && valor <= 800.00)
        {
            calculo = valor * 0.12;
            salario = valor + calculo;

            Console.WriteLine("Novo salario: " + salario.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + calculo.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 12 %");

        }else if (valor >= 800.01 && valor <= 1200.00)
        {
            calculo = valor * 0.10;
            salario = valor + calculo;

            Console.WriteLine("Novo salario: " + salario.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + calculo.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 10 %");
        
        }else if (valor >= 1200.01 && valor <= 2000.00)
        {
            calculo = valor * 0.07;
            salario = valor + calculo;

            Console.WriteLine("Novo salario: " + salario.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + calculo.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 7 %");
       
        }else if (valor > 2000.00 )
        {
            calculo = valor * 0.04;
            salario = valor + calculo;

            Console.WriteLine("Novo salario: " + salario.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + calculo.ToString("0.00", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: 4 %");
        }

    }

}