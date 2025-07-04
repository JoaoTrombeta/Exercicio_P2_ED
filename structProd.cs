using System;

public class Produto
{
    [cite_start]// Dados do produto [cite: 16]
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Fabricante { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEstoque { get; set; }

    public Produto(string nome, string descricao, string fabricante, double preco, int quantidadeEstoque)
    {
        Nome = nome;
        Descricao = descricao;
        Fabricante = fabricante;
        Preco = preco;
        QuantidadeEstoque = quantidadeEstoque;
    }

    [cite_start]
    [cite_start]public void AplicarCupomDesconto(double taxaDescontoPercentual) [cite: 17]
    {
        if (taxaDescontoPercentual > 0 && taxaDescontoPercentual <= 100)
        {
            double valorDesconto = Preco * (taxaDescontoPercentual / 100.0);
            Preco -= valorDesconto;
            Console.WriteLine($"Cupom de {taxaDescontoPercentual}% aplicado. Desconto de R${valorDesconto:F2}. Novo preço: R${Preco:F2}.");
        }
        else
        {
            Console.WriteLine("A taxa de desconto deve estar entre 0 e 100.");
        }
    }

    [cite_start]public void Imprimir() [cite: 17]
    {
        Console.WriteLine("\n--- Dados do Produto ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Fabricante: {Fabricante}");
        Console.WriteLine($"Preço: R${Preco:F2}");
        Console.WriteLine($"Quantidade em Estoque: {QuantidadeEstoque}");
        Console.WriteLine("------------------------\n");
    }
}

