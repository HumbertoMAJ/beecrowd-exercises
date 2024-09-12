using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

       
        double calculo = 0;
        int vezes = 0;
        bool continuar = true;

        while(continuar)
        { 
               double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if(N >= 0 && N <= 10)
            {
                calculo += N;
                vezes++;
            }else if (N < 0 || N > 10)
            {
                Console.WriteLine("nota invalida");
                
            }

            if (vezes == 2)
            {
                double numero = calculo / 2;
                Console.WriteLine("media = " + numero.ToString("0.00", CultureInfo.InvariantCulture));

                bool perguntar = true;

                while (perguntar)
                {

                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    int sn = int.Parse(Console.ReadLine());

                    if (sn == 1)
                    {
                        
                        vezes = 0;
                        calculo = 0;
                        perguntar = false;

                    }
                    else if (sn == 2)
                    {
                        
                        continuar = false;
                        perguntar = false;

                    }
                    else if (sn < 1 || sn > 2)
                    {
                        
                    }
                }


            }


               





        }



        }
    }

