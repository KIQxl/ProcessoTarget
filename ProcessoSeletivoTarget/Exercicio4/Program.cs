using System;

class Exercicio4
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite uma palavra ou 'S' para sair");
            string palavra = Console.ReadLine();


            if (palavra.ToUpper() == "S")
            {
                break;
            }
            else
            {
                inverse(palavra);
            }
        }


        void inverse(string palavra)
        {
            string palavraInverse = "";
            for (int i = (palavra.Length - 1); i >= 0; i--)
            {
                palavraInverse += palavra[i];
            }

            Console.WriteLine(palavraInverse);
        }
    }
}