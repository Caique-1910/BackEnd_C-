namespace Parte1
{
    public class Carro : Veiculo, ICombustivel
    {
        public int NumeroPortas { get; set; }
        public string Ligar() => $"O carro {Modelo} esta pronto para rodar";
        public void Abastecer(double litros) => Console.WriteLine($"Carro abastecido com {litros} litros de gasolina");
        public void VerificarNivelCombustivel() => Console.WriteLine($"Nível de combustível do carro verificado");
    }
}