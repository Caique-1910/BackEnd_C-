namespace Exercicio_SistemaFuncionario;

class Program
{
    static void Main(string[] args)
    {
        Vendedor vendedor = new Vendedor{ Nome = "Carlos", SalarioBase = 3000.00 };
        Gerente gerente = new Gerente { Nome = "Ana", SalarioBase = 5000.00 };
        
        Console.WriteLine(vendedor.ExibirResumo());
        Console.WriteLine(gerente.ExibirResumo());
    }
}
