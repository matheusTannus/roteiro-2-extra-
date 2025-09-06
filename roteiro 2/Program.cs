/*using System;

public class Pessoa
{
    public string Nome;
    public int Idade;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} anos.");
    }
}

public class program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Idade = 21;
        p1.Nome = "Matheus";
        p1.Apresentar();
    }
}*/


/*using System;

public class Produto
{
    private string Nome;
    private double Preco;

    public string nome
    {
        get { return Nome; }
        set { nome = value; }
    }

    public double preco
    {
        get { return Preco; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Saldo Negativo!");
                Preco = 0; // ou você pode lançar um erro aqui
            }
            else
            {
                Preco = value;
            }
        }
    }
    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;

    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome}, {Preco}");
    }
}

class Rodar
{
    public static void Main()
    {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();
        p.preco = -200; // Deve exibir uma mensagem de erro

    }
}*/
