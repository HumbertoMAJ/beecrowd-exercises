using System;

class URI
{

    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        bool vf = true;
        int aux = 0;
        int conta= 0;
        int N = 0;

        
            while (vf)
            {
                if (X > Y || X == Y)
                {
                    Y = int.Parse(Console.ReadLine());
            }
            else
            {
                vf = false;
            }
             
            }


        vf= true;
        while (vf)
        {
            aux = aux + X++;
            N++;
            conta = X + aux;

            if (conta > Y)
            {
                Console.WriteLine(N+1);
                vf = false;
            }
        }
       

       
       
          
       



    }

}