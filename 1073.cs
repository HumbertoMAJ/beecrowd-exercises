using System;

class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        int calc;
        if (N > 5 && N < 2000)
        {

            for (int i = 1; i <= N; i++)
            {
                if(i % 2 == 0)
                {
                    calc = i * i;
                    Console.WriteLine(i+"^2 = "+ calc);
                }


            }

        }

    }
}
