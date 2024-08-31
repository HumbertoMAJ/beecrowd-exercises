using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string ent = Console.ReadLine();
            string[] valor = ent.Split(' ');

            double v1 = double.Parse(valor[0]);
            double v2 = double.Parse(valor[1]);

            
            if (v2 == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = v1 / v2;
                Console.WriteLine(resultado.ToString("0.0", CultureInfo.InvariantCulture));
            }
        }
    }
}
