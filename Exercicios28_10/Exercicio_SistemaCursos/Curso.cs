namespace Exercicio_SistemaCursos
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public int Horas { get; set; }

        public abstract double CalcularPreco();
        public string ExibirResumo() => $"Curso: {Nome} com {Horas}, valendo R$ {CalcularPreco():F2}";
    }
}