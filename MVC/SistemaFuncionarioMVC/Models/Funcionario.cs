using System.ComponentModel.DataAnnotations;

namespace SistemaFuncionarioMVC.Models
{
    public abstract class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required] // Obriga a passar um nome
        public string Nome { get; set; } = string.Empty;

        [Range(0, 10000)]
        public double SalarioBase { get; set; }

        public Funcionario() { }
        public Funcionario(string NomeConstrutor, double SalarioBaseConstrutor)
        {
            Nome = NomeConstrutor;
            SalarioBase = SalarioBaseConstrutor;
        }

        public abstract double CalcularSalario();
    }
}