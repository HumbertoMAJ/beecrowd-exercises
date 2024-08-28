using System;

class URI
{
    static void Main(string[] args)
    {
        int cont = 0;

        for (int i = 0; i < 50; i++)
        {
            string ent = Console.ReadLine();
            string[] separar = ent.Split(' ');

            int v1 = int.Parse(separar[0]);
            int v2 = int.Parse(separar[1]);

            if (v1 <= 0 || v2 <= 0)
            {
                break;
            }

            string valor = "";  

            if (v1 > v2)
            {
                for (int j = v2; j <= v1; j++)
                {
                    valor += j + " ";  
                    cont += j;
                }
            }
            else
            {
                for (int x = v1; x <= v2; x++)
                {
                    valor += x + " ";  
                    cont += x;
                }
            }

            Console.WriteLine(valor + "Sum=" + cont);  
            cont = 0;  
        }
    }
}
