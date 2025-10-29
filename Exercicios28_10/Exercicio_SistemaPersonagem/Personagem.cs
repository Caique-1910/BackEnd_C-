namespace Exercicio_SistemaPersonagem
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }

        public abstract int CalcularPoder();
        public string ExibirStatus() => $"Nome do personagem: {Nome}, Nível: {Nivel}, Poder: {CalcularPoder()}";
    }
}