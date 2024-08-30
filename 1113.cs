using System;

class URI
{

    static void Main(string[] args)
    {

        for (int i = 0; i < 50; i++)
        {
            string ent = Console.ReadLine();

            string[] s = ent.Split(' ');

            int v1 = int.Parse(s[0]);
            int v2 = int.Parse(s[1]);

            if (v1 == v2)
            {
                break;

            }
            else if (v1 > v2)
            {
                Console.WriteLine("Decrescente");
            }
            else
            {
                Console.WriteLine("Crescente");
            }

        }

    }
}