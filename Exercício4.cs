using System;

namespace Módulo2Semana6 {
    internal class Exercício4 {
        string nome = "";
        double valor = 0;
        int estoque = 0;

        Console.WriteLine("Digite o nome do produto: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            valor = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o estoque do produto: ");
            estoque = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, valor, estoque);
        Console.WriteLine("Produto adicionado com sucesso!");
            Console.WriteLine("Nome: " + produto.Nome);
            Console.WriteLine("Valor: " + produto.Valor);
            Console.WriteLine("Estoque: " + produto.Estoque);
            Console.WriteLine("");
            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());
        produto.AdicionarProduto(quantidade);

            try {
                produto.AdicionarProduto(0);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
    }
}
