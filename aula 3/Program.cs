using System;

// Classe base
class Inimigo
{
    public string Nome{get;set;}

    public virtual void Ataque()
    {
        Console.WriteLine(Nome + " está Atacando");
    }
}

// Classes filhas
class Zumbi : Inimigo
{
    public override void Ataque()
    {
        Console.WriteLine("Ataque");
    }
}

class Vampiro : Inimigo
{
    public override void Ataque()
    {
        Console.WriteLine("Sugando"); 
    }

}

class Fantasma : Inimigo
{
    public override void Ataque()
    {
         Console.WriteLine("Invisivel"); 
    }
}

class Program
{
    static void Main()
    {
        Inimigo inimigo1 = new Zumbi();
        inimigo1.Nome = "Carlos";
        inimigo1.Ataque();

        Inimigo inimigo2 = new Vampiro();
        inimigo2.Nome = "Anderson";
        inimigo2.Ataque();

        Inimigo inimigo3 = new Fantasma();
        inimigo3.Nome = "Artur";
        inimigo3.Ataque();
    }
}