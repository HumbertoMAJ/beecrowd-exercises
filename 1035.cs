using System;

class URI
{

    static void Main(string[] args)
    {
        //------- recebendo numeros-------
        string numeros = Console.ReadLine();
        //--------------------------------
       
        string[] separar = numeros.Split(' ');
        //-- Separados em A,B,C,D
        int A = Int32.Parse(separar[0]);
        int B = Int32.Parse(separar[1]);
        int C = Int32.Parse(separar[2]);
        int D = Int32.Parse(separar[3]);
        //--------------------------------

        //Se B FOR > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A% 2 == 0

        if(B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }




    }

}