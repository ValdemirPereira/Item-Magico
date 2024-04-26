using System;

public class ItemMagico
{
    //Cria a classe ItemMagico com os atributos nome, descrição e poder

    public string Nome {get; }
    public string Descricao {get; }
    public int Poder {get; }
    
    public ItemMagico(string nome, string descricao, int poder)
    {
        Nome = nome;
        Descricao = descricao;
        Poder = poder;
    }
    
    // Recebe como argumento os valores do nome, descrição e poder do item, respectivamente.
    public static ItemMagico Criar(string nome, string descricao, int poder)
    {
      return new ItemMagico(nome, descricao, poder);
    }
    
    
}

class Program
{
    static void Main(string[] args)
    {
        // Recebe a entrada do usuário

        Console.WriteLine("Item: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Descrição: ");
        string descricao = Console.ReadLine();

        Console.WriteLine("Poder");
        int poder = int.Parse(Console.ReadLine());

        // Cria o item mágico
        ItemMagico item = new ItemMagico(nome, descricao, poder);

        // Imprime o item criado
        Console.WriteLine("Você criou");
        Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");
        Console.ReadKey();
    }
}