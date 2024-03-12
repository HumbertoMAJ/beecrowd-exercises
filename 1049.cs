using System;

class URI
{

    static void Main(string[] args)
    {


        string a1 = Console.ReadLine();
        string a2 = Console.ReadLine();
        string a3 = Console.ReadLine();

        if (a1 == "vertebrado")
        {

            if (a2 == "ave")
            {
                if (a3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");

                }

            }
            else
            {
                
                if (a3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");

                }

            }

        }
        else if (a1 == "invertebrado")
        {

            

            if (a2 == "inseto")
            {
                if (a3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");

                }

            }
            else
            {
                
                if (a3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                {
                    Console.WriteLine("minhoca");

                }

            }






            
        }


        }
    }


