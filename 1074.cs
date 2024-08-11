using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());


        if(N < 10000)
        {

            for (int i = 0; i < N; i++) 
            {

                int P = int.Parse(Console.ReadLine());

               


                    if (P == 0)
                    {
                        Console.WriteLine("NULL");

                    }
                    else if (P % 2 == 0 && P > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else if (P % 2 == 0 && P < 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");

                    }
                    else if (P % 2 != 0 && P > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else if (P % 2 != 0 && P < 0)
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                    //fim dos ifs elses normais
                


            }//laço for
        }//1F 10000




    }
}