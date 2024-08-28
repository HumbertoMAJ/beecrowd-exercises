using System;

class URI
{

    static void Main(string[] args)
    {

       int N = int.Parse(Console.ReadLine());
        int aux = 0;

        for (int i = 0; i < N; i++)
        {
            string Ent = Console.ReadLine();

            string[] e = Ent.Split(' ');

            int v1 = int.Parse(e[0]);
            int v2 = int.Parse(e[1]);
               

            if (v1 > v2)
            {
                for (int j = v2 + 1 ; j < v1; j++)
                {
                    if(j % 2 != 0)
                    {
                        aux += j;
                    }

                }
                

            }
            else
            {
                for (int x = v1 + 1; x < v2; x++)
                {
                    if (x % 2 != 0)
                    {
                        aux += x;
                    }

                }
                
                
            }
            Console.WriteLine(aux);
            aux = 0;




        }

    }

}
