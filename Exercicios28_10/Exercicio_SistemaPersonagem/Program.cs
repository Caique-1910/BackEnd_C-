namespace Exercicio_SistemaPersonagem;

class Program
{
    static void Main(string[] args)
    {
        Guerreiro guerreiro = new Guerreiro { Nome = "Albert", Nivel = 2 };
        Mago mago = new Mago { Nome = "Cleber", Nivel = 3 };

        Console.WriteLine(guerreiro.ExibirStatus());
        Console.WriteLine(mago.ExibirStatus());
    }
}
