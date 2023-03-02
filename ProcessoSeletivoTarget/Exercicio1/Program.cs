using System;

class Exercicio1
{
    static void Main(string[] args)
    {

        int number1 = 0, number2 = 1, aux;

        for (int i = 0; i < 20; i++)
        {
            aux = number1;
            number1 = number2;
            number2 = number1 + aux;

            Console.WriteLine($"{number2}");
        }
    }
}