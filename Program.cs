using Exercicio04.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade de produtos: ");
            int qnt = int.Parse(Console.ReadLine());

            List<Produto> list = new List<Produto>();

            for(int i = 1; i <= qnt; ++i)
            {
                Console.WriteLine($"DADOS DO PRODUTO #{i}");
                Console.Write("Comum, Usado ou Importado (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                  list.Add(new Produto(nome,preco));
                }
                else if (ch == 'u')
                {
                    Console.Write("Data de Fabricação");
                    DateTime dataFabrica = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, dataFabrica));
                }
                else
                {
                    Console.Write("Taxa de importação: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ProdutoImportado(nome, preco, taxa));

                }

            }
            Console.WriteLine();
            Console.WriteLine("TAGS DE PREÇOS:");
            foreach (Produto prod in list)
            {
                Console.WriteLine(prod.tagPreco());
            }
        }
    }
}
