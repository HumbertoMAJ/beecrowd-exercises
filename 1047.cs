using System;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();

        string[] valores = entrada.Split(' ');

        int hi = int.Parse(valores[0]);
        int mi = int.Parse(valores[1]); 
        int hf = int.Parse(valores[2]);
        int mf = int.Parse(valores[3]);
        int horaInicial = (hi * 60) + mi;
        int horaFinal = (hf * 60) + mf;
        int resultado;

        if (horaInicial < horaFinal)
        {
            resultado = horaFinal - horaInicial;
        
        
        }
        else
        {
            resultado = (24 * 60 - horaInicial) + horaFinal;
        }

        int dHora = resultado / 60;
        int dMinuto = resultado % 60;

        Console.WriteLine("O JOGO DUROU " + dHora + " HORA(S) E " + dMinuto + " MINUTO(S)");





    }

}
    

