using System;


class URI
{

    static void Main(string[] args)
    {

        int casos = 1;

        for (int i = 0; i < casos; i++)
        {

            string ent = Console.ReadLine();

            string[] convert = ent.Split(' ');

            int v1 = int.Parse(convert[0]);
            int v2 = int.Parse(convert[1]);

            if(v1 == 0 || v2 == 0)
            {
                break;
            
            }else if( v1 < 0 && v2 > 0)
            {
                Console.WriteLine("segundo");
                casos++;
            }
            else if (v1 > 0 && v2 > 0)
            {
                Console.WriteLine("primeiro");
                casos++;
            }
            else if (v1 > 0 && v2 < 0)
            {
                Console.WriteLine("quarto");
                casos++;
            }
            else if (v1 < 0 && v2 < 0)
            {
                Console.WriteLine("terceiro");
                casos++;
            }



        }

    }

}