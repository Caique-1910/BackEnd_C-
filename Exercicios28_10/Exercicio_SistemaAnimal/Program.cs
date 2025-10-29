namespace Exercicio_SistemaAnimal;

class Program
{
    static void Main(string[] args)
    {
        Animal leao = new Leao { Nome = "Simba" };
        Animal elefante = new Elefante { Nome = "Dumbo" };

        Console.WriteLine(leao.EmitirSom());
        Console.WriteLine(leao.TipoAlimentacao());

        Console.WriteLine("\n" + elefante.EmitirSom());
        Console.WriteLine(elefante.TipoAlimentacao());
    }
}
