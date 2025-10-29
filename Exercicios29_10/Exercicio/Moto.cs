namespace Parte1
{
public class Moto : Veiculo, ICombustivel
    {
        public int Cilindrada { get; set; }
        public string Ligar() => $"A moto {Modelo} de {Cilindrada}cc esta pronta";
        public void Abastecer(double litros) => Console.WriteLine($"Carro abastecido com {litros} litros de gasolina");
        public void VerificarNivelCombustivel() => Console.WriteLine("Nível de combustível da moto verificado");
    }
}