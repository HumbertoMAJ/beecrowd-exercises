using System;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();

        int convert = int.Parse(entrada);

        if(convert > 1 && convert <= 1000)
        {

            for(int i = 1;i <= convert; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }


            }

        }





    }

}