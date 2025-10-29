namespace Exercicio_SistemaVeiculos;

class Program
{
    static void Main(string[] args)
    {
        Veiculo Carro1 = new Carro { Modelo = "Toyota Corolla", Ano = 2020 };
        Veiculo Moto1 = new Moto { Modelo = "Honda CB500", Ano = 2001 };

        Console.WriteLine(Carro1.ExibirResumo());
        Console.WriteLine(Moto1.ExibirResumo());
    }
}
