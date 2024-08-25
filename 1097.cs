using System;

class URI
{

    static void Main(string[] args)
    {

        int I = 1;
        int J = 7;
        int cont = 0;


        while (I < 11)
        {

            Console.WriteLine(@"I=" + I + " J=" + J);
            J--;
            cont++;

            if (cont == 3)
            {
                I += 2;
                cont = 0;
                J += 5;

            }

        }






    }

}