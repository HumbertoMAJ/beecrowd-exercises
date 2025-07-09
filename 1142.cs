using System;




namespace _1142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int numero = 0;

            if (N > 0) 
            {
                         
                for (int i = 0; i < N; i++) 
                {

                Console.WriteLine(++numero + " "+ ++numero + " " + ++numero  + " PUM");
                numero++;

                }


            }

        }
    }
}
