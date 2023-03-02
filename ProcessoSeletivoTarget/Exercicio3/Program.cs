using System;

class Exercicio3
{
    static void Main(string[] args)
    {

        string[] estado = new string[5];
        double[] faturamento = new double[5];

        estado[0] = "SP";
        faturamento[0] = 67836.43;
        estado[1] = "RJ";
        faturamento[1] = 36678.66;
        estado[2] = "MG";
        faturamento[2] = 29229.88;
        estado[3] = "ES";
        faturamento[3] = 27165.48;
        estado[4] = "outros";
        faturamento[4] = 19849.53;

        double faturamentoTotal = 0;
        foreach (double valor in faturamento)
        {
            faturamentoTotal += valor;
        }

        Console.WriteLine($"O faturamento total mensal é de R${faturamentoTotal}");

        for (int i = 0; i < faturamento.Length; i++)
        {
            double percentual = (faturamento[i] * 100) / faturamentoTotal;
            Console.WriteLine($"{estado[i]} - Faturamento mensal = {faturamento[i]} - Percentual de representação no faturamento total mensal = {Math.Round(percentual, 2)}%");
        };
    }
}