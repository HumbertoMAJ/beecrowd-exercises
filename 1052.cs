using System;

class URI
{

    static void Main(string[] args)
    {

        string entrada = Console.ReadLine();
        int valor = int.Parse(entrada);
        string saida;
        switch (valor)
        {
            case 1:
                saida = "January";
                break;
            case 2:
                saida = "February";
                break;
            case 3:
                saida = "March";
                break;
            case 4:
                saida = "April";
                break;
            case 5:
                saida = "May";
                break;
            case 6:
                saida = "June";
                break;
            case 7:
                saida = "July";
                break;
            case 8:
                saida = "August";
                break;
            case 9:
                saida = "September";
                break;
            case 10:
                saida = "October";
                break;
            case 11:
                saida = "November";
                break;
            case 12:
                saida = "December";
                break;
            
            default:
                saida = "não existe";
                break;

                
        }
        Console.WriteLine(saida);
    }

}