using System;

class URI
{

    static void Main(string[] args)
    {

        int contagem = 0;

        for (int i = 1; i < 7; i++)
        {
            
            string valor = Console.ReadLine();
            double numero = double.Parse(valor);
            
            if (numero >=0)
            {
                contagem++;
            }           
        }
        Console.WriteLine(contagem+ " valores positivos");

      


    }

}
