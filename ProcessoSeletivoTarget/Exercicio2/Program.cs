using System.IO;
using Newtonsoft.Json;
using System;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {

            string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "data.json");

            using StreamReader file = File.OpenText(caminhoArquivo);

            string json = file.ReadToEnd();

            List<Faturamento> listaFaturamento = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            double fatTotal = 0;
            int diasSemFat = 0;
            for (int i = 0; i < listaFaturamento.Count; i++)
            {
                if (listaFaturamento[i].valor == 0)
                {
                    diasSemFat++;
                }

                fatTotal += listaFaturamento[i].valor;
            }

            double mediaFat = fatTotal / (listaFaturamento.Count - diasSemFat);
            int diasFatSup = 0;

            for (int i = 0; i < listaFaturamento.Count; i++)
            {
                if (listaFaturamento[i].valor > mediaFat)
                {
                    diasFatSup++;
                }
            }

            double maiorFat = listaFaturamento.Max(f => f.valor);
            double menorFat = listaFaturamento.Min(f => f.valor);

            Console.WriteLine($"Média de faturamento: {Math.Round(mediaFat, 2)}");
            Console.WriteLine($"Dias com o faturamento maior que a media {diasFatSup}");
            Console.WriteLine($"Valor do maior faturamento {Math.Round(maiorFat, 2)}");
            Console.WriteLine($"Valor do menor faturamento {menorFat}");
        }
    }
}