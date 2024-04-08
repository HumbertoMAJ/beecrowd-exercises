using System;

class URI
{

    static void Main(string[] args)
    {




        string[] d = Console.ReadLine().Split(' ');
        int DIA = int.Parse(d[1]);

        string[] d1 = Console.ReadLine().Split(':');

        string[] r = Console.ReadLine().Split(' ');
        int DIA1 = int.Parse(r[1]);

        string[] v1 = Console.ReadLine().Split(':');

        int HORAS = int.Parse(d1[0]);
        int MINUS = int.Parse(d1[1]);
        int SEG = int.Parse(d1[2]);

        int HORAS1 = int.Parse(v1[0]);
        int MINUS1 = int.Parse(v1[1]);
        int SEG1 = int.Parse(v1[2]);

        int diaI = (DIA) * 24 * 60 * 60 + HORAS * 60 * 60 + MINUS * 60 + SEG;
        int diaF = (DIA1) * 24 * 60 * 60 + HORAS1 * 60 * 60 + MINUS1 * 60 + SEG1;

        int diferença = diaF - diaI;

        int DIAF = diferença / (24 * 60 * 60);
        int RT = diferença % (24 * 60 * 60);
        int HRS = RT / (60 * 60);
        int MT = RT % (60 * 60);
        int MINUST = MT / 60;
        int SEGT = MT % 60;

        Console.WriteLine(DIAF + " dia(s)");
        Console.WriteLine(HRS + " hora(s)");
        Console.WriteLine(MINUST + " minuto(s)");
        Console.WriteLine(SEGT + " segundo(s)");




    }

}