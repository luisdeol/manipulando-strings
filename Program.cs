using System;
using System.Globalization;
using System.Text;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            const string frase = "LuisDev é um blog do Luis Felipe";

            var luisIndexOf = frase.IndexOf("Luis");
            var blogIndexOf = frase.IndexOf("blog");
            var luisLastIndexOf = frase.LastIndexOf("Luis");
            var luisStartsWith = frase.StartsWith("Luis");
            var luisContains = frase.Contains("Luis");
            var blogSubstring = frase.Substring(blogIndexOf, 4);

            Console.WriteLine($"Índice de primeira ocorrência de Luis: {luisIndexOf}");
            Console.WriteLine($"Índice de primeira ocorrência de blog: {blogIndexOf}");
            Console.WriteLine($"Índice de última ocorrência de Luis: {luisLastIndexOf}");
            Console.WriteLine($"String começa com Luis: {luisStartsWith}");
            Console.WriteLine($"String contém Luis: {luisContains}");
            Console.WriteLine($"Substring de blog: {blogSubstring}");

            var nomes = new string[] { "Luis", "Francisco", "Leonardo", "Ivan", "Lucas", "Paulo" };
            var stringBuilder = new StringBuilder();

            foreach (var nome in nomes) {
                stringBuilder.AppendLine($"Seja bem-vindo {nome}");
            }

            Console.WriteLine(stringBuilder);

            double preco = 14.99;
            var now = DateTime.Now;

            var precoFormatadoDolar = preco.ToString("C", new CultureInfo("en-US", false));
            var precoFormatadoCulturaLocal = preco.ToString("C", CultureInfo.CurrentCulture);

            Console.WriteLine("----- Formatação de moeda -----");

            Console.WriteLine($"Preço (em dólares): {precoFormatadoDolar}");
            Console.WriteLine($"Preço (em  moeda local): {precoFormatadoCulturaLocal}");

            Console.WriteLine("----- Formatação de data -----");

            Console.WriteLine("----- Usando string.Format -----");
            var dataStringFormat = string.Format("Data longa: {0:D}, Data Curta: {1:d}, Moeda: {2:C}\n", now, now, preco);
            Console.WriteLine(dataStringFormat);

            Console.WriteLine("----- Usando sobrecargas de ToString -----");

            var dataFormatadaLonga = now.ToString("D"); // equivalente a now.ToLongDateString();
            var dataFormatadaCurta = now.ToString("d"); // equivalente a now.ToShortDateString();
            var dataFormatadaPersonalizada = now.ToString("dd-MM-yyyy");

            Console.WriteLine($"Data em formato longo: {dataFormatadaLonga}");
            Console.WriteLine($"Data em formato curto: {dataFormatadaCurta}");
            Console.WriteLine($"Data em formato dd-MM-yyyy: {dataFormatadaPersonalizada}\n");

            Console.WriteLine("----- Usando interpolação de string -----");

            Console.WriteLine($"Data longa: {now:D}, Data curta: {now:d}, Moeda: {preco:C}");

            Console.ReadLine();
        }
    }
}