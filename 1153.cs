using System;
class URI
{

    static void Main(string[] args)
    {

        int N = int.Parse(Console.ReadLine());
        int X = 0;

        if (N > 0 && N < 13)
        {
            X = N;

            for (int i = 1; i < X; i++)
            {
                N = N * (X - i);

            }

            Console.WriteLine(N);

        }

    }
}
