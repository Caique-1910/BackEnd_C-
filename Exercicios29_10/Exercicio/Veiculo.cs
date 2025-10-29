namespace Parte1
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public string Ligar() => $"O veiculo {Modelo} esta ligado";

        public string ExibirDetalhes() => $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}";
    }
}