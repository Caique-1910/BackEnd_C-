namespace Exercicio_SistemaFuncionario
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public abstract double CalcularSalario();
        public string ExibirResumo() => $"Nome do funcionario: {Nome}, Salário: {CalcularSalario():C2}";
    }
}