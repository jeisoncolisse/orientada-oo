using System;

// classe base (modelo)
abstract class Entrega
{
    public abstract (int prazo, double valor) Calcular(string cep);
}

// Correios
class Correios : Entrega
{
    public override (int prazo, double valor) Calcular(string cep)
    {
        int prazo = 5;
        double valor = 20;

        if (cep.StartsWith("9"))
            prazo++;

        return (prazo, valor);
    }
}

// Transportadora
class Transportadora : Entrega
{
    public override (int prazo, double valor) Calcular(string cep)
    {
        int prazo = 3;
        double valor = 35;

        if (cep.StartsWith("9"))
            prazo++;

        return (prazo, valor);
    }
}

// programa principal
class Program
{
    static void Main()
    {
        Console.Write("CEP: ");
        string cep = Console.ReadLine() ?? "";

        Console.Write("1 = Correios | 2 = Transportadora: ");
        string tipo = Console.ReadLine();

        Entrega entrega;

        if (tipo == "1")
            entrega = new Correios();
        else
            entrega = new Transportadora();

        var resultado = entrega.Calcular(cep);

        Console.WriteLine("\nResultado:");
        Console.WriteLine("Prazo: " + resultado.prazo + " dias");
        Console.WriteLine("Valor: R$ " + resultado.valor);
    }
}