using System;

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; } 

    public Produto(string nome, decimal preco, int estoque)
    {
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
    }
}

class Program
{
    static void Main(string[] args) 
    {
        Produto produto = new Produto("Notebook", 3500.00m, 10);

        Console.WriteLine($"Nome: {produto.Nome}");
        Console.WriteLine($"Preço: {produto.Preco}");
        Console.WriteLine($"Estoque: {produto.Estoque}");
    }
}