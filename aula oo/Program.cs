using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Informações do time
        string nome = "SER Caxias do Sul";
        string fundacao = "10/04/1935";
        string tecnico = "Marcelo Cabo";

        List<string> titulos = new List<string>
        {
            "Campeonato Gaúcho 2000",
            "Campeonato Brasileiro Série C 2002"
        };

        // Exibindo dados
        Console.WriteLine("=== Dados do Time ===");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Fundação: " + fundacao);
        Console.WriteLine("Técnico: " + tecnico);
        Console.WriteLine("Títulos:");

        foreach (string titulo in titulos)
        {
            Console.WriteLine("- " + titulo);
        }
    }
}