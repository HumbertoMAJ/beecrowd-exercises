using System;

class URI
{

    static void Main(string[] args)
    {
        int inn = 0;
        int outt = 0;

        int N = int.Parse(Console.ReadLine());

        if(N < 10000)
        {
            for (int i = 1; i <= N; i++)
            {

                int X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20) 
                {
                    inn++;
                }
                else
                {
                    outt++;
                }

            }

            Console.WriteLine(inn+" in");
            Console.WriteLine(outt+" out");





        }






    }

}