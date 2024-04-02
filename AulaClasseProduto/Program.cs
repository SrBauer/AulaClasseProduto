using AulaClasseProduto;
using System;
using System.Globalization;

namespace AulaclasseProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque: ");
            produto.Quant = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.WriteLine("Informe quantos produtos foi adicionado");
            int qte = int.Parse (Console.ReadLine());
            produto.addProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atuaalizados: " + produto);

            Console.WriteLine();
            Console.WriteLine("Informe quantos produtos para ser removidos");
            qte = int.Parse(Console.ReadLine());
            produto.removerProduto(qte);

            Console.WriteLine();
            Console.Write("Dados atuaalizados: " + produto);
        }
    }
}