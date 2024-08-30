using System;

class URI
{

    static void Main(string[] args)
    {

        int senha = 2002;
        int tentativas = 1;

        for (int i = 0; i < tentativas; i++) 
        {
            int senha2 = int.Parse(Console.ReadLine());

            if (senha2 != senha) 
            {
                Console.WriteLine("Senha Invalida");
                tentativas++;
            }
            else
            {
                Console.WriteLine("Acesso Permitido");
            }
        }

    }

}