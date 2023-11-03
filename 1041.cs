using System;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();

        string[] separar = entrada.Split(' ');

        double A = double.Parse(separar[0]);
        double B = double.Parse(separar[1]);

        if(A >= 0.1 && B < 0.0)//Q4
        {
            Console.WriteLine("Q4");
        
        }else if (A >= 0.1 && B >= 0.1)//Q1
        {
            Console.WriteLine("Q1");
        
        }else if (A < 0.0 && B >= 0.1)//Q2
        {
            Console.WriteLine("Q2");
        
        }else if (A < 0.0 && B < 0.0)//Q3
        {
            Console.WriteLine("Q3");
        
        }else if (A != 0.0 && B == 0.0) //Eixo X
        {
            Console.WriteLine("Eixo X");
        }
        else if (B != 0.0 && A == 0.0)//Eixo Y
        {
            Console.WriteLine("Eixo Y");
        }
        else if (A == 0.0 && B == 0.0 )//Origem
        {
            Console.WriteLine("Origem");
        }



    }

}