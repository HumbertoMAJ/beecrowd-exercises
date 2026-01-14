using System;
using System.Text;

class URI
{
    static void Main(string[] args)
    {
        int entrada = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c;

        StringBuilder sb = new StringBuilder();

        sb.Append(a);
        sb.Append(" " + b);

        for (int i = 0; i < entrada - 2; i++)
        {
            c = a + b;
            sb.Append(" " + c);
            a = b;
            b = c;
        }

        Console.WriteLine(sb.ToString());
    }
}
