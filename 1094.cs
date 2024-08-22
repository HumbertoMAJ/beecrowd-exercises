using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        //cobaias: sapos, ratos e coelhos


        int N = int.Parse(Console.ReadLine());
        double C= 0;
        double S = 0;
        double R = 0;
        double Tot = 0;
        double aux = 0;     

       
        
            for (int i = 0; i < N; i++)
            {
                string Q = Console.ReadLine();
                string[] separar = Q.Split(' ');

                aux = int.Parse(separar[0], CultureInfo.InvariantCulture);
                
                if (separar[1] == "S")
                {
                    
                    S += aux;

                }else if(separar[1] == "C")
                {
                    C += aux;

                }else if(separar[1] == "R")
                {
                    R += aux;
                }

            }

            Tot = C + S + R;
            double calc1 = (C / Tot) * 100;
            double calc2 = (S / Tot) * 100;
            double calc3 = (R / Tot) * 100;

            Console.WriteLine("Total: "+ Tot + " cobaias");

            Console.WriteLine("Total de coelhos: "+C);

            Console.WriteLine("Total de ratos: "+R);

            Console.WriteLine("Total de sapos: "+S);

            Console.WriteLine("Percentual de coelhos: "+ calc1.ToString("0.00", CultureInfo.InvariantCulture)+" %");

            Console.WriteLine("Percentual de ratos: "+ calc3.ToString("0.00", CultureInfo.InvariantCulture) + " %");

            Console.WriteLine("Percentual de sapos: "+ calc2.ToString("0.00", CultureInfo.InvariantCulture) + " %");




            
            

        }

    }
